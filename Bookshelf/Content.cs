using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf
{
    public class Content : BookProperty
    {
        public Content(string value) : base(value, "Content", ConsoleColor.Yellow) { }
    }
}
