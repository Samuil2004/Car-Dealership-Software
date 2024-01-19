using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Sales
{
    public partial class SellACar : Form
    {
        Catalogue catalogue;
        Car selectedCar;
        Dealership dealership;
        CSVManager csvManager;
        public SellACar(Car selectedCar, Dealership dealership, Catalogue catalogue)
        {
            InitializeComponent();
            this.selectedCar = selectedCar;
            this.dealership = dealership;
            this.catalogue = catalogue;
            tbSelectedCarForSale.Text = selectedCar.DetailedInfoForTheCar;
            UpdateData();
            RemoveAccessoryButton.Enabled = false;
            Timer.Start();
            RemoveAccessoryButton.Enabled = false;
            csvManager = new CSVManager();
        }

        private void AddAccessoriesButton_Click(object sender, EventArgs e)
        {
            selectedCar.AddAccessoryToTheCar(clbSelectedAccessories.CheckedItems.OfType<Accessories>().ToList());
            UpdateData();
        }

        public void UpdateData()
        {
            clbSelectedAccessories.Items.Clear();
            lbAddedAccessories.Items.Clear();
            foreach (Accessories accessory in dealership.GetAvailableAccessoriesForTheCar(selectedCar))
            {
                clbSelectedAccessories.Items.Add(accessory);
            }
            foreach (Accessories accessory in selectedCar.Accessories)
            {
                lbAddedAccessories.Items.Add(accessory);
            }
            if (lbAddedAccessories.Items.Count == 0)
            {
                RemoveAccessoryButton.Enabled = false;
            }
        }

        private void RemoveAccessoryButton_Click(object sender, EventArgs e)
        {
            dealership.RemoveAccessory(selectedCar, lbAddedAccessories.SelectedItem.ToString());
            UpdateData();
            RemoveAccessoryButton.Enabled = false;
        }

        private void BackToCatalogueButton_Click(object sender, EventArgs e)
        {
            this.Close();
            catalogue.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Text = DateTime.Now.ToString();
        }

        //private void tbFirstName_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void SellCarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dealership.CustomerToSell(tbFirstName.Text, tbLastName.Text, tbPhoneNumber.Text, tbAdress.Text, tbZipCode.Text, tbCity.Text, selectedCar));
            if (dealership.BackToCatalogue())
            {
                csvManager.DeleteLine(selectedCar);
                this.Close();
                catalogue.RefreshPage();
                catalogue.Show();
                dealership.ResetToCatalogue();
            }
        }

        private void lbAddedAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAddedAccessories.SelectedItem != null)
            {
                RemoveAccessoryButton.Enabled = true;
            }
        }
    }
}
