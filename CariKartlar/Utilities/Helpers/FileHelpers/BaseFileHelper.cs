using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariKartlar.Utilities.Helpers.FileHelpers
{
    public abstract class BaseFileHelper
    {
        protected string _root = Directory.GetCurrentDirectory() + @"/../../../../Reports";
        protected readonly string _extention;
        public BaseFileHelper(string fileType , string extention)
        {
            _root += $"/{fileType}";
            _extention = extention;
        }
        public void CreateFile(CurrentDto currentDto, DataGridView? dataGridViewPaid = null, DataGridView? dataGridViewUnpaid = null)
        {
            string directory = $"{_root}/{currentDto.CurrentCode}";
            if (!FileExist(directory)) CreateDirectory(directory);
            DataGridViewToFile(dataGridViewPaid, "paidDebt", directory,currentDto);
            DataGridViewToFile(dataGridViewUnpaid, "unpaidDebt", directory,currentDto);
            UserInfoToFile(currentDto, "userInfo", directory);
        }
        protected abstract void DataGridViewToFile(DataGridView dataGridView, string fileName, string directoryPath, CurrentDto ? currentDto = null);
        protected abstract void UserInfoToFile(CurrentDto currentDto, string fileName, string directoryPath);
        protected bool FileExist(string path)
        {
            bool exists = System.IO.Directory.Exists(path);
            return exists;
        }
        protected void CreateDirectory(string path)
        {
            System.IO.Directory.CreateDirectory(path);
        }
        protected List<List<string>> GetUserInfoList(CurrentDto currentDto)
        {
            List<List<string>> userInfo = new()
            {
                new()
                {
                    "Cari Kodu",
                    currentDto.CurrentCode
                },
                new()
                {
                    "Cari Adı",
                    currentDto.CurrentName
                },
                new()
                {
                    "Cari Grup Kodu",
                    currentDto.CurrentGroupCode
                },
                new()
                {
                    "Cari Grup Adı",
                    currentDto.CurrentGroupName
                },
                new()
                {
                    "Ülke",
                    currentDto.Country
                },
                new()
                {
                    "Şehir",
                    currentDto.City
                },
                new()
                {
                    "İlçe",
                    currentDto.District
                },
                new()
                {
                    "Adres",
                    currentDto.Address
                },
                new()
                {
                    "Telefon",
                    currentDto.Phone
                },
                new()
                {
                    "Vergi Dairesi",
                    currentDto.TaxAdministration
                },
                new()
                {
                    "Vergi No",
                    currentDto.TaxNo
                },
                new()
                {
                    "Web Adresi",
                    currentDto.WebAddress
                },
                new()
                {
                    "Mail Info",
                    currentDto.EMail
                },
                new()
                {
                    "Yetkili",
                    currentDto.Authorized
                },
                new()
                {
                    "Yetkili Mail",
                    currentDto.AuthorizedMail
                },
            };
            return userInfo;

        }
        protected string GetFilePath(string fileName, string directoryPath)
        {
            string file = $"{directoryPath}/{fileName}.{_extention}";
            return file;
        }
    }
}
