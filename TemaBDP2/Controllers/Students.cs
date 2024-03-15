using Microsoft.AspNetCore.Mvc;

namespace TemaBD.Models
{
    public class Students : Controller
    {
        public string Index(string name, string? id)
        {
            string response = "Hello " + name + " ";
            if (id != null)
            {
                response = response + "id = " + id;
            }
            return response;
            //return View();
        }
        public string Coaie(string id)
        {
            string response = "Ai scris";
            if (id != null)
                response = response + " id = " + id;
            else
                response = response + " nimic";
            return response;
        }


    }
}