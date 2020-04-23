using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAp.Data
{
    public class AuthorService_v2 : IAuthorService
    {

        public DateTime CreationDate { get; set; }
        public List<Author> Authors { get; set; }

        public AuthorService_v2()
        {
            CreationDate = DateTime.Now;

            Authors = new List<Author>();
            Authors.Add(new Author(1, "Jipmo", "Gervino", "3887340893", "Ndogbong", "kougere@yahoo.fr", 500));
            Authors.Add(new Author(2, "Chloe", "Kouanseu", "3887340893", "Udine", "kougervino@gmail.com", 3000));
            Authors.Add(new Author(3, "Ronelle", "Kemegne", "3884280964", "Dschang", "Youbironelle@yahoo.fr", 6000));

        }

        public List<Author> GetAuthors()
        {
            foreach(Author author in Authors)
            {
                author.FirstName = author.FirstName.ToLower();
                author.LastName = author.LastName.ToLower();

                author.Phonenumber = author.Phonenumber.Replace(" ", "-");
            }

            return Authors;
        }

        public Author GetAuthorById(int authorId)
        {
            return Authors.Where(auth => auth.AuthorId == authorId).FirstOrDefault();
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public void SaveAuthor(Author author)
        {
            Authors.Add(author);
        }

        public string GetVersion()
        {
            return "v2";
        }
    }
}
