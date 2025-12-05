using System.Data;
using System.IO;
using OfficeOpenXml;

namespace DemoMVC104.Models.Process
{
    public class ExcelProcess
    {
    public DataTable ExcelToDataTable(string filePath)
{
    using var package = new ExcelPackage(new FileInfo(filePath));

    var ws = package.Workbook.Worksheets[0];
    var dt = new DataTable();

    foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
    {
        dt.Columns.Add(firstRowCell.Text);
    }

    for (int row = 2; row <= ws.Dimension.End.Row; row++)
    {
        var newRow = dt.NewRow();
        for (int col = 1; col <= ws.Dimension.End.Column; col++)
        {
            newRow[col - 1] = ws.Cells[row, col].Text;
        }
        dt.Rows.Add(newRow);
    }

    return dt;
}

    }
}
