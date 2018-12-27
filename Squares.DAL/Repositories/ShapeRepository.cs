using Squares.DAL.Context;
using Squares.DAL.Models;

namespace Squares.DAL.Repositories
{
    public class ShapeRepository : GenericRepository<Shape>
    {
        public ShapeRepository(SqueresContext context) : base(context)
        {

        }
    }
}
