using Microsoft.AspNetCore.Identity;
using CaChepFinal.Data;
using CaChepFinal.Models.DataModels;
using CaChepFinal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaChepFinal.Models
{
    public class Mapper
    {

        #region Food

        public NewDichVuViewModel FoodToNewFoodModel(DichVu dv)
        {
            return new NewDichVuViewModel
            {
                Id = dv.Id,
                Name = dv.Name,
                CategoryId = dv.CategoryId,
                ConHang = dv.InStock,
                GiaTien = dv.Price,
                ShortDescription = dv.ShortDescription,
            };
        }


        // public DichVu NewDVModelViewToDichVu(NewFoodModel model, bool newInstance, ICategory categoryService)
        // {
        //     var food = new Food
        //     {
        //         Name = model.Name,
        //         Category = categoryService.GetById(model.CategoryId.Value),
        //         CategoryId = model.CategoryId.Value,
        //         ImageUrl = model.ImageUrl,
        //         InStock = model.InStock.Value,
        //         IsPreferedFood = model.IsPreferedFood.Value,
        //         LongDescription = model.LongDescription,
        //         Price = model.Price.Value,
        //         ShortDescription = model.ShortDescription,
        //     };

        //     if (!newInstance)
        //     {
        //         food.Id = model.Id;
        //     }

        //     return food;
        // }

        // private IEnumerable<FoodSummaryModel> FoodToFoodSummaryModel(IEnumerable<Food> foods)
        // {
        //     return foods.Select(food => new FoodSummaryModel
        //     {
        //         Name = food.Name,
        //         Id = food.Id
        //     });
        // }

        #endregion

    }
}
