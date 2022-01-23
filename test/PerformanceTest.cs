using System.Diagnostics;
using System.Net;
using Xunit;

namespace test
{
    public class PerformanceTest
    {

        [Fact]
        public void LaadTijdPaginaPerformanceTest() 
        {
            Stopwatch sw = new Stopwatch();

            WebClient client = new WebClient();

            sw.Start();
            {
                string performance = client.DownloadString("https://localhost:5001/");
            }
            sw.Stop();
            Assert.True(sw.ElapsedMilliseconds <= 3000);
        }

    }
}