using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIPractice1.DAO;
using CoreAPIPractice1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreAPIPractice1.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentsDAO departmentsDAO;

        public DepartmentController(IDepartmentsDAO departmentsDAO)
        {
            this.departmentsDAO = departmentsDAO;
        }

        [HttpGet]       
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                return Ok(await departmentsDAO.GetDepartments());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        //[Route("GetDepartmentByID")]
        public async Task<ActionResult> GetDepartment(int id)
        {
            try
            {
                return Ok(await departmentsDAO.GetDepartmentById(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        //[Route("AddDepartment")]
        public async Task<ActionResult> AddDepartmet(Department department)
        {
            try
            {
                return Ok(await departmentsDAO.AddDepartment(department));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }



    }
}
