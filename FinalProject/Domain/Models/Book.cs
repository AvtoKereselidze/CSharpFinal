using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Domain.Models
{
    class Book
    {
        public string Name { get; set; }

        public Author Author { get; set; }

        public string Description { get; set; }
    }
}
