using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIPractice1.Model;

namespace CoreAPIPractice1.DAO
{
    public interface IDepartmentsDAO
    {
        public Task<IEnumerable<Department>> GetDepartments();
        public Task<Department> GetDepartmentById(int id);

        public Task<Department> AddDepartment(Department department);

        ///This is for test checkin


       

    }
}
