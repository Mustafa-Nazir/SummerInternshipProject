using CariKartlar.Utilities.Helpers.FileHelpers;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Utilities.Helpers.FileHelpers
{
    public class FileHelperCSV:BaseFileHelper
    {
        public FileHelperCSV():base("CSV","csv")
        {

        }
        protected override void DataGridViewToFile(DataGridView dataGridView , string fileName , string directoryPath,CurrentDto ? currentDto = null)
        {
            string file = GetFilePath(fileName, directoryPath);
            using (var stream = File.CreateText(file))
            {
                string constSign = ";";
                int lengthColumns = dataGridView.Columns.Count;
                int lengthRows = dataGridView.Rows.Count;
                for (int iR = 0; iR < lengthRows; iR++)
                {
                    string rowStringHeader = "";
                    string rowStringRow = "";
                    for (int iC = 0; iC < lengthColumns; iC++)
                    {
                        if (iR == 0)
                        {
                            var hT = dataGridView.Columns[iC].HeaderText;
                            hT = lengthColumns == iC ? hT : hT + constSign;
                            rowStringHeader += hT;
                        }
                        var rT = dataGridView.Rows[iR].Cells[iC].Value;
                        rT = lengthColumns == iC ? rT : rT + constSign;
                        rowStringRow += rT;
                    }
                    if (iR == 0) stream.WriteLine(rowStringHeader);
                    stream.WriteLine(rowStringRow);
                }
            }

        }
        protected override void UserInfoToFile(CurrentDto currentDto, string fileName, string directoryPath)
        {
            List<List<string>> userInfo = GetUserInfoList(currentDto);
            string file = GetFilePath(fileName,directoryPath);
            using (var stream = File.CreateText(file))
            {
                string constSign = ";";
                for (int i = 0; i < userInfo.Count; i++)
                {
                    string rowString = "";
                    for (int j = 0; j < 2; j++)
                    {
                        string rT = userInfo[i][j];
                        rT = j == 1 ? rT : rT + constSign;
                        rowString += rT;
                    }
                    stream.WriteLine(rowString);
                }
            }
        }
    }
}
