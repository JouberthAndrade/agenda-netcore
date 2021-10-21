using System;
using System.Collections.Generic;
using System.Text;

namespace agenda.netcore.Domain.Entities
{
	public class Contato
	{
		public Contato(string nome)
		{
			Nome = nome;
		}

		public int Id { get; private set; }
		public string Nome { get; private set; }

		public void SetarId(int id)
		{
			this.Id = id;
		}
	}
}
