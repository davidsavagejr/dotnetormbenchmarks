namespace Benchmarks
{
    public interface IBenchmark
    {
        void Run();
    }
    public class Benchmark : IBenchmark
    {
        public void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}