﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salesWebMvc4.Models;

namespace salesWebMvc4.Data
{
    public class salesWebMvc4Context : DbContext
    {
        public salesWebMvc4Context (DbContextOptions<salesWebMvc4Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
