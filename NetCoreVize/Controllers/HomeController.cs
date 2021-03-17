using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreVize.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NetCoreVize.Entities;


namespace NetCoreVize.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

          return View();
        }





        public IActionResult Anasayfa(){

            return View();
        }

        public IActionResult urunlerList(){

            return View();
        }

        public IActionResult userLogin(){

            return View();
        }

      

/*

//Urunlerin kendine ozel sayfalarinin tanimlanmasi.//////////////////////////////////////////

*/
        public IActionResult ekranKarti(){

            var Product = new List<ProductDesign>(){
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/a30u.png",productName="ROG STRIX A30U",productPrice=1999,productStock=3,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/AMD-R9-290X.png",productName="AMD R9 290X",productPrice=3900,productStock=7,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/asusRx560.png",productName="ASUS RX560",productPrice=2500,productStock=5,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/gtx1050.png",productName="NVDIA GEFORCE GTX1050",productPrice=1800,productStock=20,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/gtx1080.png",productName="NVDIA GEFORCE GTX1080",productPrice=2000,productStock=10,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/gtx260.png",productName="NVDIA GEFORCE GTX260",productPrice=3500,productStock=8,productFeatures="HDMI,VGA,DVI"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/gtx970.png",productName="NVDIA GEFORCE GTX970",productPrice=1000,productStock=2,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/quadroP4000.png",productName="QuadroP4000",productPrice=5999,productStock=2,productFeatures="HDMI"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/radeonFinepro.png",productName="AMD RADEON FinePro",productPrice=8999,productStock=13,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/radeonRxVega64.png",productName="Radeon RX VEGA-64",productPrice=6579,productStock=11,productFeatures="FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/radeonvii.png",productName="RADEON VII",productPrice=3899,productStock=9,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/rtx2080.png",productName="NVDIA GEFORCE RTX2080",productPrice=2250,productStock=12,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/RTX5000.png",productName="NVDIA GEFORCE RTX5000",productPrice=2590,productStock=1,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/rx570.png",productName="NVDIA GEFORCE RX570",productPrice=1050,productStock=16,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRA"},
                new ProductDesign(){productİmageway="/image/urunler/ekranKartlari/strix480.png",productName="GT3",productPrice=1765,productStock=15,productFeatures="HDMI,VGA,DVI,FreeSync Tech,RayCasting,4K ULTRAI"}


           
            };


           

            return View(Product);
        }




        public IActionResult bellekler(){
            return View();
        }



        public IActionResult depolama(){
            return View();
        }


        public IActionResult guc(){
            return View();
        }



        public IActionResult islemciler(){
            return View();
        }


        public IActionResult monitorler(){
            return View();
        }



////////////////////////////////////////////////////////////////////////////////

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
