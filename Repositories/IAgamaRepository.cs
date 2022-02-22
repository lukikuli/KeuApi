using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KeuAPI.Models;

namespace KeuAPI.Repositories
{
    public interface IAgamaRepository
    {
        Task<ActionResult<IEnumerable<Agama>>> GetAllAgamaAsync();
        Task<ActionResult<Agama>> GetAgamaByIdAsync(Guid id);
        //Task<ActionResult<IEnumerable<Agama>>> GetAgamaByIdAsync(Guid id);
    }
}
