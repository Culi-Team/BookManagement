using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    public class BookManagementDbContextFactory : IDesignTimeDbContextFactory<BookManagementDbContext>
    {
        public BookManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookManagementDbContext>();

            //var connectionString = "server=192.168.1.27;database=BusinessTripDB;user=topv;password=1234";
            var connectionString = "server=localhost;database=BookManagementDb;user=root;password=123456";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new BookManagementDbContext(optionsBuilder.Options);
        }
    }
}
