using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Data.Repositories;
using Webmotors.Domain.Interfaces.InterfaceRepository;
using SimpleInjector;

namespace Webmotors.ioc
{
    public static class SimpleInjectorContainer
    {
        //static readonly Container container;
        public static Container Container;

        //static SimpleInjectorContainer()
        //{
        //    container = new Container();
        //}

        public static Container RegisterServices()
        {
            Container container = new Container();

            container.Register<IAnuncioRepository, AnuncioRepository>(); //Lifestyle.Singleton

            container.Verify();
            Container = container;
            return Container;
        }

    }
}
