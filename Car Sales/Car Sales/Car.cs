using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Car_Sales
{
    public class Car
    {
        private string brand;
        private string model;
        private int year;
        private double price;
        private List<Accessories> accessories;
        private Customer buyer;
    

        public Car(string Brand, string Model, int Year, double Price)
        {
            this.brand = Brand;
            this.model = Model;
            this.year = Year;
            this.price = Price;
            this.accessories = new List<Accessories>();
        }

        public string InfoForCatalogue
        {
            get
            {
                return $"{brand} - {model} - {year}";
            }
        }

        public Customer Buyer
        {
            get { return buyer; }
            set { buyer = value; }
        }

        public string DetailedInfoForTheCar
        {
            get
            {
                return $"Brand: {brand}\r\nModel: {model}\r\nYear of production: {year}\r\nPrice: €{price}";
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public void AddAccessoryToTheCar(List<Accessories> a)
        {
            accessories.AddRange(a);
        }

        public List<Accessories> Accessories
        {
            get { return accessories; }
        }
        public string Info
        {
            get
            {
                return $"{Brand},{Model},{Year},{Price}";
            }
        }
    }
}
