using DigitalMenuView.Model;
using System.Collections.Generic;
using System.Web.Http;


namespace DigitalMenuView.Controller
{
    
    public class HomeController : ApiController
    {
        private readonly MenuService Service;

        public HomeController()
        {
            Service = new MenuService();
        }

        [HttpGet]
        public List<Menu> Get()
        {            
            return Service.Get();
            //return "Hello World";
        }

        [HttpPost]
        public List<Menu> Create()
        {
            return Service.Create();
        }

    }
}
