using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
    public partial class CariAcilisKarti : Form
    {
        private readonly IDistrictService _districtService;
        private readonly ICountryService _countryService;
        private readonly ICityService _cityService;
        private readonly ICurrentCodeService _currentCodeService;
        private readonly ICurrentGroupCodeService _currentGroupCodeService;
        private readonly ICurrentService _currentService;
        private readonly IDebtService _debtService;

        private readonly int _debtCoulmnIndex;
        private decimal _paidDeptCellPreviousValue;

        private bool isClickedTheDataGrid;
        public CariAcilisKarti(
            IDistrictService districtService,
            ICountryService countryService,
            ICityService cityService,
            ICurrentCodeService currentCodeService,
            ICurrentGroupCodeService currentGroupCodeService,
            ICurrentService currentService,
            IDebtService debtService)
        {
            InitializeComponent();

            _debtCoulmnIndex = 6;

            _districtService = districtService;
            _countryService = countryService;
            _cityService = cityService;
            _currentCodeService = currentCodeService;
            _currentGroupCodeService = currentGroupCodeService;
            _currentService = currentService;
            _debtService = debtService;
            FillTheComboboxes();
            FillDataGridView();
        }

        # region FillTheCombobox
        private void FillTheComboboxes()
        {
            FillCountriesComboBox();
            FillCurrentCodes();
            FillCurrentGroupCode();
        }

        private void FillDistrictComboBox(List<District> ?districts = null)
        {
            comboBoxDistrict.Items.Clear();
            var result = districts ==null ? _districtService.GettAll().Data : districts;
            foreach (var district in result)
            {
                comboBoxDistrict.Items.Add(district.Name);
            }

            comboBoxDistrict.SelectedIndex = comboBoxCity.SelectedIndex > -1 ? 0:-1;
        }

        private void FillCitiesComboBox(List<City> ?cities=null)
        {
            comboBoxCity.Items.Clear();
            var result = cities==null ? _cityService.GettAll().Data : cities;
            foreach (var city in result)
            {
                comboBoxCity.Items.Add(city.Name);
            }
        }

        private void FillCountriesComboBox()
        {
            var result = _countryService.GettAll();
            foreach (var country in result.Data)
            {
                comboBoxCountry.Items.Add(country.Name);
            }
        }

        private void FillCurrentCodes()
        {
            comboBoxCode.Items.Clear();
            var result = _currentCodeService.GettAll()?.Data;
            foreach (var currentCode in result)
            {
                comboBoxCode.Items.Add(currentCode.Name);
            }
        }

        private void FillCurrentGroupCode()
        {
            comboBoxGroupCode.Items.Clear();
            var result = _currentGroupCodeService.GettAll()?.Data;
            foreach (var currentGroupCode in result)
            {
                comboBoxGroupCode.Items.Add(currentGroupCode.Name);
            }
        }
        #endregion

        #region comboBox_SelectedValueChanged
        private void comboBoxCity_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxCity.Text;
            int ?cityId = _cityService.GetIdByName(name)?.Data;
            if (cityId == null) return;
            var districtResult = _districtService.GetByCityId((int)cityId).Data;
            FillDistrictComboBox(districtResult);
        }
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBoxCountry.Text;
            int? countryId = _countryService.GetIdByName(name)?.Data;
            if (countryId == null) return;

            var cities = _cityService.GetByCountryId((int)countryId);
            FillCitiesComboBox(cities.Data);
            comboBoxDistrict.Items.Clear();
        }
        #endregion

        #region ButtonEvents
        private void buttonDebtPayment_Click(object sender, EventArgs e)
        {
            OpenDebtPaymentCard();
        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            int currentCodeId = GetCurrentCodeId().Data;
            Current ? current = _currentService.GetByCurrentCodeId(currentCodeId)?.Data;
            CurrentDto ? currentDto = _currentService.GetCurrentDto(current)?.Data;

            ReportCard.Instance.OpenReportCard(_debtService, currentDto);
        }
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.OpenDashboard(_debtService);
        }
        private void buttonOpenDebt_Click(object sender, EventArgs e)
        {
            OpenDebtCard();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!EmptyInputControlForSaveButton())
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
                return;
            }
            Current ? result = CreateNewCurrent();
            if (result == null) return;
            if (!CurrentControl(result)) return;
            _currentService.Add(result);
            AddCurrentDataGridView(result);
            FillCurrentGroupCode();
            FillCurrentCodes();
        }
        private bool CurrentControl(Current current)
        {
            var result = _currentService.GetByCurrentCodeId(current.CurrentCodeId).Data;
            if (result == null) return true;
            return false;
        }
        private bool EmptyInputControlForSaveButton()
        {
            bool prePanel = InputControl(PreInfoPanel);
            bool basePanel = InputControl(BaseInfoPanel);
            return (!prePanel || !basePanel) ? false : true;
        }
        private bool InputControl(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                if(item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox))
                {
                    string text = ((Control)item).Text;
                    if(text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CurrentDelete();
        }

        private void CurrentDelete()
        {
            if (!isClickedTheDataGrid) return;
            int? currentCodeId = _currentCodeService.GetIdByName(labelLockedCurrentCode.Text)?.Data?.Id;
            var current = _currentService.GetByCurrentCodeId((int)currentCodeId);
            if (!current.Success) return;
            string? currentCode = _currentCodeService.GetNameById((int)currentCodeId)?.Data?.Name;
            DeleteDataGridView(currentCode);
            _currentService.Delete(current.Data);
            ClearFields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CurrentUpdate();
        }

        private void CurrentUpdate()
        {
            Current? result = CreateNewCurrent();
            if (result == null) return;
            int? id = _currentService.GetByCurrentCodeId(result.CurrentCodeId)?.Data?.Id;
            if (id == null) return;
            result.Id = (int)id;
            _currentService.Update(result);
            UpdateDataGridView(result);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Current ? CreateNewCurrent()
        {
            var currentCode = GetCurrentCodeId();
            var currentGroupCode = GetCurrentGroupId();
            var country = GetIdByName(comboBoxCountry.Text, _countryService);
            var city = GetIdByName(comboBoxCity.Text,_cityService);
            var district = GetIdByName(comboBoxDistrict.Text, _districtService);
            string? currentName = GetText(textBoxName.Text);
            string? tax = GetText(textBoxTax.Text);
            string? taxNo = GetText(textBoxTaxNo.Text);
            string? currentGroupName = GetText(textBoxGroupName.Text);
            string? address = GetText(textBoxAddresses.Text);
            string? phone = GetText(textBoxPhone.Text);
            string? webAddress = GetText(textBoxWeb.Text);
            string? mail = GetText(textBoxMail.Text);
            string? authorized = GetText(textBoxAuthorized.Text);
            string? authorizedMail = GetText(textBoxAuthorizedMail.Text);

            if (!currentCode.Success
                || !currentGroupCode.Success
                || !country.Success
                || !city.Success
                || !district.Success
                || currentName == null
                || tax == null
                || taxNo == null
                || currentGroupName == null
                || address == null
                || phone == null
                || webAddress == null
                || mail == null
                || authorized == null
                || authorizedMail == null) return null;

            Current current = new Current
            {
                Address = address,
                Authorized = authorized,
                AuthorizedMail = authorizedMail,
                CityId = city.Data,
                CountryId = country.Data,
                CurrentCodeId = currentCode.Data,
                CurrentGroupCodeId = currentGroupCode.Data,
                CurrentGroupName = currentGroupName,
                CurrentName=currentName,
                DistrictId = district.Data,
                EMail=mail,
                Phone=phone,
                TaxAdministration = tax,
                TaxNo = taxNo,
                WebAddress = webAddress
            };

            return current; 

        }


        private string ? GetText(string text)
        {
            return text == "" ? null : text;
        }

        private IDataResult<int> GetCurrentCodeId()
        {
            string cbText = isClickedTheDataGrid ? labelLockedCurrentCode.Text : comboBoxCode.Text;
            if (cbText == "") return new ErrorDataResult<int>();
            int ?currentCodeId = GetCurrentCodeIdByName(cbText);
            if (currentCodeId == null)
            {
                _currentCodeService.Add(new CurrentCode { Name = cbText });
                currentCodeId = GetCurrentCodeIdByName(cbText);
                return new SuccessDataResult<int>((int)currentCodeId);
            }
            return new SuccessDataResult<int>((int)currentCodeId);

        }
        private int ? GetCurrentCodeIdByName(string name)
        {
            int? id = _currentCodeService.GetIdByName(name)?.Data?.Id;
            return id == null ? null : id;
        }

        private IDataResult<int> GetCurrentGroupId()
        {
            if (comboBoxGroupCode.Text == "") return new ErrorDataResult<int>();
            string cbText = comboBoxGroupCode.Text;
            int? currentGroupId = GetCurrentGroupCodeIdByName(cbText);
            if(currentGroupId == null)
            {
                _currentGroupCodeService.Add(new CurrentGroupCode { Name = cbText });
                currentGroupId = GetCurrentGroupCodeIdByName(cbText);
                return new SuccessDataResult<int>((int)currentGroupId);
            }
            return new SuccessDataResult<int>((int)currentGroupId);
        }

        private int ? GetCurrentGroupCodeIdByName(string name)
        {
            int ? id = _currentGroupCodeService.GetIdByName(name)?.Data?.Id;
            return id == null ? null : id;
        }

        private IDataResult<int> GetIdByName(string name,IGetIdByName service)
        {
            int? result = service.GetIdByName(name)?.Data;
            return result == null ? new ErrorDataResult<int>() : new SuccessDataResult<int>((int)result);
        }

        #endregion

        #region GridViewCurrent
        
        private void dataGridViewCurrent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            FillFieldsWithData(rowIndex);
            isClickedTheDataGrid = true;
            ChangeButtonVisible();
        }
        private void FillFieldsWithData(int rowIndex)
        {
            var row = dataGridViewCurrent.Rows[rowIndex];
            ChangeCurrentCodeTypeToLabel(row.Cells["CurrentCode"].Value.ToString());
            comboBoxGroupCode.Text = row.Cells["CurrentGroupCode"].Value.ToString();
            textBoxName.Text = row.Cells["CurrentName"].Value.ToString();
            textBoxTax.Text = row.Cells["Tax"].Value.ToString();
            textBoxTaxNo.Text = row.Cells["TaxNo"].Value.ToString();
            textBoxGroupName.Text = row.Cells["CurrentGroupName"].Value.ToString();
            comboBoxCountry.Text = row.Cells["Country"].Value.ToString();
            comboBoxCity.Text = row.Cells["City"].Value.ToString();
            comboBoxDistrict.Text = row.Cells["District"].Value.ToString();
            textBoxAddresses.Text = row.Cells["Address"].Value.ToString();
            textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
            textBoxWeb.Text = row.Cells["WebAddress"].Value.ToString();
            textBoxMail.Text = row.Cells["Mail"].Value.ToString();
            textBoxAuthorized.Text = row.Cells["Authorized"].Value.ToString();
            textBoxAuthorizedMail.Text = row.Cells["AuthorizedMail"].Value.ToString();
        }

        private void ChangeCurrentCodeTypeToLabel(string ?text)
        {
            comboBoxCode.Visible = false;
            labelLockedCurrentCode.Visible = true;
            labelLockedCurrentCode.Text = text;
        }
        private void ChangeCurrentCodeTypeToComboBox()
        {
            comboBoxCode.Visible = true;
            labelLockedCurrentCode.Visible = false;
        }
        private void ChangeButtonVisible()
        {
            buttonSave.Visible = isClickedTheDataGrid ? false : true;
            buttonDelete.Visible = isClickedTheDataGrid ? true : false;
            buttonUpdate.Visible = isClickedTheDataGrid ? true : false;
            buttonReport.Visible = isClickedTheDataGrid ? true : false;
            buttonOpenDebt.Visible = isClickedTheDataGrid ? true : false;
            buttonDebtPayment.Visible = isClickedTheDataGrid ? true : false;
        }
        private void FillDataGridView()
        {
            var currents = _currentService.GettAll().Data;
            foreach (var current in currents)
            {
                AddCurrentDataGridView(current);
            }
        }
        private void AddCurrentDataGridView(Current current)
        {
            var CurrentDto = _currentService.GetCurrentDto(current).Data;
            dataGridViewCurrent.Rows.Add
                (
                    CurrentDto.CurrentCode,
                    CurrentDto.CurrentGroupCode,
                    CurrentDto.CurrentName,
                    CurrentDto.TaxAdministration,
                    CurrentDto.TaxNo,
                    CurrentDto.CurrentGroupName,
                    CurrentDto.Country,
                    CurrentDto.City,
                    CurrentDto.District,
                    CurrentDto.Address,
                    CurrentDto.Phone,
                    CurrentDto.WebAddress,
                    CurrentDto.EMail,
                    CurrentDto.Authorized,
                    CurrentDto.AuthorizedMail
                );
        }

        private void DeleteDataGridView(string ? currentCode)
        {
            foreach (DataGridViewRow row in dataGridViewCurrent.Rows)
            {
                var value = row.Cells["CurrentCode"].Value.ToString();
                if (value == currentCode)
                {
                    dataGridViewCurrent.Rows.Remove(row);
                    return;
                }
            }
        }
        private void UpdateDataGridView(Current current)
        {
            string ? currentCode = _currentCodeService.GetNameById(current.CurrentCodeId)?.Data?.Name;
            DeleteDataGridView(currentCode);
            AddCurrentDataGridView(current);
        }
        #endregion
        #region label_Click
        private void labelClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            ClearCbAndTb(BaseInfoPanel);
            ClearCbAndTb(PreInfoPanel);
            ChangeCurrentCodeTypeToComboBox();
            isClickedTheDataGrid = false;
            ChangeButtonVisible();
        }

        private void ClearCbAndTb(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Text = "";
                }
                else if (item.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)item).Text = "";
                }
            }
        }
        #endregion

        #region DebtCard
        private void OpenDebtCard()
        {
            var currentCode = GetCurrentCodeId();
            if (!currentCode.Success) return;
            var current = _currentService.GetByCurrentCodeId(currentCode.Data).Data;
            CurrentDto currentDto = _currentService.GetCurrentDto(current).Data;
            DebtCard debtCard = new DebtCard(_debtService);
            debtCard.OpenDebtCard(currentDto);
        }
        #endregion

        #region DebtPayment
        private void OpenDebtPaymentCard()
        {
            var currentCode = GetCurrentCodeId();
            if (!currentCode.Success) return;
            var current = _currentService.GetByCurrentCodeId(currentCode.Data).Data;
            CurrentDto currentDto = _currentService.GetCurrentDto(current).Data;
            DebtPaymentCard debtCard = new DebtPaymentCard(_debtService);
            debtCard.OpenDebtCard(currentDto);
        }
        #endregion


    }
}
