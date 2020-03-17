using ClosedXML.Excel;
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
        DataTable table_Products = new DataTable("Products");

        public void CreateTableForSave(string nameColumn, DataGridView dataGridView, ColumnNames column)
        {
            table_Products.Columns.Add(dataGridView.Columns[nameColumn].Name);

            int rowCount = 0;
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                if(table_Products.Rows.Count != dataGridView.Rows.Count)
                    table_Products.Rows.Add();
                
                table_Products.Rows[rowCount][(int)column]= row.Cells[(int)column].Value;
                rowCount++;
            }
        }
    }
}
