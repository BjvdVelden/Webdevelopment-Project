// using System.Diagnostics;
// using System.Net;
// using Xunit;

// namespace test
// {
//     public class PerformaceTest
//     {

//         [Fact]
//         public void Test() 
//         {
//             Stopwatch sw = new Stopwatch();
//             WebClient client = new WebClient();

//             sw.Start();
//             {
//                 string performancetest = client.DownloadString("https://localhost:5001/");
//             }
//             sw.Stop();
//             Assert.True(sw.ElapsedMilliseconds <= 3000);
//         }
            
//     }
// }