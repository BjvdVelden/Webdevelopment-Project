namespace test
{
    public class PerformaceTest
    {

         [Fact]
        public void Test() 
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            {
             //code to test
            }
            sw.Stop();
        }
            
    }
}