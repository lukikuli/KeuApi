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
    public class SiswaRepository : ISiswaRepository
    {
        private readonly KeuApiContext _context;
        public SiswaRepository(KeuApiContext context)
        {
            this._context = context;
        }
        public async Task<ActionResult<IEnumerable<ViewMasterSiswa2122>>> GetMasterSiswa2122Async()
        {
            var siswas = _context.ViewMasterSiswa2122.FromSqlRaw("EXEC GetView_Master_Siswa_2122").AsQueryable();
            return await siswas.ToListAsync();
        }
        public async Task<ActionResult<Siswa>> GetSiswaByNoSPJAsync(string nospj)
        {
            var NoSPJ = new SqlParameter("@NoSPJ", nospj);
            var siswa = (await _context.Siswa.FromSqlRaw("EXEC GetSiswaByNoSPJ @NoSPJ", NoSPJ).ToListAsync()).FirstOrDefault();
            return siswa;
        }
    }
}
