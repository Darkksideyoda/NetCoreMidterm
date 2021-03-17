using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreVize.Entities
{
    public class ProductDesign
    {

        public string productİmageway { get; set; }//Urune Ait Gorselin Dosya Yolu.
        public string productName { get; set; }//Urun Adı.
        
        public int productPrice { get; set; }//Urun Fiyati.
    
        public int productStock { get; set; }//Urun Stok Sayisi.

        public string productFeatures { get; set; }//Urun Ozellikleri.


    }
}
