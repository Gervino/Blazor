using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAp.Data
{
    public interface IAuthorService
    {
        public List<Author> GetAuthors();

        public Author GetAuthorById(int authorId);

        public DateTime GetCreatedDate();

        public void SaveAuthor(Author author);
        public string GetVersion();
    }
}
