using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace bgb.netcore.mes.EntityFrameworkCore.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<bgbmesDbContext>
    {
        //ApplicationDbContext 代表的是你的创建失败的那个类型
        public bgbmesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<bgbmesDbContext>();
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bgbNetCoreMES;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            var context = new bgbmesDbContext(builder.Options);
            return context;
        }
    }
}
