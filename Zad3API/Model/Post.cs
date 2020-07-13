using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zad3API.Model
{
    public class Post
    {
        public string Id { get; set; }
        public Author Author { get; set; }
        public string Text { get; set; }
        public string[] ResponsesId { get; set; }

        public Post(Author author, string text)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Author = author;
            this.Text = text;
            
            Random random = new Random();
            this.ResponsesId = GenerateRandomResponsesId(random.Next(1, 5));
        }

        private string[] GenerateRandomResponsesId(int arrayLength)
        {
            string[] arrayToReturn = new string[arrayLength];
            for (int i = 0; i < arrayToReturn.Length; i++)
            {
                arrayToReturn[i] = Guid.NewGuid().ToString();
            }

            return arrayToReturn;
        }
    }
}
