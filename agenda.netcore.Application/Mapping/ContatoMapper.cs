using agenda.netcore.Domain.Entities;
using agenda.netcore.Domain.Models;
using AutoMapper;

namespace agenda.netcore.Application.Mapping
{
	public class ContatoMapper : Profile
	{
		public ContatoMapper()
		{
			CreateMap<ContatoModel, Contato>()
				   .ReverseMap();
		}
	}
}
