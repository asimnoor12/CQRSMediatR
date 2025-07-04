using CQRSMediatR.Data.Command;
using CQRSMediatR.Data.Query;
using CQRSMediatR.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatR.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllEmployee")]
        public async Task<List<Employee>> GetAll()
        {
            var employees = await _mediator.Send(new GetAllEmployeesQuery());
            return employees;
        }

        [HttpGet("{id}")]
        public async Task<Employee> GetById(int id)
        {
            var employee = await _mediator.Send(new GetEmployeeByIdQuery(id));
            return employee;
        }

        [HttpPost]
        public async Task<Employee> Create(Employee employee)
        {
            var result = await _mediator.Send(new CreateEmployeeCommand(
                employee.Name, employee.Address, employee.Email, employee.Phone));
            return result;
        }

        [HttpPut("{id}")]
        public async Task<int> Update(Employee employee)
        {
            var result = await _mediator.Send(new UpdateEmployeeCommand(
                employee.Id, employee.Name, employee.Address, employee.Email, employee.Phone));
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await _mediator.Send(new DeleteEmployeeCommand(id));
        }

    }
}
