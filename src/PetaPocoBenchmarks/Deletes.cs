using System;
using System.Collections.Generic;
using Benchmarks;
using PetaPoco;

namespace PetaPocoBenchmarks
{
    public class DeleteOneRecord : IDeleteOneRecord
    {
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Execute("DELETE FROM People WHERE ID = @0", new Guid("E90C7596-8813-E26D-3952-0099569DE9E3"));
            }
        }
    }

    public class Delete10RecordsUsingPrimaryKey : IDelete10RecordsUsingPrimaryKey
    {
        static List<Guid> IdsToDelete
        {
            get
            {
                return new List<Guid>()
                    {
                        new Guid("9368B7E9-42A9-9628-D7EA-0141C160F5B8"),
                        new Guid("09ED3A61-B7D0-D48E-12E7-016CCA62A78E"),
                        new Guid("1540AB5F-6DFE-7014-E6D0-01C5403B1C4B"),
                        new Guid("BFFD3821-707B-DCFD-027F-01F9D9F8A230"),
                        new Guid("6C97044C-B41C-7DEF-137E-022AAB39DD8E"),
                        new Guid("C74BEA14-5951-21D2-B2F1-02A6500B50DE"),
                        new Guid("45C3AE34-2D70-FDA9-819B-033796DD3E87"),
                        new Guid("94F03DDF-4D6E-0FA3-A555-03D4C4E51D75"),
                        new Guid("5903A082-87BB-7B2E-9D0B-047B57F2744C"),
                        new Guid("3B42E7C2-BC22-3EF1-55D7-05E57D366DA2")
                    };
            }
        }
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Execute("DELETE FROM People WHERE ID IN(@0)", IdsToDelete);
            }
        }
    }

    public class Delete10RecordsUsingColumn : IDelete10RecordsUsingColumn
    {
        static List<string> EmailsToDelete
        {
            get
            {
                return new List<string>()
                    {
                        "pulvinar.arcu@adipiscingelit.edu",
                        "est.Nunc.laoreet@dolorsitamet.com",
                        "nunc@Integer.co.uk",
                        "aliquam@arcuacorci.com",
                        "elementum.lorem.ut@dui.co.uk",
                        "Aliquam.tincidunt@urna.com",
                        "iaculis.quis@sagittisDuisgravida.com",
                        "a.magna@laoreetposuere.edu",
                        "adipiscing.fringilla@justo.com",
                        "tortor.Nunc@sit.edu",
                        "tincidunt@velvenenatis.ca",
                    };
            }
        }
        public void Run()
        {
            using (var db = new Database("testdb"))
            {
                db.Execute("DELETE FROM People WHERE Email IN(@0)", EmailsToDelete);
            }
        }
    }
}