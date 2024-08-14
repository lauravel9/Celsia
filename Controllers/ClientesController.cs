using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Celsia.Models;
using Microsoft.EntityFrameworkCore;
using Celsia.Data;
using Microsoft.AspNetCore.Authentication;


namespace Celsia.Controllers
{
    public class ClientesController : Controller
    {    
        public readonly BaseContext _context;

        public ClientesController(BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Leer()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        //Eliminar
        public async Task<IActionResult>Eliminar(int id){
            var Cliente = await _context.Clientes.FindAsync(id);

            _context.Clientes.Remove(Cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction("Leer");
        }

        // //Crear
        public IActionResult Crear(){
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Clientes u){
            _context.Clientes.Add(u);
            _context.SaveChanges();
            return RedirectToAction("Leer");            
        }

        //Actualizar
        public async Task<IActionResult>Actualizar(int? id){
            return View(await _context.Clientes.FirstOrDefaultAsync(m=> m.IdCliente == id));
        }

        [HttpPost]
        public IActionResult Actualizar(int id, Clientes Cliente){
            _context.Clientes.Update(Cliente);
            _context.SaveChanges();
            return RedirectToAction("Leer");
        }
    }
}