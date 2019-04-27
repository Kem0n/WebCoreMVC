using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    class EFDBContext : DbContext
    {
        public DbSet<Directory> directories { get; set; }
    }
}
