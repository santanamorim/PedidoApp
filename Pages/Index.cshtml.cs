using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PedidoApp.Data;
using PedidoApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
        public List<Status> Statuses { get; set; } = new List<Status>();
        public List<Relatorio> Relatorios { get; set; } = new List<Relatorio>();

        [BindProperty]
        public Cliente NovoCliente { get; set; } = new Cliente();

        [BindProperty]
        public Pedido NovoPedido { get; set; } = new Pedido();

        public void OnGet()
        {
            Clientes = _context.Clientes.ToList();
            Pedidos = _context.Pedidos
                .Include(p => p.Cliente)
                .ToList();
            Statuses = _context.Statuses.ToList();
            Relatorios = _context.Relatorios.ToList();
        }

        public async Task<IActionResult> OnPostCreateClienteAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clientes.Add(NovoCliente);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { tab = "clientes" });
        }

        public async Task<IActionResult> OnPostCreatePedidoAsync()
        {
            if (NovoPedido.ClienteId == 0)
            {
                ModelState.AddModelError(string.Empty, "Por favor, selecione um cliente.");
                Clientes = _context.Clientes.ToList();
                return Page();
            }

            NovoPedido.DataCadastro = DateTime.Now;

            try
            {
                _context.Pedidos.Add(NovoPedido);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError(string.Empty, "Erro ao salvar o pedido. Verifique se o cliente existe.");
                Clientes = _context.Clientes.ToList();
                return Page();
            }

            return RedirectToPage(new { tab = "pedidos" });
        }
    }
}
