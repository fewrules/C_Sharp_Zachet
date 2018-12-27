using Squares.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.DAL.Context
{
    public class SqueresContext : DbContext
    {
        public SqueresContext()
            : base("Squares")
        { }

        public DbSet<Point> Points { get; set; }
        public DbSet<Shape> Shapes { get; set; }
    }
}
