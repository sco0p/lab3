using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf
{
    public class Title : BookProperty
    {
        public Title(string value) : base(value, "Title", ConsoleColor.Cyan) { }
    }
}
