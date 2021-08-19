using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate

    //miras alma->inheritance
    //tüzel müşteri bir müşteridir demek
    class TuzelMusteri:Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
