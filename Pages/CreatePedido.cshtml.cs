using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PedidoApp.Data;
using PedidoApp.Models;
using System.Threading.Tasks;

namespace PedidoApp.Pages
{
    public class CreatePedidoModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Pedido Pedido { get; set; } = new Pedido();

        public CreatePedidoModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pedidos.Add(Pedido);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
