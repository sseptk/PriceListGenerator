using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PriceListGenerator
{
    public class JsonFileReader
    {
        private string jsonString;

        public string GetJsonString()
        {
            using(StreamReader reader = new StreamReader("product.json"))
            {
                jsonString = reader.ReadToEnd();
            }

            return jsonString;
        }
    }
}
