using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.CoreLayer.Entity;
using Xunit;

namespace TravelManagement.Test.Entitty
{
    public class VehicleTest
    {
        private readonly Vehicle vehicle;
        VehicleTest()
        {
            vehicle = new Vehicle("Bike", "BA 1 PA", "Red");
        }
        [Fact]
        public void Test_Vehicle_Create_new_instance_with_default_data_successfully()
        {
            Assert.Equal("Bike", vehicle.Name);
            Assert.Equal("BA 1 PA", vehicle.Number);
            Assert.Equal("Red", vehicle.Color);
        }
        [Fact]
        public void Test_Available_return_True_if_vehicle_available()
        {
            vehicle.NotAvailable();
            vehicle.Available();
            Assert.True(vehicle.IsAvailable())
        }
}
