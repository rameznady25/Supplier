using Autofac;
using SupplierWebApp.Commands.WriteRepository;
using SupplierWebApp.Queries.Contracts;
using SupplierWebApp.Queries.ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierWebApp.AutofacModules
{
    public class ApplicationModule : Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;
        }



        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<GenericRepository>()
            //    .As<IGenericRepository>()
            //    .InstancePerLifetimeScope();

            
            builder.RegisterType<AreaRepository>()
            .As<IAreaRepository>()
            .InstancePerLifetimeScope();


            builder.Register(c => new AreaQueries(QueriesConnectionString))
                .As<IAreaQueries>()
                .InstancePerLifetimeScope();
        }
    }
}
