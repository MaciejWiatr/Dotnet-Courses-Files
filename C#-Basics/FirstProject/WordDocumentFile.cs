using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class WordDocumentFile:File
    {
        public void Print()
        {
            Console.WriteLine($"{Filename} print..");
        }

        public override void compress()
        {
            Console.WriteLine("Compressing Word Doc");
        }

    }
}
