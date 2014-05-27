using System;
using Benchmarks;
using PetaPoco;

namespace PetaPocoBenchmarks
{
    public class FetchOne : IFetchOneFromOneToManyUsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.FirstOrDefault<DB.Person>("WHERE Id = @0", new Guid("7182C1BB-7131-DDB3-7D44-3F0F094FD8DF"));
            }
        }
    }

    public class FetchOneFromPkUsingLinq : IFetchOneFromPkUsingLinq
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class FetchOneFromOneToManyUsingSql : IFetchOneFromOneToManyUsingSql
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}