

using AutoMapper;
using EmployeeCrudApi.Data;
using EmployeeCrudApi.Employees.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using EmployeeCrudApi.Data;
using EmployeeCrudApi.Employees.Model;
using EmployeeCrudApi.Employees.Repository.Interfaces;


namespace ProductsCrudApi.Products.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {


        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public EmployeeRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
