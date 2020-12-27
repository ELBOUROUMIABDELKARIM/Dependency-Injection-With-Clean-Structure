using Autofac;
using ClassLibrary;
using ClassLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<DataAccessSqlServer>().As<IDataAccess>();
            builder.RegisterType<SqlData>().As<IDatabaseData>();
            builder.RegisterType<Dashboard>().As<Dashboard>();
            return builder.Build();
        }
    }
}
