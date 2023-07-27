using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CariKartlar.Utilities.Helpers.FileHelpers
{
    public class FileHelperExcel : BaseFileHelper
    {
        public FileHelperExcel():base("Excel","xlsx")
        {

        }
        protected override void DataGridViewToFile(DataGridView dataGridView, string fileName, string directoryPath, CurrentDto ? currentDto=null)
        {
            string file = GetFilePath(fileName, directoryPath); ;
            Microsoft.Office.Interop.Excel.Application excel = new();
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            object misValue = System.Reflection.Missing.Value;
            workbook = excel.Workbooks.Add(misValue);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = $"{fileName}";

            worksheet.Cells[1, 1] = "CurrentCode";
            worksheet.Cells[1, 2] = currentDto.CurrentCode;
            worksheet.Cells[1, 4] = "CurrentName";
            worksheet.Cells[1, 5] = currentDto.CurrentName;




            int startingCell = 3;
            for (int i = 1; i < dataGridView.Columns.Count+1; i++)
            {
                worksheet.Cells[startingCell,i] = dataGridView.Columns[i-1].HeaderText;
            }
            startingCell++;
            for (int i = 0; i < dataGridView.Rows.Count -1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i+startingCell,j+1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs2(file);
            excel.Quit();
        }

        protected override void UserInfoToFile(CurrentDto currentDto, string fileName, string directoryPath)
        {
            string file = GetFilePath(fileName, directoryPath); ;
            Microsoft.Office.Interop.Excel.Application excel = new();
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            object misValue = System.Reflection.Missing.Value;
            workbook = excel.Workbooks.Add(misValue);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = $"{fileName}";

            List<List<string>> userInfo = GetUserInfoList(currentDto);
            for (int i = 0; i < userInfo.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    worksheet.Cells[i + 1, j + 1] = userInfo[i][j];
                }
            }
            workbook.SaveAs2(file);
            excel.Quit();
        }
    }
}
