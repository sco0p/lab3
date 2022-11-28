using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf
{
    public class Author : BookProperty
    {
        public Author(string value) : base(value, "Author", ConsoleColor.Blue) { }
    }
}
