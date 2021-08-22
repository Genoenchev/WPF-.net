using Models;
using Repositories.CityRepository;
using Repositories.CountryRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QbDemo
{
    public partial class HomeForm : Form
    {
        private readonly ICityRepository _cityRepository;
        private readonly ICountryRepository _countryRepository;
        public HomeForm()
        {
            _cityRepository = (ICityRepository)Program.ServiceProvider.GetService(typeof(ICityRepository));
            _countryRepository = (ICountryRepository)Program.ServiceProvider.GetService(typeof(ICountryRepository));
            InitializeComponent();
            OnStart();
            GetData();
        }
        private void OnStart()
        {
            CityGridView.ColumnCount = 4;
            CityGridView.Columns[0].Name = "Id";
            CityGridView.Columns[1].Name = "Name";
            CityGridView.Columns[2].Name = "Population";
            CityGridView.Columns[3].Name = "Country";

            var countryNames = _countryRepository.GetAllCountries
                           .Select(x => x.CountryName).ToArray();
            this.InputCountryId.Items.AddRange(countryNames);
        }
        private void FilterData()
        {
            List<>
        }
        private void GetData()
        {
            CityGridView.Rows.Clear();
            var citiesNames = _cityRepository.GetAllCities;
            foreach (City city in citiesNames)
            {
                string[] currentRow =
                {
                    city.Id.ToString(),
                    city.CityName,
                    city.Population.ToString(),
                    city.Country.CountryName,

                };
                CityGridView.Rows.Add(currentRow);
            }
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Country selectCountry = _countryRepository.GetAllCountries.SingleOrDefault(x => x.CountryName == InputCountryId.Text);
            City city = new City()
            {
                CityName = InputCityName.Text,
                Population = int.Parse(InputPopulation.Text),
                CountryId = selectCountry.Id,
            };
            _cityRepository.Add(city);
            ClearForm();
            GetData();
        }

        private void ClearForm()
        {
            InputId.Text = "";
            InputCityName.Text = "";
            InputPopulation.Text = "";
            InputCountryId.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void CityGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void CityGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
