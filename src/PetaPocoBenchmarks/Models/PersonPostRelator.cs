using System.Collections.Generic;

namespace DB
{
    public class PersonPostRelator
    {
        public Person current;
        public Person MapIt(Person person, BlogPost post)
        {
            // Terminating call.  Since we can return null from this function
            // we need to be ready for PetaPoco to callback later with null
            // parameters
            if (person == null)
                return current;

            // Is this the same author as the current one we're processing
            if (current != null && current.Id == person.Id)
            {
                // Yes, just add this post to the current author's collection of posts
                current.BlogPosts.Add(post);

                // Return null to indicate we're not done with this author yet
                return null;
            }

            // This is a different author to the current one, or this is the 
            // first time through and we don't have an author yet

            // Save the current author
            var prev = current;

            // Setup the new current author
            current = person;
            current.BlogPosts = new List<BlogPost>();
            current.BlogPosts.Add(post);

            // Return the now populated previous author (or null if first time through)
            return prev;
        }
    }
}