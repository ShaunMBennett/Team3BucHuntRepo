using team3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace team3.Interfaces
{
    public interface ITaskService
    {
        Task<int> Create(Tasks tasks);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Tasks tasks);
        Task<Tasks> GetById(int Id);
        Task<List<Tasks>> ListAll(int skip, int take,
            string orderBy, string direction, string search);
    }
}
