using System;
using System.Collections.Generic;
using System.Text;

namespace Session3Assignment
{
    internal class Books
    {
        public string? Title;
        public int Pages;

        public override string ToString()
        {
            return $"Book Data:{Title}-{Pages}";
        }
        public override bool Equals(object? obj)
        {
            Books book2=obj as Books;
            return (this.Title==book2.Title)&&(Pages==book2.Pages);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
