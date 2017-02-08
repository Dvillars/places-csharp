using Nancy;
using System.Collections.Generic;
using Places.Objects;

namespace Places
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };

            Post["/places"] = _ =>
            {
                Place newPlace = new Place(Request.Form["location"], Request.Form["description"]);
                return View["places.cshtml", Place.GetAll()];
            };

            Post["/search"] = _ =>
            {
                string searchItem = Request.Form["search"];
                var Result = Place.GetAll().Find(item => item.GetName() == searchItem);
                return View["search.cshtml", Result];
            };
        }
    }
}