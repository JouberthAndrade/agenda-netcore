using agenda.netcore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace agenda.netcore.Domain.Repositories
{
	public interface IContatoRepository
	{
		bool Inserir(Contato contato);
		IEnumerable<Contato> Listar();
		Contato ListarPorId(int id);
	}
}
