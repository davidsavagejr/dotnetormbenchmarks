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
            if(Result == TimeSpan.Zero)
                return string.Format("{0} : Not Implemented");

            return string.Format("{0} : {1} ms", _benchmark.Name, Result.TotalMilliseconds);
        }
    }

    public class BenchmarkResult<T> : BenchmarkResult
    {
        public BenchmarkResult(TimeSpan result) : base(typeof(T), result)
        {
        }
    }
}