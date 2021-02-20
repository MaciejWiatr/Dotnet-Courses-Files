using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class PowerPointFile:File
    {
        public void Present()
        {
            Console.WriteLine($"{Filename} presenting..");
        }

        public override void compress()
        {
            Console.WriteLine("Compressing PPoint");
        }
    }
}
