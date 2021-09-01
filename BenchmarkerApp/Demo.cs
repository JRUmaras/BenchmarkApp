using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkerApp
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net50, baseline: true)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark(Baseline = true)]
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
