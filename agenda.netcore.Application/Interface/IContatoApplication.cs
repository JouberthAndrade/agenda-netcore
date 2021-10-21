using agenda.netcore.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace agenda.netcore.Application.Interface
{
	public interface IContatoApplication
	{
		Task<IEnumerable<ContatoModel>> Listar();
		Task<ContatoModel> ListarPorId(int id);
	}
}
