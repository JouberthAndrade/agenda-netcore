using System.Collections.Generic;
using System.Reflection;

namespace agenda.netcore.CrossCutting.Assemblies
{
	public static class AssemblyUtil
    {
        public static IEnumerable<Assembly> GetCurrentAssemblies()
        {
            return new Assembly[]
            {
                Assembly.Load("agenda.netcore.Api"),
                Assembly.Load("agenda.netcore.Application"),
                Assembly.Load("agenda.netcore.CrossCutting"),
                Assembly.Load("agenda.netcore.Domain"),
                Assembly.Load("agenda.netcore.Infra")
            };
        }
    }
}
