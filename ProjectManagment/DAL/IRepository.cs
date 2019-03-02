using System.Linq;

namespace ProjectManagment.DAL
{
    public interface IRepository<T> where T : IEntity
    {

        IQueryable<T> List();

    }
}
