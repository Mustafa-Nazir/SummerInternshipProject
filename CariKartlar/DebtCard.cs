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
    public partial class DebtCard : Form
    {
        private readonly IDebtService _debtService;
        private CurrentDto ? _currentDto;

        public DebtCard(IDebtService debtService)
        {
            _debtService = debtService;
            InitializeComponent();
        }

        public void OpenDebtCard(CurrentDto currentDto)
        {
            _currentDto = currentDto;
            FillDebtCard();
            ShowDialog();
        }
        private void FillDebtCard()
        {
            labelCurrentCode.Text = _currentDto?.CurrentCode; 
            labelCurrentName.Text = _currentDto?.CurrentName;
        }
        private void AddToDebtsTable()
        {
            decimal debtAmount = Convert.ToDecimal(textBoxDebtAmount.Text);
            int month = Convert.ToInt32(textBoxMonth.Text);
            int currentId = _currentDto.Id;
            decimal debtAmountPerMonth = debtAmount / month;
            DateTime date = dateTimeDate.Value.Date;

            for (int i = 0; i < month; i++)
            {
                date = i == 0 ? date : date.AddDays(30);
                Debt debt = new Debt 
                {
                    CurrentId = currentId,
                    DebtAmount = debtAmountPerMonth,
                    DebtDate = date,
                    PaidDebt = 0
                };
                _debtService.Add(debt);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckTheRexBoxes())
            {
                MessageBox.Show("Lütfen alanları boş bırakmayın.");
                return;
            }
            AddToDebtsTable();
            Close();
            MessageBox.Show("Kayıt işlemi başarı ile gerçekleşti.");
        }

        private bool CheckTheRexBoxes()
        {
            bool result = textBoxDebtAmount.Text == "" || textBoxMonth.Text == "";
            return !result;
        }
    }
}
