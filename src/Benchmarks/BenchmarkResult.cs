using System;
using System.Diagnostics;

namespace Benchmarks
{
    public class BenchmarkResult
    {
        public BenchmarkResult(Type benchmark, TimeSpan result)
        {
            Result = result;
            _benchmark = benchmark;
        }

        private readonly Type _benchmark;
        public TimeSpan Result { get; private set; }

        public override string ToString()
        {
            var display = string.Format("{0}", _benchmark.Name).PadRight(50, '.');
            return display + (Result == TimeSpan.Zero ? "Not Implemented" : Result.TotalMilliseconds.ToString());
        }
    }
}