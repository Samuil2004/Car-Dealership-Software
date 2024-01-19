namespace Car_Sales
{
    public partial class Catalogue : Form
    {
        Dealership dealership;
        Car selectedCar;
        //int selectedCarIndex;

        public Catalogue()
        {
            InitializeComponent();
            dealership = new Dealership();
            RefreshPage();
        }

        public void RefreshPage()
        {
            TrackBarPrice.Enabled = false;
            MaxPriceLabel.Visible = false;
            SelectedPriceLabel.Visible = false;
            SellCarButton.Enabled = false;
            tbBrand.ResetText();
            tbModel.ResetText();
            tbSelectedCarInfo.ResetText();
            lbAvailableCars.Items.Clear();
            foreach (Car car in dealership.GetAllAvailableCars())
            {
                lbAvailableCars.Items.Add(car.InfoForCatalogue);
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            lbAvailableCars.Items.Clear();
            foreach (Car car in dealership.FilteredCars(tbBrand.Text, tbModel.Text, TrackBarPrice.Value))
            {
                lbAvailableCars.Items.Add(car.InfoForCatalogue);
            }
        }

        private void SellCarButton_Click_1(object sender, EventArgs e)
        {
            SellACar sellACar = new SellACar(selectedCar, dealership, this);
            sellACar.ShowDialog();
        }

        private void lbAvailableCars_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbAvailableCars.SelectedItem != null)
            {
                selectedCar = dealership.GetCar(lbAvailableCars.SelectedItem.ToString());
                tbSelectedCarInfo.Text = selectedCar.DetailedInfoForTheCar;
                SellCarButton.Enabled = true;
            }
        }

        private void rbPriceRange_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbPriceRange.Checked)
            {
                TrackBarPrice.Enabled = true;
                MaxPriceLabel.Visible = true;
                SelectedPriceLabel.Visible = true;
                SelectedPriceLabel.Text = "€1000";
            }
        }

        //private void SelectedPriceLabel_Click(object sender, EventArgs e)
        //{

        //}

        private void TrackBarPrice_Scroll(object sender, EventArgs e)
        {
            SelectedPriceLabel.Text = $"€{TrackBarPrice.Value.ToString()}";
        }

        private void rbAllPrices_CheckedChanged(object sender, EventArgs e)
        {
            TrackBarPrice.Enabled = false;
            MaxPriceLabel.Visible = false;
            SelectedPriceLabel.Visible = false;
            SellCarButton.Enabled = false;
            TrackBarPrice.Value = 1000;
        }
    }
}
