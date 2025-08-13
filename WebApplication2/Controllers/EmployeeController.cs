using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext DbContext)
        {
           _db = DbContext;
      
        }

        [HttpGet]
        public IActionResult getAllEmployes()
        {
            var Employees = _db.Employess.ToList();

            return Ok(Employees);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult getEmployee(Guid id)
        {
            var Employee = _db.Employess.Find(id);

            if(Employee == null)
            {
                return NotFound("employee does not exist");
            }
            else
            {
                return Ok(Employee);
            }

        }


        [HttpPost]
        public IActionResult addEmployee(AddEmployeeDTO employeDTO)
        {
            var EmployeeEntity = new Employee()
            {
                name = employeDTO.name,
                email = employeDTO.email,
                phone = employeDTO.phone,
                role = employeDTO.role,
                salary = 1000
            };


            _db.Employess.Add(EmployeeEntity);
            _db.SaveChanges();

            return Ok();

        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEmployee(Guid id,UpdateEmployeeDTO employeDTO)
        {
            var EmployeeEntity = _db.Employess.Find(id);

            if(EmployeeEntity == null)
            {
                return NotFound();
            }

            EmployeeEntity.name = employeDTO.name;

            _db.SaveChanges();
            return Ok(EmployeeEntity);
        }

    }
}
