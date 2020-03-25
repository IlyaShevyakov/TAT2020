using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DEV_1._3.Tests
{

    [TestClass]
    public class UnitTest1
    {
        [DataRow(-1, 100, "Diesel", "1263F-G75CV")]
        [DataRow(100, -1, "Diesel", "1263F-G75CV")]
        [DataRow(100, 10, "", "1263F-G75CV")]
        [DataRow(100, 10, null, "1263F-G75CV")]
        [DataRow(100, 10, "Diesel", "")]
        [DataRow(100, 10, "Diesel", null)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void EngineException(float power,float engineVolume, string type, string serialNumber)
        {
            DEV_1._3.Engine engine = new DEV_1._3.Engine(power, engineVolume, type, serialNumber);
        }

        [DataRow(-1, "GHF-3", 2500)]
        [DataRow(4, "GHF-3", -1)]
        [DataRow(4, "", 2500)]
        [DataRow(4, null, 2500)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ChassisException(float numberOfWheels,float permissibleLoad, string serialNumber )
        {
            DEV_1._3.Chassis chassis = new DEV_1._3.Chassis (numberOfWheels,permissibleLoad, serialNumber );
        }

        [DataRow("Hydromechanical", "BMW", 0)]
        [DataRow("", "BMW", 5)]
        [DataRow(null, "BMW", 5 )]
        [DataRow("Hydromechanical","",5)]
        [DataRow("Hydromechanical", null, 5)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TransmissonException(string type, string maker, int numberOfGears )
        {
            DEV_1._3.Transmission transmission = new DEV_1._3.Transmission(type, maker, numberOfGears);
        }
    }
}
