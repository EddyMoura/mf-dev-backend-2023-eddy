using mf_dev_backend_2023_eddy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2023_eddy.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly AppDbContext _context;
        public VeiculosController(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index ()
        {
            var dados = await _context.Veiculos.ToListAsync();

            return View(dados);
        }
    }
}
