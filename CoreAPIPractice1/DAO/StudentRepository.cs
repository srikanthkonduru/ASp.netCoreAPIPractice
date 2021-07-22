using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIPractice1.DAO;
using CoreAPIPractice1.Data;
using CoreAPIPractice1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CoreAPIPractice1.DAO
{
    public class StudentRepository : IStudentRepository
    {
        private readonly PracticeDbContext _practiceDbContext;

        public StudentRepository(PracticeDbContext practiceDbContext)
        {
            this._practiceDbContext = practiceDbContext;
        }

       


        public async Task<Student> AddStudent(Student student)
        {

            var result = await _practiceDbContext.Students.AddAsync(student);
            await _practiceDbContext.SaveChangesAsync();
            return result.Entity;




        }

        public async Task<IEnumerable<Student>> GetAllstudents()
        {
            return await _practiceDbContext.Students.ToListAsync();
        }

        public async Task<Student> Getstudent(int id)
        {
            return await _practiceDbContext.Students.FirstOrDefaultAsync(i => i.StudentId == id);
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            if (student != null && student.StudentId > 0)
            {
                var studentdata = _practiceDbContext.Students.FirstOrDefaultAsync(i => i.StudentId == student.StudentId);
                if (studentdata != null)
                {
                    studentdata.Result.DepartmentId = student.DepartmentId;
                    studentdata.Result.Gender = student.Gender;
                    studentdata.Result.Phone = student.Phone;
                    studentdata.Result.StudentEmail = student.StudentEmail;
                    studentdata.Result.StudentName = student.StudentName;

                }
                await _practiceDbContext.SaveChangesAsync();

                return studentdata.Result;
            }
            return null;
        }

        public async Task<Student> DeleteStudent(int id)
        {
            var student = _practiceDbContext.Students.FirstOrDefaultAsync(i => i.StudentId == id);
            if (student != null)
            {
                _practiceDbContext.Students.Remove(student.Result);
                await _practiceDbContext.SaveChangesAsync();
                
            }
            return student.Result;
        }
    }
}
