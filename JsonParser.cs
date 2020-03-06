using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceListGenerator
{
    public class JsonParser
    {
        Product product = new Product();
        
        JsonFileReader jsonFile = new JsonFileReader();
        
        public string jsonString;

        public List<Product> DeserializeJsonObejct()
        {
            jsonString = jsonFile.GetJsonString();

            var Products = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            return Products;
        }
    }
}
