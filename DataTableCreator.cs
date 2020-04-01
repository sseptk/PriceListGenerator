using ClosedXML.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceListGenerator
{
    class DataTableCreator
    {
        private DataTable table_Products = new DataTable("Products");
        private int columnNumber = 0;

        public void CreateTableForSave(string nameColumn, DataGridView dataGridView, ColumnNames column)
        {
            table_Products.Columns.Add(dataGridView.Columns[nameColumn].Name);

            int lineNumber = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (table_Products.Rows.Count != dataGridView.Rows.Count)
                    table_Products.Rows.Add(); 

                table_Products.Rows[lineNumber][columnNumber] = row.Cells[(int)column].Value;
                lineNumber++;
            }
            columnNumber++;
        }

        public DataTable getTable()
            => table_Products;
    }
}
