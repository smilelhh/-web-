using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Drawing;
using System.Web.UI.WebControls;



/// <summary>
///excel导出工具类
/// </summary>
public class ExcelUtil
{
    public ExcelUtil()
    {
    }

    public static Boolean WriteToExcel(GridView gridView)
    {
        try
        {
            if (gridView != null)
            {
                Application excel = new Application();
                Workbook book = excel.Workbooks.Add(true);
                Worksheet sheek = book.Worksheets[1] as Worksheet;
                sheek.Columns.ColumnWidth = 15;

                int rowIndex = 1;
                int colIndex = 1;


                for (int i = 0; i < gridView.HeaderRow.Cells.Count; i++)
                {
                    Range headRange = excel.Cells[1, colIndex] as Range;
                    headRange.Value = gridView.HeaderRow.Cells[i].Text.ToString();
                    headRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    headRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                    headRange.Interior.Color = Color.Red;
                    colIndex++;
                }

                foreach (GridViewRow row in gridView.Rows)
                {
                    rowIndex++;
                    colIndex = 1;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        Range contentRange = excel.Cells[rowIndex, colIndex] as Range;
                        contentRange.Value = row.Cells[i].Text.ToString();
                        contentRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        contentRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                        colIndex++;
                    }

                }

                
                excel.DisplayAlerts = false;
                excel.Save();
                excel.Quit();

                return true;
            }
            else
                return false;


        }
        catch (Exception)
        {
            return false;
        }

    }



    //public static Boolean WriteToExcel1(System.Data.DataTable table)
    //{

    //    try
    //    {
    //        if (table != null)
    //        {
    //            Application excel = new Application();
    //            Workbook book = excel.Workbooks.Add(true);
    //            Worksheet sheek = book.Worksheets[1] as Worksheet;
    //            sheek.Columns.ColumnWidth = 15;

    //            int rowIndex = 1;
    //            int colIndex = 1;

    //            foreach (DataColumn col in table.Columns)
    //            {
    //                Range headRange = excel.Cells[1, colIndex] as Range;
    //                headRange.Value = col.ColumnName;
    //                headRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
    //                headRange.Borders.LineStyle = XlLineStyle.xlContinuous;
    //                headRange.Interior.Color = Color.Red;
    //                colIndex++;
    //            }

    //            foreach (DataRow row in table.Rows)
    //            {
    //                rowIndex++;
    //                colIndex = 1;
    //                foreach (DataColumn col in table.Columns)
    //                {
    //                    Range contentRange = excel.Cells[rowIndex, colIndex] as Range;
    //                    contentRange.Value = row[col.ColumnName].ToString();
    //                    contentRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
    //                    contentRange.Borders.LineStyle = XlLineStyle.xlContinuous;
    //                    colIndex++;
    //                }

    //            }

    //            //book.SaveAs(@"D:\sheet.xls");        

    //            //book.Save();
    //            //book.Close();

    //            //excel.
    //            excel.DisplayAlerts = false;
    //            excel.Save();
    //            excel.Quit();
    //            //excel.Visible = true;

    //            //excel.ActiveWorkbook.SaveAs(strExcelFileName + ".XLS", XlFileFormat.xlExcel9795, null, null, false, false, XlSaveAsAccessMode.xlNoChange, null, null, null, null);

    //            //excel.ActiveWorkbook.SaveAs(@"D:\sheet.xls", XlFileFormat.xlExcel9795, null, null, false, false, XlSaveAsAccessMode.xlNoChange, null, null, null, null);

    //            return true;
    //        }
    //        else
    //            return false;


    //    }
    //    catch (Exception)
    //    {
    //        return false;
    //    }

    //}
}