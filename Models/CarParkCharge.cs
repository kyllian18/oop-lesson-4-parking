using System;
namespace ooplesson4parking.Models
{
    public class CarParkCharge
    {
        public decimal MinimumFee { get; set; }
        public int MinimumHours { get; set; }
        public decimal AdditionalFee { get; set; }
        public decimal MaximumFee { get; set; }

        public CarParkCharge(decimal _minimumFee = 2, int _minimumHours = 3, decimal _additionalFee = (decimal)0.5, decimal _maximumFee = 10)
        {
            MinimumFee = _minimumFee;
            MinimumHours = _minimumHours;
            AdditionalFee = _additionalFee;
            MaximumFee = _maximumFee;
        }

        public override string ToString()
        {
            return "I am the CarParkCharge";
        }

        public decimal CalculateCharge(int hoursParked)
        {
            decimal calculatedFee = hoursParked < MinimumHours ? MinimumFee : (MinimumFee + (hoursParked - MinimumHours) * AdditionalFee);
            return calculatedFee < MaximumFee ? calculatedFee : MaximumFee;
        }
    }
}