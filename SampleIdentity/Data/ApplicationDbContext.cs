﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleIdentity.Models;

namespace SampleIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mahasiswa> Mahasiswa { get; set; }
        public DbSet<Matakuliah> Matakuliah { get; set; }
        public DbSet<Pengambilan> Pengambilan { get; set; }
    }
}
