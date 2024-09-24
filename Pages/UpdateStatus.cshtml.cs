using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PedidoApp.Data;
using PedidoApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PedidoApp.Pages
{
    public class UpdateStatusModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Pedido Pedido { get; set; } = new Pedido();

        public UpdateStatusModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);

            if (Pedido == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pedido).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Pedidos.Any(p => p.Id == Pedido.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Index");
        }
    }
}
