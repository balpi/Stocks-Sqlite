
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel;

namespace UmutDepo.Repos
{
   public class Rapors
    {
        public string DataToExcel(System.Data.DataTable data,string name)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Application();

                if (xlApp == null)
                {

                    return "Excel yüklü değil";
                }


                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

               

                int rowcount = 1;

                foreach (DataRow datarow in data.Rows)
                {
                    rowcount += 1;
                    for (int i = 2; i <= data.Columns.Count; i++)
                    {
                        // on the first iteration we add the column headers
                        if (rowcount == 2)
                        {
                            xlWorkSheet.Cells[1, i] = data.Columns[i - 1].ColumnName;
                        }
                        // Filling the excel file 
                        xlWorkSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                    }
                }
                var baslik = xlWorkSheet.Range[xlWorkSheet.Cells[2, 1], xlWorkSheet.Cells[1, data.Columns.Count]];
                baslik.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
                var excelCellrange = xlWorkSheet.Range[xlWorkSheet.Cells[2, 1], xlWorkSheet.Cells[data.Rows.Count+1, data.Columns.Count]];
                excelCellrange.Font.Size = 12;
                excelCellrange.EntireColumn.AutoFit();

                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;
               


                Random rnd = new Random();
                string fileName = name + rnd.Next(1000000).ToString()+".xls";
                string fullPath = Path.Combine(System.Windows.Forms.Application.StartupPath, fileName);

                xlWorkBook.SaveAs(fullPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlApp.Visible = true;
                

                return "Kayıt Basarılı";
            }
           catch {
                return "not";
            }
        }
        public string teslimAlmaRaporu(int id, string UrunAdi, string OlcuBirimi, string tarih, double adet, string teslimAlan)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Application();

                if (xlApp == null)
                {

                    return "Excel yüklü değil";
                }


                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Range[xlWorkSheet.Cells[1, 2], xlWorkSheet.Cells[1, 3]].Merge(true);
                
                xlWorkSheet.Cells[1, 2] = "ALINDI BELGESİ";
                xlWorkSheet.Cells[1, 2].Font.Size = 16;
                xlWorkSheet.Cells[1,2].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                xlWorkSheet.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[1, 2].Font.Bold = true;
                xlWorkSheet.Cells[2, 2] = "Ürün Adı";
                xlWorkSheet.Cells[3, 2] = "Ölçü Birimi";
                xlWorkSheet.Cells[4, 2] = "Miktarı";

                xlWorkSheet.Cells[8, 2] = "Teslim Eden Ad-Soyad-İmza";
                xlWorkSheet.Cells[9, 2] = "Umut ÖZEKİNCİ";
                xlWorkSheet.Cells[8, 3] = "Teslim Alan Ad-Soyad-İmza";



                xlWorkSheet.Cells[2, 3] = UrunAdi;
                xlWorkSheet.Cells[3, 3] = OlcuBirimi;
                xlWorkSheet.Cells[4, 3] = adet;
                xlWorkSheet.Cells[9, 3] = teslimAlan;
                xlWorkSheet.Cells[7, 3] = tarih;
                var baslik = xlWorkSheet.Range[xlWorkSheet.Cells[1, 2], xlWorkSheet.Cells[4,3]];
                baslik.Font.Size = 14;
               // baslik.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
                baslik.EntireColumn.AutoFit();

                Microsoft.Office.Interop.Excel.Borders border = baslik.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                Random rnd = new Random();
                string fileName = teslimAlan + rnd.Next(1000000).ToString() + ".xls";
                string fullPath = Path.Combine(System.Windows.Forms.Application.StartupPath, fileName);

                xlWorkBook.SaveAs(fullPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlApp.Visible = true;


                return "Kayıt Basarılı";

            }
            catch
            {
                
            }
            return "x";
        }
    }
}
