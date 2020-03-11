using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceListGenerator
{
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();

            fillingTheGridWithData();
        }

        private void fillingTheGridWithData()
        {
            JsonParser jsonParser = new JsonParser();

            var Products = jsonParser.DeserializeJsonObejct();

            int numberRow = 0;
            foreach (var product in Products)
            {
                DataGrid_products.Rows.Add();
                DataGrid_products.Rows[numberRow].Cells["id"].Value = product.id;
                DataGrid_products.Rows[numberRow].Cells["title"].Value = product.title;
                DataGrid_products.Rows[numberRow].Cells["price"].Value = product.price;
                DataGrid_products.Rows[numberRow].Cells["currency"].Value = product.currency;
                DataGrid_products.Rows[numberRow].Cells["description"].Value = product.description;
                DataGrid_products.Rows[numberRow].Cells["rating"].Value = product.rating;
                ++numberRow;
            }
        }
    }
}
