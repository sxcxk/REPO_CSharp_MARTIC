using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrafficCounting.Core
{
    public class RequestHandler
    {
        private string _request;
        private VehicleManager _vehicleManager;
        public RequestHandler(string request)
        {
            _request = request;
            _vehicleManager = VehicleManager.Instance;
        }

        public string GetResponse()
        {
            string[] cmd = _request.ToLower().Split(' ');


            if (_request.Contains("add"))
            {
                Vehicle vehicle = null;
                if (_request.Contains("car"))
                {
                    Car car = new Car(cmd[2], cmd[1]);
                    vehicle = (Vehicle) car;
                }

                if (_request.Contains("truck"))
                {
                    Truck truck = new Truck(cmd[2], cmd[1]);
                    vehicle = (Vehicle)truck;
                }

                if (_request.Contains("onelanecar"))
                {
                    OneLaneCar oneLaneCar = new OneLaneCar(cmd[2], cmd[1]);
                    vehicle = (Vehicle)oneLaneCar;

                }
                _vehicleManager.Add(vehicle);
                return "Vehicle added";
            }

            if (_request.Contains("summary all"))
            { 
                List<Vehicle> _vehicles = _vehicleManager.GetAll();
                if (_vehicles.Count==0)
                {
                    return "No vehicles";
                }

                else
                {
                    int countCar = 0;
                    int countTruck = 0;
                    int countOneLaneCar = 0;

                    for (int i = 0; i < _vehicles.Count; i++)
                    {
                        if (_vehicles[i] is Car)
                        {
                            countCar++;
                        }

                        if (_vehicles[i] is Truck)
                        {
                            countTruck++;
                        }

                        if (_vehicles[i] is OneLaneCar)
                        {
                            countOneLaneCar++;
                        }
                    }
                    return "Fahrzeuge insgesamt: " + _vehicles.Count + "\n davon PKW: " + countCar + "\n davon LKW: " + countTruck + "\n davon einspurig: " + countOneLaneCar;
                }
            }

            if (_request.Contains("summary countstation"))
            {
                return cmd[2] + ": " + _vehicleManager.GetStationCount(cmd[2]);
            }

            if (_request.Contains("avg"))
            {
                return _vehicleManager.GetAverageTraffic().ToString();
            }
            return "unknown cmd..";
        }
    }
}
