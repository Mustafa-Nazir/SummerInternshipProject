using Business.Abstract;
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
    public partial class DebtPaymentCard : Form
    {
        private readonly IDebtService _debtService;
        private readonly int _debtCoulmnIndex;
        private decimal _paidDeptCellPreviousValue;
        private CurrentDto _currentDto;


        public DebtPaymentCard(IDebtService debtService)
        {
            InitializeComponent();
            _debtService = debtService;
            _debtCoulmnIndex = 6;
        }
        public void OpenDebtCard(CurrentDto currentDto)
        {
            _currentDto = currentDto;
            FillDataGridViewDebt();
            ShowDialog();
        }
        private void FillDataGridViewDebt()
        {
            List<DebtDto>? debtDtos = _debtService.GetUnpaidDebtDtos().Data?.Where(d => d.CurrentCode == _currentDto.CurrentCode).ToList();
            for (int i = 0; i < debtDtos.Count; i++)
            {
                DebtDto debtDto = debtDtos[i];
                AddDebtDataGridView(debtDto);
                Color color = debtDto.DebtAmount <= 0 ? Color.Green : Color.MediumVioletRed;
                SetColorForPaidDebtColumn(i, color);
                if (debtDto.DebtDate < DateTime.Now) SetColorForOverdue(i);
            }
            string sum = debtDtos.Sum(c => c.DebtAmount).ToString();
            string currentSum = debtDtos.Where(c => c.DebtDate < DateTime.Now).Sum(c => c.DebtAmount).ToString();
            labelSumDebt.Text = sum;
            labelCurrentCode.Text = _currentDto.CurrentCode;
            labelCurrentName.Text = _currentDto.CurrentName;
            labelCurrentSum.Text = currentSum;
        }
        private void AddDebtDataGridView(DebtDto debtDto)
        {
            decimal reminder = debtDto.DebtAmount - debtDto.PaidDebt;
            dataGridViewDebt.Rows.Add
                (
                    debtDto.DebtId,
                    debtDto.CurrentCode,
                    debtDto.CurrentName,
                    debtDto.Authorized,
                    debtDto.AuthorizedMail,
                    debtDto.DebtAmount,
                    debtDto.PaidDebt,
                    reminder,
                    debtDto.DebtDate
                );
        }
        private void SetColorForPaidDebtColumn(int rowIndex, Color color)
        {
            dataGridViewDebt.Rows[rowIndex].Cells["PaidDebt"].Style.BackColor = color;
        }
        private void SetColorForOverdue(int rowIndex)
        {
            var cells = dataGridViewDebt.Rows[rowIndex].Cells;
            Color backColor = Color.MediumVioletRed;
            foreach (DataGridViewCell cell in cells)
            {
                cell.Style.BackColor = backColor;
            }
        }

        private void dataGridViewDebt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex != _debtCoulmnIndex) return;
            if (!UpdateDebt(e)) return;
            ReloadDataGridView();
        }
        private bool UpdateDebt(DataGridViewCellEventArgs e)
        {
            int debtId = int.Parse(GetCellValue(e.RowIndex, 0, dataGridViewDebt));
            Debt? debt = _debtService.GetById(debtId).Data;

            decimal paidDebt = decimal.Parse(GetCellValue(e.RowIndex, _debtCoulmnIndex, dataGridViewDebt));
            if (paidDebt + _paidDeptCellPreviousValue > debt.DebtAmount) return false;
            _paidDeptCellPreviousValue += paidDebt;

            debt.PaidDebt = _paidDeptCellPreviousValue;
            _debtService.Update(debt);
            return true;
        }
        private string GetCellValue(int rowIndex, int columnIndex, DataGridView dataGridView)
        {
            string value = dataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString();
            return value;
        }
        private void dataGridViewDebt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            _paidDeptCellPreviousValue = decimal.Parse(GetCellValue(e.RowIndex, _debtCoulmnIndex, dataGridViewDebt));
        }
        private void ReloadDataGridView()
        {
            dataGridViewDebt.Rows.Clear();
            FillDataGridViewDebt();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
