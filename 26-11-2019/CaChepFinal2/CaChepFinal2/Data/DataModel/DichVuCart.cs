using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CaChepFinal2.Data;

namespace CaChepFinal2.Data
{
    public class DichVuCart
    {
        private readonly ApplicationDbContext _context;

        public DichVuCart(ApplicationDbContext context)
        {
            _context = context;
        }

        public string Id { get; set; }
        public IEnumerable<DichVuCartItem> listDichVuCartItems { get; set; }

        public static DichVuCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            return new DichVuCart(context) { Id = cartId };
        }

        public bool AddToCart(DichVu dv, int amount)
        {
            if (dv.InStock == 0 || amount == 0)
            {
                return false;
            }

            var dvCartItem = _context.dichVuCartItems.SingleOrDefault(
                s => s.DichVu.Id == dv.Id && s.DichVuCartId == Id);
            var isValidAmount = true;
            if (dvCartItem == null)
            {
                if (amount > dv.InStock)
                {
                    isValidAmount = false;
                }
                dvCartItem = new DichVuCartItem
                {
                    DichVuCartId = Id,
                    DichVu = dv,
                    Amount = Math.Min(dv.InStock, amount)
                };
                _context.dichVuCartItems.Add(dvCartItem);
            }
            else
            {
                if (dv.InStock - dvCartItem.Amount - amount >= 0)
                {
                    dvCartItem.Amount += amount;
                }
                else
                {
                    dvCartItem.Amount += (dv.InStock - dvCartItem.Amount);
                    isValidAmount = false;
                }
            }


            _context.SaveChanges();
            return isValidAmount;
        }

        public int RemoveFromCart(DichVu dv)
        {
            var shoppingCartItem = _context.dichVuCartItems.SingleOrDefault(
                s => s.DichVu.Id == dv.Id && s.DichVuCartId == Id);
            int localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _context.dichVuCartItems.Remove(shoppingCartItem);
                }
            }

            _context.SaveChanges();
            return localAmount;
        }

        public IEnumerable<DichVuCartItem> GetShoppingCartItems()
        {
            return listDichVuCartItems ??
                   (listDichVuCartItems = _context.dichVuCartItems.Where(c => c.DichVuCartId == Id)
                       .Include(s => s.DichVu));
        }

        public void ClearCart()
        {
            var cartItems = _context
                .dichVuCartItems
                .Where(cart => cart.DichVuCartId == Id);

            _context.dichVuCartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            return _context.dichVuCartItems.Where(c => c.DichVuCartId == Id)
                .Select(c => c.DichVu.Price * c.Amount).Sum();
        }

    }
}
