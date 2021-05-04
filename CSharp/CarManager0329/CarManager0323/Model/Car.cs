using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Car
    {
        string model;
        int money;
        string color;
        string year;

        public Car( string year, int money, string model, string color)
        {
            this.year = year;
            this.money = money;
            this.model = model;
            this.color = color;
            
        }

        public string Model { get => model; set => model = value; }
        public int Money { get => money; set => money = value; }
        public string Color { get => color; set => color = value; }
        public string Year { get => year; set => year = value; }
    }
}
