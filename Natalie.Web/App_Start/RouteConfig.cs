using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sandbox
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            routes.IgnoreRoute("{folder}/{*pathInfo}", new { folder = "Content" });

            

            routes.MapRoute(
               "Index",
               "Index",
               new { controller = "Home", action = "Index" }
               );

            routes.MapRoute(
               "Scribbles",
               "Scribbles",
               new { controller = "Home", action = "Scribbles" }
               );

            routes.MapRoute(
               "Kids-Rings",
               "Kids-Rings",
               new { controller = "Home", action = "KidsRings" }
               );

            routes.MapRoute(
               "Piercing-Pieces",
               "Piercing-Pieces",
               new { controller = "Home", action = "PiercingPieces" }
               );

            routes.MapRoute(
               "New-Work",
               "New-Work",
               new { controller = "Home", action = "NewWork" }
               );

            routes.MapRoute(
               "Resin-Balls",
               "Resin-Balls",
               new { controller = "Home", action = "ResinBalls" }
               );

            routes.MapRoute(
               "Bump",
               "Bump",
               new { controller = "Home", action = "Bump" }
               );

            routes.MapRoute(
               "Brood",
               "Brood",
               new { controller = "Home", action = "Brood" }
               );

            routes.MapRoute(
               "Bulge",
               "Bulge",
               new { controller = "Home", action = "Bulge" }
               );

            routes.MapRoute(
               "Boiling-Over",
               "Boiling-Over",
               new { controller = "Home", action = "BoilingOver" }
               );

            routes.MapRoute(
               "Roach-Study",
               "Roach-Study",
               new { controller = "Home", action = "RoachStudy" }
               );

            routes.MapRoute(
               "Crack",
               "Crack",
               new { controller = "Home", action = "Crack" }
               );

            routes.MapRoute(
               "Shifting",
               "Shifting",
               new { controller = "Home", action = "Shifting" }
               );

            routes.MapRoute(
               "Occupancy",
               "Occupancy",
               new { controller = "Home", action = "Occupancy" }
               );

            routes.MapRoute(
               "Combat",
               "Combat",
               new { controller = "Home", action = "Combat" }
               );

            routes.MapRoute(
               "Phenomenon",
               "Phenomenon",
               new { controller = "Home", action = "Phenomenon" }
               );

            routes.MapRoute(
               "Metal-Pods",
               "Metal-Pods",
               new { controller = "Home", action = "MetalPods" }
               );

            routes.MapRoute(
               "The-Mother-Load-Project",
               "The-Mother-Load-Project",
               new { controller = "Home", action = "TheMotherLoadProject" }
               );

            routes.MapRoute(
               "Wannabe",
               "Wannabe",
               new { controller = "Home", action = "Wannabe" }
               );

            routes.MapRoute(
               "Petite-Show",
               "Petite-Show",
               new { controller = "Home", action = "PetiteShow" }
               );

            routes.MapRoute(
               "The-Merger",
               "The-Merger",
               new { controller = "Home", action = "TheMerger" }
               );

            routes.MapRoute(
               "Trestle-Designs",
               "Trestle-Designs",
               new { controller = "Home", action = "TrestleDesigns" }
               );

            routes.MapRoute(
               "about",
               "about",
               new { controller = "Home", action = "Index/#about" }
               );

            routes.MapRoute(
               "contact",
               "contact",
               new { controller = "Home", action = "Index/#contact" }
               );

            routes.MapRoute(
               "Default",
               "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}