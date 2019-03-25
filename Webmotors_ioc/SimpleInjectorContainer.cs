using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webmotors.Data.Repositories;
using Webmotors.Domain.Interfaces.InterfaceRepository;
using SimpleInjector;
using Webmotors.Domain.Interfaces.InterfaceService;
using Webmotors.Domain.Services;
using Webmotors.Data.Context;
using Webmotors.Application.Interfaces;
using Webmotors.Application.Aplication;

namespace Webmotors.ioc
{
    public static class SimpleInjectorContainer
    {

        public static Container Container;

        public static Container RegisterServices()
        {
            Container container = new Container();

            container.Register<IAnuncioRepository, AnuncioRepository>();
            container.Register<IAnuncioService, AnuncioService>();
            container.Register<IWebmotorsContext, WebmotorsContext>(Lifestyle.Singleton);
            container.Register<IAnuncioApplication, AnuncioApplication>();

            container.Verify();
            Container = container;
            return Container;
        }

    }
}
