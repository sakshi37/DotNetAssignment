using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigninment_day2.assiginme
{
    class Car
    {
        private int CarId;
        private string Brand;
        private string Model;
        private int Year;
        private int Price;

        public int carid
        {
            get { return CarId; }
            set { CarId = value; }
        }


        public string brand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public string model
        {
            get { return Model; }
            set { Model = value; }
        }

        public int year
        {
            get { return Year; }
            set { year = value; }
        }

        public int price
        {
            get { return Price; }
            set { Price = value; }
        }

        public Car(int carid, string brand, string model, int year, int price, int v)
        {
            CarId = carid;
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;

        }

        public Car(int v1, string v2, string v3, int v4, int v5)
        {
        }

        public void Dispaly()
        {
            Console.WriteLine($"CarId: {CarId}\n Brand: {Brand}\n Model: {Model}\n year: {Year}\n price: {Price}");
        }

    }


}


