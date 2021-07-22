using CoreAPIPractice1.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIPractice1.Model;

namespace CoreAPIPractice1.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
       
        public StudentController(IStudentRepository _studentRepository)
        {
            this.studentRepository = _studentRepository;
        }


        //private readonly IDepartmentsDAO departmentsDAO;

        //public DepartmentController(IDepartmentsDAO departmentsDAO)
        //{
        //    this.departmentsDAO = departmentsDAO;
        //}


        [HttpGet]
        [Route("GetStudents")]
        public async Task<ActionResult> GetStudents()
        {
            try
            {
                return Ok(await studentRepository.GetAllstudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpGet]
        [Route("GetStudent")]
        public async Task<ActionResult> GetStudent(int id)
        {
            try
            {
                return Ok(await studentRepository.Getstudent(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            try
            {
                return Ok(await studentRepository.DeleteStudent(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPut]
        public async Task<ActionResult> DeleteStudent(Student studet)
        {
            try
            {
                return Ok(await studentRepository.UpdateStudent(studet));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddStudent(Student studet)
        {
            try
            {
                return Ok(await studentRepository.AddStudent(studet));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


    }


}
