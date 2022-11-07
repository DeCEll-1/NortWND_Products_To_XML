using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NortWndToXML
{
    [Serializable]
    public class Urun
    {
        [XmlElement(ElementName = "Urun_No")]
        [XmlIgnore]
        public int ProductID { get; set; }

        [XmlElement(ElementName = "Urun_Adi")]
        public string ProductName { get; set; }
        [XmlIgnore]

        [XmlElement(ElementName = "Kategori_No")]
        public int CategoryID { get; set; }


        [XmlElement(ElementName = "Kategori_Adi")]
        public string CategoryName { get; set; }

        [XmlElement(ElementName = "Firma_No")]
        [XmlIgnore]
        public int SupplierID { get; set; }

        [XmlElement(ElementName = "Firma_Adi")]
        public string CompanyName { get; set; }

        [XmlElement(ElementName = "Birim_Basina_Miktar")]
        public string QuantityPerUnit { get; set; }

        [XmlElement(ElementName = "Birim_No")]
        public decimal UnitPrice { get; set; }

        [XmlElement(ElementName = "Stoktaki_Birim_Sayisi")]
        public short UnitsInStock { get; set; }

        [XmlElement(ElementName = "Siparis_Sayisi_Birim")]
        public short UnitsOnOrder { get; set; }

        [XmlElement(ElementName = "Kaca_Dustugunde_Alinsin")]
        public short ReorderLevel { get; set; }

        [XmlElement(ElementName = "Satisi_Durdurulmusmu")]
        public bool Discontinued { get; set; }
    }
}
