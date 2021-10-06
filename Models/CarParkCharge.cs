using System;
namespace ooplesson4parking.Models
{
    public class CarParkCharge
    {
        public int MinimumFee { get; set; }
        public int MinimumHours { get; set; }

        public CarParkCharge(int _minimumFee = 2, int _minimumHours = 3)
        {
            MinimumFee = _minimumFee;
            MinimumHours = _minimumHours;
        }

        public override string ToString()
        {
            return "I am the CarParkCharge";
        }

        public int CalculateCharge(int hoursParked)
        {
            int calculatedFee = hoursParked < MinimumHours ? MinimumFee : hoursParked * MinimumFee;
            return calculatedFee;
        }
    }
}