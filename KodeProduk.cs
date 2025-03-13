using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace modul4_103022300130
{
    public class KodeProduk

    {
        private static Dictionary<string, string> listProduk = new Dictionary<string, string>
        {
            {"Laptop","E100"},
            {"Smartphone","E101"},
            {"Tablet","E102"},
            {"Headset","E103"},
            {"Keyboard","E104"},
            {"Mouse","E105"},
            {"Printer","E106"},
            {"Monitor","E107"},
            {"Smartwatch","E108"},
            {"Kamera","E109"}
        };

        public static string getKodeProduk(string namaProduk)
        {
            if (listProduk.TryGetValue(namaProduk, out string kodeProduk))
            {
                return kodeProduk;
            } else
            {
                return "Tidak dapat menemukan kode produk yang dicari";
            }
        }
    }
}
