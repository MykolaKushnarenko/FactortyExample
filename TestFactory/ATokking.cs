using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory
{
    class ATokking
    {
        public string NameLang { get; private set; }
        public string TagLang { get; set; }
        public ATokking(){}

        public ATokking(string name, string tag)
        {
            NameLang = name;
            TagLang = tag;
        }

        public void Print()
        {
            Console.WriteLine($"Language {NameLang}: Tag {TagLang}");
        }
    }
}
