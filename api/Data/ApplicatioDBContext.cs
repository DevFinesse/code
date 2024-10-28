using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    //inherits DbContext from EF Core
    public class ApplicatioDBContext : DbContext
    {
        //Constructor
        public ApplicatioDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        public DbSet<Stock> Stocks {get; set;}
        public DbSet<Comment> Comments {get; set;}
    }
}