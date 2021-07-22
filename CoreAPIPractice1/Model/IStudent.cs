using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIPractice1.Model
{
   public interface IStudent
    {
        Task<IEnumerable<Student>> Search(string name);
        Task<IEnumerable<Student>> GetEmployees();
        Task<Student> GetEmployee(int employeeId);
        Task<Student> GetEmployeeByEmail(string email);
        Task<Student> AddEmployee(Student student);
        Task<Student> UpdateEmployee(Student student);
        Task DeleteEmployee(int employeeId);
    }
}
