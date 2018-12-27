using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.DAL.Models
{
    public class Point
    {
        [Key]
        public int PointID { get; set; }
        public Shape ShapeID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
