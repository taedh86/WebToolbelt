using System;
using System.Collections.Generic;
using System.Text;

namespace WebToolbelt.Entities.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string EnglishName { get; set; }
        public string NativeName { get; set; }
    }
}
