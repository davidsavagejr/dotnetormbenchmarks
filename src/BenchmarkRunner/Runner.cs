using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Benchmarks;
using NUnit.Framework;
using System.Linq;

namespace BenchmarkRunner
{
    public abstract class Runner
    {
        private readonly Stopwatch _timer;

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
            _timer.Reset();
            _timer.Start();
            benchmark.Run();
            _timer.Stop();
            return new BenchmarkResult<IBenchmark>(_timer);
        }
    }
}