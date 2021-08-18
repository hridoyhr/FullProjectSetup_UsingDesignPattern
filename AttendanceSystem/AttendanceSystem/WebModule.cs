using AttendanceSystem.Areas.Admin.Models;
using AttendanceSystem.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleDatabaseServices>().As<IDatabaseService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentListModel>().AsSelf();

            base.Load(builder);
        }
    }
}
