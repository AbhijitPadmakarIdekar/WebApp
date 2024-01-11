using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain.Entities;
using WebApp.Domain.Repository;

namespace WebApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var actorsFromRepo = _unitOfWork.Employee.GetAll();
            return Ok(actorsFromRepo);
        }

        [HttpGet("SortBySalary")]
        public ActionResult<IEnumerable<Employee>> SortBySalary(string sortOrder)
        {
            var employees = _unitOfWork.Employee.GetAll();

            switch (sortOrder)
            {
                case "salary_desc":
                    employees = employees.OrderByDescending(e => e.Salary);
                    break;
                case "salary_asc":
                    employees = employees.OrderBy(e => e.Salary);
                    break;
                default:
                    break;
            }

            return employees.ToList();
        }

        [HttpGet("GetByDepartmentId/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetByDepartmentId(string departmentId)
        {
            var employees = _unitOfWork.Employee.GetAll().Where(e => e.Department == departmentId);

            return employees.ToList();
        }

        [HttpGet("GetByEmployeeId/{employeeId}")]
        public ActionResult<Employee> GetByEmployeeId(int employeeId)
        {
            var employee = _unitOfWork.Employee.GetById(employeeId);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }
    }
}
