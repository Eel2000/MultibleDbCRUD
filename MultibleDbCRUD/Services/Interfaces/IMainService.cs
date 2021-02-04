using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultibleDbCRUD.Services.Interfaces
{
    public interface IMainService
    {
        Task<IEnumerable<T>> GetAllSchool<T>();
        Task<IEnumerable<T>> GetAllStudentFromSchool<T>();
        Task Add(string firstname, string lastname, string school);
    }
}
