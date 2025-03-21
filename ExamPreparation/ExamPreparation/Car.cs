using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    internal class Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public double Speed {  get; set; }

        public virtual double Acceleration(double speed)
        {
            this.Speed = speed;
            return this.Speed * 3;
        }

        public virtual double Stop(double speed)
        {
            speed = 0;
            this.Speed = speed;
            return this.Speed;
        }
    }

    internal class Truck: Car
    {
        public override double Acceleration(double speed)
        {
            this.Speed = speed;
            return this.Speed * 2;
        }

        public override double Stop(double speed)
        {
            return base.Stop(speed);
        }
    }
}
