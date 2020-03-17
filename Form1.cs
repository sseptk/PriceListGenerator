using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;


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
                DataGrid_products.Rows[numberRow].Cells["category"].Value = product.category;
                DataGrid_products.Rows[numberRow].Cells["currency"].Value = product.currency;
                DataGrid_products.Rows[numberRow].Cells["description"].Value = product.description;
                DataGrid_products.Rows[numberRow].Cells["rating"].Value = product.rating;
                ++numberRow;
            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DataTableCreator dataTableCreator = GenerateTable();

            SaveTable(dataTableCreator);
        }

        private DataTableCreator GenerateTable()
        {
            DataTableCreator dataTableCreator = new DataTableCreator();

            if (checkBox_id.Checked)
            {
                dataTableCreator.CreateTableForSave("id", DataGrid_products, ColumnNames.id);
            }

            if (checkBox_title.Checked)
            {
                dataTableCreator.CreateTableForSave("title", DataGrid_products, ColumnNames.title);
            }
            if (checkBox_price.Checked)
            {
                dataTableCreator.CreateTableForSave("price", DataGrid_products, ColumnNames.price);
            }
            if (checkBox_currency.Checked)
            {
                dataTableCreator.CreateTableForSave("currency", DataGrid_products, ColumnNames.currency);
            }
            if (checkBox_category.Checked)
            {
                dataTableCreator.CreateTableForSave("category", DataGrid_products, ColumnNames.category);
            }
            if (checkBox_description.Checked)
            {
                dataTableCreator.CreateTableForSave("description", DataGrid_products, ColumnNames.description);
            }
            if (checkBox_rating.Checked)
            {
                dataTableCreator.CreateTableForSave("rating", DataGrid_products, ColumnNames.rating);
            }

            return dataTableCreator;
        }

        private void SaveTable(DataTableCreator dataTableCreator)
        {
            DataTableSave dataTableSave = new DataTableSave(dataTableCreator.getTable());

            if (comboBox_formats.SelectedItem.ToString() == "xml")
            {
                dataTableSave.SaveAsXml();
            }
            if (comboBox_formats.SelectedItem.ToString() == "xlsx")
            {
                dataTableSave.SaveAsXlsx();
            }
            if (comboBox_formats.SelectedItem.ToString() == "csv")
            {
                dataTableSave.SaveAsCsv();
            }
        }
    }
}
