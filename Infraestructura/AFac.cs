using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public static class AFac
    {
        public static IContainer Container { get; private set; }

        public static event EventHandler<ContainerBuilder> AlRegistrarComponentes;

        public static void Registrar()
        {
            var builder = new ContainerBuilder();

            if (AlRegistrarComponentes != null)
                AlRegistrarComponentes.Invoke(null, builder);

            Container = builder.Build();
        }
    }
}
