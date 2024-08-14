using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Celsia.Data;
using Celsia.Models;

namespace Celsia.Controllers
{
    public class TransaccionesController : Controller
    {

        public readonly BaseContext _context;

        public TransaccionesController(BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Leer(){
            return View(await _context.Transacciones.ToListAsync());
        }


        //Delete
        public async Task<IActionResult>Eliminar(int id){
            var Transaccion = await _context.Transacciones.FindAsync(id);

            _context.Transacciones.Remove(Transaccion);

            await _context.SaveChangesAsync();

            return RedirectToAction("Leer");
        }

        // //Create
        public IActionResult Crear(){
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Transacciones u){
            _context.Transacciones.Add(u);
            _context.SaveChanges();
            return RedirectToAction("Leer");            
        }
        
        public async Task<IActionResult>Actualizar(int? id){
            return View(await _context.Transacciones.FirstOrDefaultAsync(m=> m.IdTransaccion == id));
        }

        [HttpPost]
        public IActionResult Actualizar(int id, Transacciones Transaccion){
            _context.Transacciones.Update(Transaccion);
            _context.SaveChanges();
            return RedirectToAction("Leer");
        }
    }
}