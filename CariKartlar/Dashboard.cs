using Business.Abstract;
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
    public partial class Dashboard : Form
    {
        private decimal ? paidSum, unpaidSum;
        private static Dashboard ? instance;
        public static Dashboard Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Dashboard();
                }
                return instance;
            }
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        public void OpenDashboard(IDebtService debtService)
        {
            FillDataGridViews(debtService);
            ShowDialog();
        }
        private void FillDataGridViews(IDebtService debtService)
        {
            FillPaidGridDataView(debtService);
            FillUnPaidGridDataView(debtService);
            DrawBarPlot();
        }
        private void FillPaidGridDataView(IDebtService debtService)
        {
            dataGridViewPaidDebt.Rows.Clear();
            var paidDebts = debtService.GetPaidDebtDtos()?.Data;
            paidSum = paidDebts?.Sum(d => d.PaidDebt);
            labelPaid.Text = paidSum.ToString();
            foreach (var paidDebt in paidDebts)
            {
                dataGridViewPaidDebt.Rows.Add
                    (
                        paidDebt.DebtId,
                        paidDebt.CurrentCode,
                        paidDebt.CurrentName,
                        paidDebt.DebtAmount,
                        paidDebt.PaidDebt,
                        paidDebt.DebtDate
                    );
            }
        }
        private void FillUnPaidGridDataView(IDebtService debtService)
        {
            dataGridViewUnpaidDebt.Rows.Clear();
            var unpaidDebts = debtService.GetUnpaidDebtDtos()?.Data;
            unpaidSum = unpaidDebts.Sum(d => d.DebtAmount - d.PaidDebt);
            labelUnpaid.Text = unpaidSum.ToString();
            foreach (var unpaidDebt in unpaidDebts)
            {
                decimal reminder = unpaidDebt.DebtAmount - unpaidDebt.PaidDebt;
                dataGridViewUnpaidDebt.Rows.Add
                    (
                        unpaidDebt.DebtId,
                        unpaidDebt.CurrentCode,
                        unpaidDebt.CurrentName,
                        unpaidDebt.DebtAmount,
                        unpaidDebt.PaidDebt,
                        reminder,
                        unpaidDebt.DebtDate
                    );
            }
        }

        private void DrawBarPlot()
        {
            Color paidColor = Color.MediumSpringGreen;
            Color unpaidColor = Color.DarkMagenta;
            if(paidSum == 0 && unpaidSum == 0)
            {
                labelUnpaidPercent.Text = "0%";
                labelPaidPercent.Text = "0%";
                return;
            }
            else if(unpaidSum == 0)
            {
                panelPaid.BackColor = paidColor;
                labelPaidPercent.Text = "100%";
                labelUnpaidPercent.Text = "0%";
                return;
            }
            else if(paidSum == 0)
            {
                panelUnpaid.BackColor = unpaidColor;
                labelUnpaidPercent.Text = "100%";
                labelPaidPercent.Text = "0%";
                return;
            }
            int valueForPercent = 100 , round = 2;
            decimal ? paidPercent = paidSum / (paidSum + unpaidSum);
            decimal ? unpaidPercent = unpaidSum / (unpaidSum + paidSum);
            decimal ? paidPercentForText = paidPercent * valueForPercent;
            decimal ? unpaidPercentForText = unpaidPercent * valueForPercent;

            labelPaidPercent.Text = Math.Round((decimal)paidPercentForText, round).ToString() + "%";
            labelUnpaidPercent.Text = Math.Round((decimal)unpaidPercentForText, round).ToString() + "%";

            panelPaid.Top = (int)(panelPaid.Height * unpaidPercent);
            panelUnpaid.Top = (int)(panelPaid.Height * paidPercent);

            panelPaid.BackColor = paidColor;
            panelUnpaid.BackColor = unpaidColor;
        }

    }
}
