using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Estacionamento
{
    public class Estacionamento
    {
        public string ?LicensePlate {  get; set; }
        public decimal StartPrice { get; set; }
        public decimal HourPrice { get; set; }
        public bool ActiveSystem { get; set; }

        List<string> vehicles = new List<string>();


        public void addVehicle(string licensePlate)
        {
            vehicles.Add(licensePlate);
        }

        public void removeVehicle(string licensePlate) 
        {
            vehicles.Remove(licensePlate);
        }
        
        public List<string> listVehicle()
        {

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine(vehicle);
            }

            return vehicles;
        }
    }
}
