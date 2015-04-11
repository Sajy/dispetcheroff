using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uptest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
        //Label1.Text = "смс выслана на указанный номер";
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        //if (FileUpload1.HasFile)
        //{
        //    string path = string.Concat(Server.MapPath(FileUpload1.FileName));
        //    FileUpload1.SaveAs(path);

        //    Microsoft.Office.Interop.Excel.Application appExcel;
        //    Microsoft.Office.Interop.Excel.Workbook workbook;
        //    Microsoft.Office.Interop.Excel.Range range;
        //    Microsoft.Office.Interop.Excel._Worksheet worksheet;

        //    appExcel = new Microsoft.Office.Interop.Excel.Application();
        //    workbook = appExcel.Workbooks.Open(path, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
        //    worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets[1];
        //    range = worksheet.UsedRange;

        //    int rowCount = range.Rows.Count;
        //    int colCount = range.Columns.Count;


        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    dt.Columns.Add("npm");
        //    dt.Columns.Add("prodi");
        //    dt.Columns.Add("grade");
        //    dt.Columns.Add("grade2");
           
        //    for (int Rnum = 2; Rnum <= rowCount; Rnum++ )
        //    {


               

        //        DataRow dr = dt.NewRow();
        //        //Reading Each Column value From sheet to datatable Colunms                  
        //        for (int Cnum = 1; Cnum <= colCount; Cnum++)
        //        {
        //            Response.Write("1");
        //            Excel.Range newRng = (Excel.Range)range.Cells[Rnum, Cnum];

        //            dr[Cnum - 1] = newRng.Value2.ToString();
        //        }
        //        dt.Rows.Add(dr); // adding Row into DataTable
        //        dt.AcceptChanges();
        //    }

        //    workbook.Close(true);
        //    appExcel.Quit();

        //    try
        //    {



        //        string connSql = @"Data Source=208.116.7.82\castor; Database=dispetcheroff; User Id=win610476; Password=w~Sxe738;";

        //        SqlBulkCopy bulkcopy = new SqlBulkCopy(connSql);

        //        SqlBulkCopyColumnMapping mapNPM = new SqlBulkCopyColumnMapping("npm", "Dname");
        //        bulkcopy.ColumnMappings.Add(mapNPM);
        //        SqlBulkCopyColumnMapping mapProdi = new SqlBulkCopyColumnMapping("prodi", "Rname");
        //        bulkcopy.ColumnMappings.Add(mapProdi);
        //        SqlBulkCopyColumnMapping mapGrade = new SqlBulkCopyColumnMapping("grade", "Number1");
        //        bulkcopy.ColumnMappings.Add(mapGrade);

        //        bulkcopy.DestinationTableName = "Test";
        //        bulkcopy.WriteToServer(dt);

        //        msg.Text = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        msg.Text = ex.Message.ToString();
        //    }


        //}
    }
}