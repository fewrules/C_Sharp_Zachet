using Squares.DAL.Context;
using Squares.DAL.Models;

namespace Squares.DAL.Repositories
{
    public class PointRepository : GenericRepository<Point>
    {
        public PointRepository(SqueresContext context) : base(context)
        {

        }
    }
}
