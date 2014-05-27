using System;
using System.Collections.Generic;
using System.Reflection;
using Benchmarks;
using DB;
using NUnit.Framework;
using PetaPoco;
using StructureMap;

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
            using (var db = new Database("testdb"))
            {
                db.FirstOrDefault<Person>("SELECT * FROM People"); // warmup
            }
        }

        [Test]
        public void Run()
        {
            Console.WriteLine(String.Format("Benchmark").PadRight(50, '.') + "Result (ms)");
            Console.WriteLine(string.Format("").PadRight(60, '='));
            foreach(var result in Run(ObjectFactory.GetAllInstances<IBenchmark>()))
                Console.WriteLine(result);
                
        }
    }

    // ReSharper restore InconsistentNaming 
}