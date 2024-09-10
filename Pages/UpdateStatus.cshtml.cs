using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PedidoApp.Data;
using PedidoApp.Models;
using System.Threading.Tasks;

namespace PedidoApp.Pages
{
    public class UpdateStatusModel : PageModel
    {
        private readonly AppDbContext _context;

        public UpdateStatusModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pedido Pedido { get; set; }

        public async Task<IActionResult> OnGetAsync(int pedidoId)
        {
            // Busca o pedido pelo ID
            Pedido = await _context.Pedidos.FindAsync(pedidoId);

            if (Pedido == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int pedidoId)
        {
            var pedido = await _context.Pedidos.FindAsync(pedidoId);

            if (pedido == null)
            {
                return NotFound();
            }

            // Atualizar o status do pedido com a nova descrição
            pedido.Status = new Status
            {
                Tipo = "Atualizado",  // Define um valor para o tipo de status
                Descricao = Pedido.Status.Descricao,  // O valor preenchido no formulário
                DataHora = System.DateTime.Now
            };

            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
