using System;
using Benchmarks;
using DB;
using NUnit.Framework;
using PetaPoco;

namespace PetaPocoBenchmarks
{
    public class InsertOneRecord : IInsertOneRecord
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }

    public class Insert50Records : IInsert50Records
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                for (int i = 0; i < 50; i++)
                    db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }

    public class Insert100Records : IInsert100Records
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                for (int i = 0; i < 100; i++)
                    db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }

    public class Insert500Records : IInsert500Records
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                for (int i = 0; i < 500; i++)
                    db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }

    public class Insert1000Records : IInsert1000Records
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                for (int i = 0; i < 1000; i++)
                    db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }

    public class Insert10000Records : IInsert10000Records
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                for (int i = 0; i < 10000; i++)
                    db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }

    public class  Insert100000Records : IInsert100000Records
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                for(int i = 0; i < 100000; i++)
                    db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }

    public class Insert1000000Records : IInsert1000000Records
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                for (int i = 0; i < 1000000; i++)
                    db.Insert(new Person()
                    {
                        Id = Guid.NewGuid(),
                        _First = "Jon",
                        Last = "Doe"
                    });
            }
        }
    }
}