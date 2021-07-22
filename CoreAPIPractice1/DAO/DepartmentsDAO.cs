using CoreAPIPractice1.Data;
using CoreAPIPractice1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreAPIPractice1.DAO
{
    public class DepartmentsDAO : IDepartmentsDAO
    {
        private readonly PracticeDbContext practiceDbContext;

        public DepartmentsDAO(PracticeDbContext practiceDbContext)
        {
            this.practiceDbContext = practiceDbContext;
        }
        
        public async Task<Department> AddDepartment(Department department)
        {
            try
            {

                if (department != null)
                {
                    practiceDbContext.Entry(department).State = EntityState.Unchanged;
                }

                var result = await practiceDbContext.Departments.AddAsync(department);
                await practiceDbContext.SaveChangesAsync();
                return result.Entity;

            }

            catch (Exception Ex)
            {
                throw Ex;
            }


        }
              
        public async Task<Department> GetDepartmentById(int id)
        
        {
            return await practiceDbContext.Departments.FirstOrDefaultAsync(j => j.DepartmentId == id);

        }
        
        public async Task<IEnumerable<Department>> GetDepartments()
        {

            return await practiceDbContext.Departments.ToListAsync();


        }



    }
}
