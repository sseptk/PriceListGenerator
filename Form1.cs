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
            foreach (var v in Products)
            {
                DataGrid_products.Rows.Add();
                DataGrid_products.Rows[numberRow].Cells["id"].Value = v.id;
                DataGrid_products.Rows[numberRow].Cells["title"].Value = v.title;
                DataGrid_products.Rows[numberRow].Cells["price"].Value = v.price;
                DataGrid_products.Rows[numberRow].Cells["currency"].Value = v.currency;
                DataGrid_products.Rows[numberRow].Cells["description"].Value = v.description;
                DataGrid_products.Rows[numberRow].Cells["rating"].Value = v.rating;
                ++numberRow;
            }
        }
    }
}
