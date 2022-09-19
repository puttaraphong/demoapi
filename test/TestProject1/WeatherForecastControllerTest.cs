using DemoAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Mock<ILogger<WeatherForecastController>> moqLog = new Mock<ILogger<WeatherForecastController>>();

            WeatherForecastController controller = new WeatherForecastController(moqLog.Object);

            var list = controller.Get();

            Assert.True(list.Any());
        }
    }
}