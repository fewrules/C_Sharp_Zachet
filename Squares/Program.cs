using Squares.DAL.Context;
using Squares.DAL.Models;
using Squares.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            Create();
            Print();
            Console.ReadKey();
        }

        public static void Print()
        {
            using (SqueresContext dbCont = new SqueresContext())
            {
                ShapeRepository shapeRep = new ShapeRepository(dbCont);
                PointRepository pointRep = new PointRepository(dbCont);

                List<Shape> shapes = shapeRep.Get();
                List<Point> points = pointRep.GetWithInclude(x => x.ShapeID).ToList();

                foreach(var shape in shapes)
                {
                    Console.Write(shape.ShapeEnum.ToString());
                    foreach(var point in points)
                    {
                        if(point.ShapeID.ShapeID == shape.ShapeID)
                        {
                            Console.WriteLine("  " + point.X + " " + point.Y);
                        }
                    }
                }
            }
        }

        public static void Create()
        {
            using (SqueresContext dbCont = new SqueresContext())
            {
                Shape par = new Shape()
                {
                    ShapeEnum = ShapeEnum.Parallelogram
                };
                Point p1 = new Point()
                {
                    ShapeID = par,
                    X = 1,
                    Y = 2
                };

                Point p2 = new Point()
                {
                    ShapeID = par,
                    X = 1,
                    Y = 4
                };

                Point p3 = new Point()
                {
                    ShapeID = par,
                    X = 4,
                    Y = 2
                };

                Point p4 = new Point()
                {
                    ShapeID = par,
                    X = 5,
                    Y = 2
                };

                Shape trapeze = new Shape()
                {
                    ShapeEnum = ShapeEnum.Trapeze
                };
                Point tr1 = new Point()
                {
                    ShapeID = par,
                    X = 1,
                    Y = 2
                };

                Point tr2 = new Point()
                {
                    ShapeID = par,
                    X = 1,
                    Y = 4
                };

                Point tr3 = new Point()
                {
                    ShapeID = par,
                    X = 4,
                    Y = 2
                };

                Point tr4 = new Point()
                {
                    ShapeID = par,
                    X = 5,
                    Y = 2
                };

                ShapeRepository rep = new ShapeRepository(dbCont);
                rep.Create(par);
                rep.Create(trapeze);

                PointRepository pointRep = new PointRepository(dbCont);
                pointRep.Create(p1);
                pointRep.Create(p2);
                pointRep.Create(p3);
                pointRep.Create(p4);
                pointRep.Create(tr1);
                pointRep.Create(tr2);
                pointRep.Create(tr3);
                pointRep.Create(tr4);
            }
        }
    }
}
