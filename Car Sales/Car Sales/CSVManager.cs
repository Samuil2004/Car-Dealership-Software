using Car_Sales;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Car_Sales
{
    public class CSVManager
    {
        string fileName = "MOCK_CAR_DATA2.csv";
        string salesFile = "Sales.txt";
        List<Car> availableCars;
        Car newCar;
        //SQLManager SQLManager; - SQL database is also connected, but if you want me to give you access message me at s.kozarov23@acsbg.org
        public CSVManager()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //SQLManager = new SQLManager();
        }
        public List<Car> GetAllAvailableCars()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    string line;
                    availableCars = new List<Car>();
                    streamReader.ReadLine(); // I added this to skip the first line when reading the csv file as it is initializing the names of the columns and it throws an error as strings (column names) can not be converted to other variables (int year, for example)
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] SplitTheDataByLines = line.Split(",");
                        string brand = SplitTheDataByLines[0];
                        string model = SplitTheDataByLines[1];
                        int year = int.Parse(SplitTheDataByLines[2]);
                        double price = Convert.ToDouble(SplitTheDataByLines[3]);
                        newCar = new Car(brand, model, year, price);
                        availableCars.Add(newCar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return availableCars;
        }

        public void DeleteLine(Car selectedCar)
        {
            try
            {
                List<string> newLines = new List<string>();
                string topLine = "brand,model,year,price";
                newLines.Add(topLine);
                foreach (Car car in GetAllAvailableCars())
                {
                    if (!car.Info.Equals(selectedCar.Info))
                    {
                        newLines.Add(car.Info);
                    }
                }
                File.WriteAllText(fileName, string.Empty);
                File.WriteAllLines(fileName, newLines);
                availableCars.Clear();
                Sales(selectedCar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Sales(Car selectedCar)
        {
            try
            {
                using (StreamWriter streamWriter = File.AppendText(salesFile))
                {
                    streamWriter.WriteLine($"# {DateTime.Today.ToString("dd MMMM yyyy")} | {selectedCar.Brand} {selectedCar.Model} ({selectedCar.Year})\n"+
                        $"- *Price*: {selectedCar.Price}\n- *Customer*: {selectedCar.Buyer.FirstName} {selectedCar.Buyer.LastName}\n"+
                        $"- *Phone no.*: {selectedCar.Buyer.PhoneNumber}\n- *Adress no.*: {selectedCar.Buyer.Adress}\n"+
                        $"- *Zip code & city no.*: {selectedCar.Buyer.ZipCode} {selectedCar.Buyer.City}");
                    if(selectedCar.Accessories.Count > 0)
                    {
                        streamWriter.WriteLine($"- *Accessories*: {string.Join(", ", selectedCar.Accessories)}");
                    } 
                    streamWriter.WriteLine("---");
                    ///SQLManager.InsertNewSaleFromVSToSql(DateTime.Today, selectedCar.Brand, selectedCar.Model,selectedCar.Year,selectedCar.Price, string.Join(", ", selectedCar.Accessories),selectedCar.Buyer.FirstName,selectedCar.Buyer.LastName,selectedCar.Buyer.PhoneNumber,selectedCar.Buyer.Adress,selectedCar.Buyer.ZipCode,selectedCar.Buyer.City);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
