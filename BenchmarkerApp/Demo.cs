using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkerApp
{
    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark]
        public string GetFullStringNormally()
        {
            string output = "";

            for (int i = 0; i < 100; i++) output += i; 

            return output;
        }

        [Benchmark]
        public string GetFullStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 100; i++) sb.Append(i);

            return sb.ToString();
        }
    }
}
