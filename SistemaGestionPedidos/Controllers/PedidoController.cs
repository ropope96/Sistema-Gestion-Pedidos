using System.Web.Mvc;

namespace SistemaGestionPedidos.Controllers
{
	public class PedidoController : Controller
	{
		// GET: Pedido 
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult GenerarPedido()
		{
			return View();
		}
	}
}