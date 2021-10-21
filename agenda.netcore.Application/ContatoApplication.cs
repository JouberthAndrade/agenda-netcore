using agenda.netcore.Application.Interface;
using agenda.netcore.Domain.Models;
using agenda.netcore.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace agenda.netcore.Application
{
	public class ContatoApplication : IContatoApplication
	{
		private readonly IContatoRepository _contatoRepository;

		public ContatoApplication(IContatoRepository contatoRepository)
		{
			_contatoRepository = contatoRepository;
		}

		public Task<IEnumerable<ContatoModel>> Listar()
		{
			throw new NotImplementedException();
		}

		public Task<ContatoModel> ListarPorId(int id)
		{
			throw new NotImplementedException();
		}
	}
}
