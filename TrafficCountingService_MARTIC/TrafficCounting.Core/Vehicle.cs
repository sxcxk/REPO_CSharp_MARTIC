using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public abstract class Vehicle
    {
        protected string brand;
        protected string type;
        protected string vehicleId;
        protected string captureTime;
        protected CountStation station;

        public string Brand { get => brand; set => brand = value; }
        public string Type { get => type; set => type = value; }
        public string VehicleId { get => vehicleId; set => vehicleId = value; }
        public string CaptureTime { get => captureTime; set => captureTime = value; }
        public CountStation Station { get => station; set => station = value; }

        public Vehicle(string vehicleID, string brand, string type, CountStation station)
        {
            VehicleId = vehicleID;
            Brand = brand;
            Type = type;
            CaptureTime = captureTime;
            Station = station;
            captureTime = DateTime.Now.ToString();
        }

        public Vehicle(string vehicleID, string type)
        {
            VehicleId = vehicleID;
            Type = type;
        }

        public override string ToString()
        {
            return CaptureTime + ";" + VehicleId + ";" + Station.ToString();
        }




    }
}
