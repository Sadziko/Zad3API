using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Zad3API.Model
{
    public class Author
    {
        public string Mail { get; set; }
        public string ProfileId { get; set; }
        public string Name { get; set; }
        public Uri Avatar { get; set; }
        public string Footer { get; set; }


        public Author(string emailAccName, string accName, Uri linkToAvatar, string footer)
        {
            this.Mail = emailAccName + "@najlepszaSkrzynka.pl";
            ProfileId = Guid.NewGuid().ToString();
            this.Name = accName;
            this.Avatar = linkToAvatar;
            this.Footer = footer;
        }
    }
}
