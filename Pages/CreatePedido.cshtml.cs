using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PedidoApp.Data;
using PedidoApp.Models;

namespace PedidoApp.Pages
{
    public class CreatePedidoModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Pedido Pedido { get; set; }

        public CreatePedidoModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Pedido.DataCadastro = DateTime.Now;
            Pedido.Status = new Status { Tipo = "Pendente", DataHora = DateTime.Now };
            _context.Pedidos.Add(Pedido);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
