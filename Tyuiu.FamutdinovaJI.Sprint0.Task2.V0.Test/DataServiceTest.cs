using Tyuiu.FamutdinovaJI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }
            [Test]
            public void CheckGetMessageValid()
            {
                var name = "Юля";
                var res = DataService.GetMessage(name);
                Assert.AreEqual("Привет..., Юля", res);
            }
    }
}