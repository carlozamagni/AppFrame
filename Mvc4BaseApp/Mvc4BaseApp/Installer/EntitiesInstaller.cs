using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Mvc4BaseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4BaseApp.Installer
{
    public class EntitiesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ISampleModel>().ImplementedBy<SampleModel>());
        }
        
    }
}