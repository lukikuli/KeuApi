using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KeuAPI.Data;
using KeuAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace KeuAPI.Repositories
{
    public class AgamaRepository : IAgamaRepository
    {
        private readonly KeuApiContext _context;
        public AgamaRepository(KeuApiContext context)
        {
            this._context = context;
        }
        public async Task<ActionResult<IEnumerable<Agama>>> GetAllAgamaAsync()
        {
            var agamas = _context.Agama.FromSqlRaw("EXEC GetAllAgama").AsQueryable();
            return await agamas.ToListAsync();
        }
        //public async Task<ActionResult<IEnumerable<Agama>>> GetAgamaByIdAsync(Guid id)
        public async Task<ActionResult<Agama>> GetAgamaByIdAsync(Guid id)
        {
            var AgamaId = new SqlParameter("@AgamaID", id);
            var agama = (await _context.Agama.FromSqlRaw("EXEC GetAgamaByAgamaID @AgamaID", AgamaId).ToListAsync()).FirstOrDefault();
            return agama;
        }
    }
}
