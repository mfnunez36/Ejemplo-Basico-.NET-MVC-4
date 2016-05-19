using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC4_Basico
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "raiz",
                url: "",
                defaults: new { controller = "Pacientes", action = "Index" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );


            //Rutas del Paciente
            routes.MapRoute(
                name: "Pacientes",
                url: "Pacientes",
                defaults: new { controller = "Pacientes", action = "Index" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Nuevo_Paciente",
                url: "Pacientes/Nuevo",
                defaults: new { controller = "Pacientes", action = "Nuevo" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Pacientes_Fonasa",
                url: "Pacientes/Fonasa",
                defaults: new { controller = "Pacientes", action = "Fonasa" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );
            
            
            routes.MapRoute(
                name: "Pacientes_Isapre",
                url: "Pacientes/Isapre",
                defaults: new { controller = "Pacientes", action = "Isapre" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Ver_Paciente",
                url: "Pacientes/{ID}",
                defaults: new { controller = "Pacientes", action = "Ver" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Editar_Paciente",
                url: "Pacientes/{ID}/Editar",
                defaults: new { controller = "Pacientes", action = "Editar" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );




            //RUTA PARA VER ENFERMEDADES PACIENTE

            routes.MapRoute(
                name: "Enfermedades_Paciente",
                url: "Pacientes/{ID}/Enfermedades",
                defaults: new { controller = "Pacientes", action = "Enfermedades_Paciente" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );
            









            //Rutas Enfermedades

            routes.MapRoute(
                name: "Enfermedades",
                url: "Enfermedades",
                defaults: new { controller = "Enfermedades", action = "Index" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Nueva_Enfermedad",
                url: "Enfermedades/Nueva",
                defaults: new { controller = "Enfermedades", action = "Nueva" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Enfermedad_Auge",
                url: "Enfermedades/Auge",
                defaults: new { controller = "Enfermedades", action = "Auge" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Enfermedad_NoAuge",
                url: "Enfermedades/NoAuge",
                defaults: new { controller = "Enfermedades", action = "NoAuge" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );


            routes.MapRoute(
                name: "Ver_Enfermedades",
                url: "Enfermedades/{ID}",
                defaults: new { controller = "Enfermedades", action = "Ver" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );

            routes.MapRoute(
                name: "Editar_Enfermedades",
                url: "Enfermedades/{ID}/EditarEnfermedades",
                defaults: new { controller = "Enfermedades", action = "Editar" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new string[] { "GET" }) }

            );


        }
    }
}