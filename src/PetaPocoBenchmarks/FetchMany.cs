using Benchmarks;
using PetaPoco;

namespace PetaPocoBenchmarks
{
    public class FetchTop50UsingSql : IFetchTop50UsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Fetch<DB.Person>("SELECT TOP 50 * FROM People");
            }
        }
    }

    public class FetchTop100UsingSql : IFetchTop100UsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Fetch<DB.Person>("SELECT TOP 100 * FROM People");
            }
        }
    }

    public class FetchTop500UsingSql : IFetchTop500UsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Fetch<DB.Person>("SELECT TOP 500 * FROM People");
            }
        }
    }

    public class FetchTop1000UsingSql : IFetchTop1000UsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Fetch<DB.Person>("SELECT TOP 1000 * FROM People");
            }
        }
    }

    public class FetchTop10000UsingSql : IFetchTop10000UsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Fetch<DB.Person>("SELECT TOP 10000 * FROM People");
            }
        }
    }

    public class FetchTop100000UsingSql : IFetchTop100000UsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Fetch<DB.Person>("SELECT TOP 100000 * FROM People");
            }
        }
    }

    public class FetchTop1000000UsingSql : IFetchTop100000UsingSql
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Fetch<DB.Person>("SELECT TOP 1000000 * FROM People");
            }
        }
    }
}