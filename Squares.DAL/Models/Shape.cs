using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.DAL.Models
{
    public enum ShapeEnum
    {
        Parallelogram,
        Trapeze
    }
    public class Shape
    {
        [Key]
        public int ShapeID { get; set; }
        public ShapeEnum ShapeEnum { get; set; }
    }
}
