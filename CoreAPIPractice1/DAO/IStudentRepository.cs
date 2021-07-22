using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIPractice1.Model;


namespace CoreAPIPractice1.DAO
{
 public   interface IStudentRepository
    {
        public Task<IEnumerable<Student>> GetAllstudents();
        public Task<Student> Getstudent(int id);

        public Task<Student> AddStudent(Student student);

        public Task<Student> UpdateStudent(Student student);

        public Task<Student> DeleteStudent(int id);
        
    }
}
