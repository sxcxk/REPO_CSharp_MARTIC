using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public class VehicleManager
    {
        private List<Vehicle> _vehicles;
        private static VehicleManager _instance;

        public static VehicleManager Instance 
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new VehicleManager();
                }
            return _instance;
            }
        }

        public VehicleManager()
        {
            _vehicles = new List<Vehicle>();
        }

        public void Add(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                _vehicles.Add((Car)vehicle);
            }

            if (vehicle is Truck)
            {
                _vehicles.Add((Truck)vehicle);
            }

            if (vehicle is OneLaneCar)
            {
                _vehicles.Add((OneLaneCar)vehicle);

            }
        }

        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }


        public int GetStationCount(string station)
        {
            List<Vehicle> stationVehicles = new List<Vehicle>();
            station = station.Substring(0,1).ToUpper() + station.Substring(1);
            CountStation countStation = (CountStation) Enum.Parse(typeof(CountStation), station);

            int count = 0;
            for (int i = 0; i < _vehicles.Count; i++)
            {
                if (_vehicles[i].Station.ToString() == countStation.ToString())
                {
                    count++;
                }
            }
            return count;
        }

        public double GetAverageTraffic()
        {

            return _vehicles.Count / 24;
        }
    }
}
