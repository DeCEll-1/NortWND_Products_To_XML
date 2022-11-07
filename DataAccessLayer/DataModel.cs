using DataAccessLayer.sqlmodels;
using NortWndToXML;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel() { con = new SqlConnection(ConnectionString.ConStrLocal); cmd = con.CreateCommand(); }

        #region Urunler
        public string UrulerListesiToXMLString(Depo urunler)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Depo));
                TextWriter yazici = new StringWriter();
                xmlSerializer.Serialize(yazici, urunler);
                return yazici.ToString();
            }
            catch (Exception)
            {
                return null;
            }
            finally { con.Close(); }
        }

        #endregion
        /// <summary>
        /// 0 veya 1
        /// </summary>
        /// <param name="Durdurulmusmu"></param>
        /// <returns></returns>
        /// 
        public List<Urun> UrunlerListesi(int Durdurulmusmu)
        {
            try
            {
                List<Urun> urunler = new List<Urun>();

                cmd.CommandText = "EXEC usp_UrunListesi @Durdurulmusmu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Durdurulmusmu", Durdurulmusmu);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    urunler.Add(new Urun()
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        CategoryID = reader.GetInt32(2),
                        CategoryName = reader.GetString(3),
                        SupplierID = reader.GetInt32(4),
                        CompanyName = reader.GetString(5),
                        QuantityPerUnit = reader.GetString(6),
                        UnitPrice = reader.GetDecimal(7),
                        UnitsInStock = reader.GetInt16(8),
                        UnitsOnOrder = reader.GetInt16(9),
                        ReorderLevel = reader.GetInt16(10),
                        Discontinued = reader.GetBoolean(11),
                    });
                }
                return urunler;
            }
            catch (Exception)
            {
                return null;
            }
            finally { con.Close(); }
        }

    }
}
