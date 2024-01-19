using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;


namespace Car_Sales
{
    public class Dealership
    {
        List<Accessories> AllAccessoriesAvailable;
        bool toCatalogue = false;
        CSVManager csvManager = new CSVManager();
        Customer newCustomer;
        public Dealership()
        {
            AllAccessoriesAvailable = new List<Accessories>();
            foreach (Accessories accessory in Enum.GetValues(typeof(Accessories)))
            {
                AllAccessoriesAvailable.Add(accessory);
            }
        }
        public List<Car> GetAllAvailableCars()
        {
            return csvManager.GetAllAvailableCars();
        }

        public Car GetCar(string infoFromListBox)
        {
            Car car = GetAllAvailableCars().FirstOrDefault(car => car.InfoForCatalogue.Equals(infoFromListBox));
            return car;
        }

        public List<Car> FilteredCars(string Brand,string Model, int maxPrice)
        {
            List<Car> FilteredCars;

            if (string.IsNullOrEmpty(Model) && maxPrice == 1000)
            {
                FilteredCars = new List<Car>();
                foreach (Car car in GetAllAvailableCars())
                {
                    if (car.Brand.ToUpper().Contains(Brand.ToUpper()))
                    {
                        FilteredCars.Add(car);
                    }
                }
            }
            else if (string.IsNullOrEmpty(Brand) && maxPrice == 1000) 
            {
                FilteredCars = new List<Car>();
                foreach (Car car in GetAllAvailableCars())
                {
                    if (car.Model.ToUpper().Contains(Model.ToUpper()))
                    {
                        FilteredCars.Add(car);
                    }
                }
            }
            else if (string.IsNullOrEmpty(Brand) && string.IsNullOrEmpty(Model))
            {
                FilteredCars = new List<Car>();
                foreach (Car car in GetAllAvailableCars())
                {
                    if (car.Price <= maxPrice)
                    {
                        FilteredCars.Add(car);
                    }
                }
            }
            else if (maxPrice == 1000)
            {
                FilteredCars = new List<Car>();
                foreach (Car car in GetAllAvailableCars())
                {
                    if (car.Brand.ToUpper().Contains(Brand.ToUpper()) && car.Model.ToUpper().Contains(Model.ToUpper()))
                    {
                        FilteredCars.Add(car);
                    }
                }
            }
            else
            {
                FilteredCars = new List<Car>();
                foreach(Car car in GetAllAvailableCars())
                {
                    if(car.Brand.ToUpper().Contains(Brand.ToUpper()) && car.Model.ToUpper().Contains(Model.ToUpper()) && car.Price <= maxPrice)
                    {
                        FilteredCars.Add(car);
                    }
                }
            }
            return FilteredCars;
        }

        public List<Accessories> GetAvailableAccessoriesForTheCar(Car selectedCar) 
        { 
            List<Accessories> StillAvalablePerCar = new List<Accessories>();
            StillAvalablePerCar.Clear();
            foreach(Accessories accessory in AllAccessoriesAvailable)
            {
                if(!selectedCar.Accessories.Contains(accessory))
                {
                    StillAvalablePerCar.Add(accessory);
                }
            }
            return StillAvalablePerCar;
        }

        public void RemoveAccessory(Car selectedCar, string accessory)
        {
            Accessories accessory1 = (Accessories)Enum.Parse(typeof(Accessories), accessory);
            selectedCar.Accessories.Remove(accessory1);
        }

        public bool BackToCatalogue()
        {
            return toCatalogue;
        }
        public void ResetToCatalogue()
        {
            toCatalogue = false;
        }

        public string CustomerToSell(string FirstName, string LastName, string PhoneNumber, string Adress, string ZipCode, string City, Car selectedCar)
        {
            if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(PhoneNumber) && !string.IsNullOrEmpty(Adress) && !string.IsNullOrEmpty(ZipCode) && !string.IsNullOrEmpty(City) && selectedCar != null)
            {
                newCustomer = new Customer(FirstName, LastName, PhoneNumber, Adress, ZipCode, City);
                toCatalogue = true;
                selectedCar.Buyer = newCustomer;
                return "Congratulations!Car has been sold";
            }
            else
            {
                return "Please fill in all the data";
            }
        }
    }
}
