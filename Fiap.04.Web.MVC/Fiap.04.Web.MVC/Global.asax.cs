﻿using Fiap._04.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fiap._04.Web.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //Estratégia de criação do banco, pode salvar sua NAC ou sua PS
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ImigracaoContext>());
        }
    }
}
