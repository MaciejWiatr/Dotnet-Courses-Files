using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class WordDocumentFile:IFile
    {

        public string FileName {get;set;}
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Print()
        {
            Console.WriteLine($"{FileName} print..");
        }

        public void Compress()
        {
            Console.WriteLine("Compressing Word Doc");
        }

    }
}
