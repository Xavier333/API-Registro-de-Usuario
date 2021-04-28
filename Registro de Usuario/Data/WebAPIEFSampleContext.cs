using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIEFSample.Models;

namespace WebAPIEFSample.Data
{
    public class WebAPIEFSampleContext : DbContext
    {
        public WebAPIEFSampleContext (DbContextOptions<WebAPIEFSampleContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIEFSample.Models.Book> Book { get; set; }
    }
}
