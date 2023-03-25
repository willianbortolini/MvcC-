using salesWebMvc4.Data;
using salesWebMvc4.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace salesWebMvc4.Services
{
    public class DepartmentService
    {
        private readonly salesWebMvc4Context _context;

        public DepartmentService(salesWebMvc4Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
