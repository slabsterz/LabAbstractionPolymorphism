using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : Seat, IElectricCar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int Battery { get; set; }

        public Tesla(string model, string color, int battery) : base(model, color)
        {            
            this.Battery = battery;            
        }

       

        public override string ToString()
        {
            return $"{base.Color} Tesla {base.Model} with {this.Battery} Batteries{Environment.NewLine}" +
                $"{this.Start()}{Environment.NewLine}" +
                $"{this.Stop()}"; ;
        }
    }
}
