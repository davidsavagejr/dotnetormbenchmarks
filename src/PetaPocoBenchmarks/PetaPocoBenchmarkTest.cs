using System;
using System.Collections.Generic;
using System.Reflection;
using Benchmarks;
using DB;
using NUnit.Framework;
using PetaPoco;
using StructureMap;
using System.Linq;

namespace PetaPocoBenchmarks
{
    // ReSharper disable InconsistentNaming

    [TestFixture]
    public class PetaPocoBenchmarkTest : Runner
    {
        [TestFixtureSetUp]
        public void Setup()
        {
           ObjectFactory.Configure(c => c.Scan(s =>
               {
                   s.Assembly(Assembly.GetExecutingAssembly());
                   s.AddAllTypesOf<IBenchmark>();
               }));
        }

        private IEnumerable<IBenchmark> GetBenchMarksOfType<T>()
        {
            return ObjectFactory.GetAllInstances<IBenchmark>()
                         .OfType<T>()
                         .Select(b => b as IBenchmark);
        }

        [Test]
        public void RunInserts()
        {
            Console.WriteLine(String.Format("Benchmark").PadRight(50, '.') + "Result (ms)");
            Console.WriteLine(string.Format("").PadRight(60, '='));

            foreach (var result in Run(GetBenchMarksOfType<IInsertData>()))
                Console.WriteLine(result);

            foreach (var result in Run(GetBenchMarksOfType<IUpdateData>()))
                Console.WriteLine(result);

            foreach (var result in Run(GetBenchMarksOfType<IQueryData>()))
                Console.WriteLine(result);

            foreach (var result in Run(GetBenchMarksOfType<IDeleteData>()))
                Console.WriteLine(result);
                
        }

        [Test, Explicit]
        public void ScratchTest()
        {
            Console.WriteLine(Run(new Delete10RecordsUsingColumn()));
        }
    }

    // ReSharper restore InconsistentNaming 
}