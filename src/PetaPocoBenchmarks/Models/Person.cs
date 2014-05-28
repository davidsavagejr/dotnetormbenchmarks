using System.Collections.Generic;

namespace DB
{
    public partial class Person
    {
        [PetaPoco.ResultColumn]
        public List<BlogPost> BlogPosts { get; set; }
    }
}