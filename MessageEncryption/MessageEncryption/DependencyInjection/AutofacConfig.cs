﻿using Autofac;
using Autofac.Integration.Mvc;
using MessageEncryption.Services;
using MessageEncryption.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageEncryption.DependencyInjection
{
	public class AutofacConfig
	{
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            // регистрируем споставление типов
            builder.RegisterType<MessageService>().As<IMessageService>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}