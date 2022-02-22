using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KeuAPI.Models;
using KeuAPI.Repositories;

namespace KeuAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        //private readonly KeuApiContext _context;
        private readonly ISiswaRepository _repository;
        public SiswaController(ISiswaRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Siswa/MasterSiswa2122
        [HttpGet, Route("MasterSiswa2122")]
        public async Task<ActionResult<IEnumerable<ViewMasterSiswa2122>>> GetMasterSiswa2122()
        {
            return await _repository.GetMasterSiswa2122Async();
        }

        // GET: api/Siswa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Siswa>> GetSiswa(string nospj)
        {
            return await _repository.GetSiswaByNoSPJAsync(nospj);
        }

    }
}
