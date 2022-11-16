using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Travel.CoreLayer.Entity;
using Xunit;

namespace TravelManagement.Test.Entity
{
    public class DistrictTest
    {
        [Fact]
        public void Test_District_create_new_instance_with_default_data_successfully()
        {
            District district = new District("Sarlahi");
            Assert.Equal("Sarlahi", district.Name);
        }
        [Fact]
        public void Test_IsActive_returns_true_if_class_is_active()
        {
            District district = new District("Sarlahi");
            district.DeActivate();
            district.Activate();
            Assert.True(district.IsActive());

        }
        [Fact]
        public void Test_IsDeactive_returns_true_if_class_is_deactive()
        {
            District district = new District("Sarlahi");
            DistrictChild child = new DistrictChild();
            child.Name = "kishan";
            district.DeActivate();
            Assert.False(district.IsActive());
        }
    }
}
