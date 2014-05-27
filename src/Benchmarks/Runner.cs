using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Benchmarks
{
    public abstract class Runner
    {
        private readonly Stopwatch _timer;
        private readonly IEnumerable<IBenchmark> _benchMarks;

        protected Runner()
        {
            _timer = new Stopwatch();
        }

        protected IEnumerable<BenchmarkResult> Run(IEnumerable<IBenchmark> benchmarks)
        {
            return benchmarks.Select(Run);
        }

        private BenchmarkResult Run(IBenchmark benchmark)
        {
            try
            {
                _timer.Reset();
                _timer.Start();
                benchmark.Run();
                _timer.Stop();
                return new BenchmarkResult(benchmark.GetType(), _timer.Elapsed);
            }
            catch (NotImplementedException)
            {
                return new BenchmarkResult(benchmark.GetType(), TimeSpan.Zero);
            }
        }
    }
}