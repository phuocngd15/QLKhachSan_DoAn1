using System;
using System.Collections.Generic;
using System.Text;
using HappyHoTel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HappyHoTel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phong> Phongs { get; set; }
        public DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<HappyHoTel.Models.LoaiDichVu> LoaiDichVu { get; set; }
        public DbSet<HappyHoTel.Models.DichVu> DichVu { get; set; }
    }
}
