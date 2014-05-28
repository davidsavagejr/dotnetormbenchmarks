using System;
using Benchmarks;
using DB;
using PetaPoco;
using System.Linq;

namespace PetaPocoBenchmarks
{
    public class FetchOne : IFetchOneFromOneToManyUsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.FirstOrDefault<Person>("WHERE Id = @0", new Guid("7182C1BB-7131-DDB3-7D44-3F0F094FD8DF"));
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
            using (var db = new Database("testdb"))
            {
                var person = db.Fetch<Person, BlogPost, Person>(
                    new PersonPostRelator().MapIt,
                    @"
                    SELECT * FROM People p
                    LEFT OUTER JOIN BlogPosts b ON b.PersonId = p.Id
                    WHERE p.Id = @0", new Guid("7182C1BB-7131-DDB3-7D44-3F0F094FD8DF"))
                .FirstOrDefault();
            }
        }
    }
}