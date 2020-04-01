using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceListGenerator
{
    public class DataTableSave
    {
        DataTable table_Products = new DataTable();

        public DataTableSave(DataTable dataTable)
        {
            table_Products = dataTable;
        }

        public void SaveAsXml()
        {
            table_Products.WriteXml("Products.xml");
        }

        public void SaveAsXlsx()
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                workbook.AddWorksheet(table_Products);
                workbook.SaveAs("Products.xlsx");
            }
        }

        public void SaveAsCsv()
        {
            StringBuilder csvTable = new StringBuilder();

            IEnumerable<string> columnNames = table_Products.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            csvTable.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in table_Products.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                csvTable.AppendLine(string.Join(",", fields));
            }

            using(StreamWriter sw = new StreamWriter("Products.csv"))
            {
                sw.WriteLine(csvTable.ToString());
            }   
        }
    }
}
