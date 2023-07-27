using Business.Abstract;
using CariKartlar.Utilities.Helpers.FileHelpers;
using Core.Utilities.Helpers.FileHelpers;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariKartlar
{
    public partial class ReportCard : Form
    {
        private CurrentDto _currentDto;
        private static ReportCard ? _instance;
        public static ReportCard Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ReportCard();
                }
                return _instance;
            }
        }
        public ReportCard()
        {
            InitializeComponent();
        }

        public void OpenReportCard(IDebtService debtService , CurrentDto currentDto)
        {
            _currentDto = currentDto;
            FillLabels(currentDto);
            FillGridView(debtService, currentDto);
            ShowDialog();
        }
        private void FillLabels(CurrentDto currentDto)
        {
            labelCurrentCode.Text = currentDto.CurrentCode;
            labelCurrentName.Text = currentDto.CurrentName;
        }
        private void FillGridView(IDebtService debtService , CurrentDto currentDto)
        {
            dataGridViewPaid.Rows.Clear();
            dataGridViewUnpaid.Rows.Clear();
            FillPaidGridView(debtService, currentDto);
            FillUnpaidView(debtService , currentDto);
        }
        private void FillPaidGridView(IDebtService debtService , CurrentDto currentDto)
        {
            var result = debtService.GetPaidDebtDtos().Data.Where(d => d.CurrentCode == currentDto.CurrentCode).ToList();
            foreach (var item in result)
            {
                var reminder = item.DebtAmount - item.PaidDebt;
                dataGridViewPaid.Rows.Add
                    (
                        item.DebtAmount,
                        item.PaidDebt,
                        reminder,
                        item.DebtDate
                    );
            }
        }
        private void FillUnpaidView(IDebtService debtService, CurrentDto currentDto)
        {
            var result = debtService.GetUnpaidDebtDtos().Data.Where(d => d.CurrentCode == currentDto.CurrentCode).ToList();
            foreach (var item in result)
            {
                var reminder = item.DebtAmount - item.PaidDebt;
                dataGridViewUnpaid.Rows.Add
                    (
                        item.DebtAmount,
                        item.PaidDebt,
                        reminder,
                        item.DebtDate
                    );
            }
        }
        private void buttonCreateCSVReport_Click(object sender, EventArgs e)
        {
            CreateReport(new FileHelperCSV());
        }
        private void buttonCreateExcelReport_Click(object sender, EventArgs e)
        {
            CreateReport(new FileHelperExcel());
        }
        private void CreateReport(BaseFileHelper fileHelper)
        {
            fileHelper.CreateFile(_currentDto, dataGridViewPaid, dataGridViewUnpaid);
            MessageBox.Show("Raporlama işlemi tamamlandı.");
        }
    }
}
