using agenda.netcore.Domain.Entities;
using agenda.netcore.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace agenda.netcore.Infra.Repositories
{
	public class ContatoRepository : IContatoRepository
	{
		public bool Inserir(Contato contato)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Contato> Listar()
		{
			var contatos = GetContatos();
			return contatos;
		}

		public Contato ListarPorId(int id)
		{
			var contatos = GetContatos();
			return contatos.Where(x => x.Id == id).FirstOrDefault();
		}


		private List<Contato> GetContatos() 
		{
			var retorno = new List<Contato>();
			retorno.Add(new Contato("Marcos"));
			retorno.Add(new Contato("Roberto"));
			retorno.Add(new Contato("Leila"));
			retorno.Add(new Contato("Larissa"));
			retorno.Add(new Contato("Ana"));
			retorno.Add(new Contato("João"));
			retorno.Add(new Contato("Fabiana"));

			for (int i = 0; i < retorno.Count; i++)
				retorno[i].SetarId(i + 1);

			return retorno;
		}
	}
}
