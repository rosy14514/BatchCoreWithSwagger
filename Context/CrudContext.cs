using BatchCoreWithSwagger.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatchCoreWithSwagger.Context
{
    public class CrudContext:DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options):base(options)
        {

        }
        public DbSet<Batch> Batches { get; set; }
    }
}
