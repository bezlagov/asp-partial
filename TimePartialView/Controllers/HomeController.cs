using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TimePartialView.Models;

namespace TimePartialView.Controllers
{
    public class HomeController : Controller
    {

        private PageData[] pageDatas = new PageData[]{ 
        new PageData(){ Title="Submenu 1", Description ="Ipsum nunc aliquet bibendum enim facilisis gravida. Iaculis eu non diam phasellus. Diam donec adipiscing tristique risus nec feugiat. Mi sit amet mauris commodo. A iaculis at erat pellentesque adipiscing commodo elit at. Pretium lectus quam id leo in vitae turpis. Egestas fringilla phasellus faucibus scelerisque eleifend donec pretium. Suspendisse potenti nullam ac tortor vitae purus. Ac turpis egestas sed tempus. Massa tincidunt nunc pulvinar sapien et ligula ullamcorper. Pellentesque massa placerat duis ultricies lacus. Cum sociis natoque penatibus et magnis dis. Sagittis id consectetur purus ut faucibus pulvinar. Duis at tellus at urna condimentum. Eget nunc scelerisque viverra mauris in aliquam sem. Turpis in eu mi bibendum neque egestas congue quisque. Enim facilisis gravida neque convallis a cras. Nunc vel risus commodo viverra maecenas accumsan. In tellus integer feugiat scelerisque varius morbi enim nunc."},
        new PageData(){ Title="Submenu 2", Description ="Mauris vitae ultricies leo integer malesuada nunc vel risus commodo. Fermentum odio eu feugiat pretium nibh ipsum. Mauris in aliquam sem fringilla ut morbi tincidunt augue. Vitae tortor condimentum lacinia quis vel eros donec ac. Ut venenatis tellus in metus vulputate eu scelerisque felis imperdiet. In egestas erat imperdiet sed euismod nisi porta. Tempus iaculis urna id volutpat lacus. Ultricies integer quis auctor elit sed vulputate. Laoreet sit amet cursus sit amet dictum. Nulla facilisi cras fermentum odio."},
        new PageData(){ Title="Submenu 3", Description ="Ut tristique et egestas quis ipsum suspendisse. Vitae congue mauris rhoncus aenean vel elit scelerisque mauris. Nibh mauris cursus mattis molestie a. Suspendisse sed nisi lacus sed. Senectus et netus et malesuada fames ac turpis egestas integer. Adipiscing commodo elit at imperdiet dui accumsan sit amet. Fermentum leo vel orci porta non pulvinar neque laoreet suspendisse. Feugiat vivamus at augue eget arcu dictum varius duis. Etiam tempor orci eu lobortis. Elementum eu facilisis sed odio morbi quis commodo odio. Vitae et leo duis ut diam quam nulla."},
        };
        public IActionResult Index()
        {
            return View(DateTime.Now);
        }

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult PageOne()
        {
            return View();
        }

        public IActionResult PageTwo(int? Id = null)
        {
            if (Id != null)
            {
                ViewBag.Data = pageDatas[(int)Id];
            }
            return View();
        }
    }
}
