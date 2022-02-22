using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KeuAPI.Models;

namespace KeuAPI.Repositories
{
    public interface ISiswaRepository
    {
        Task<ActionResult<IEnumerable<ViewMasterSiswa2122>>> GetMasterSiswa2122Async();
        Task<ActionResult<Siswa>> GetSiswaByNoSPJAsync(string nospj);
    }
}
