using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace adatkotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();

        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
            Form2 fce = new Form2();
            fce.Country = countryDataBindingSource.Current as CountryData;
            fce.ShowDialog();
        }

    }
}