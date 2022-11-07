using NortWndToXML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessLayer.sqlmodels
{
    [Serializable]
    public class Depo
    {
        [XmlAttribute]
        public string  Isim { get; set; }
        public List<Urun> UrunlerListesiDepo{ get; set; }
    }
}
