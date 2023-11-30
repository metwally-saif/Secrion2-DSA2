using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secrion2_DSA2_Saif.Classes
{
    internal class Link
    {
        public City City1 { get; }
        public City City2 { get; }
        public float Distance { get; }
        public float Speed { get; }
        private float _cost;

        // Constructor
        public Link(City originCity, City destinationCity, float distance, float maxSpeed)
        {
            City1 = originCity;
            City2 = destinationCity;
            Distance = distance;
            Speed = maxSpeed;
            CalculateCost();
        }

        // Getter for Cost
        public float Cost
        {
            get { return _cost; }
        }

        // Method to calculate cost based on distance and speed
        private void CalculateCost()
        {
            _cost = Distance / Speed;
        }
        public float CalculateTimeAtMaxSpeed()
        {
            return Distance / Speed;
        }
        public float GetDistance()
        {
            return Distance;
        }

    }
}
