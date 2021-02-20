using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ExcelFile:File
    {
        public void GenerateReport()
        {   
            string prop = ProtectedProp;
            Console.WriteLine($"{Filename} report..");
        }

        public override void compress()
        {
            Console.WriteLine("Compressing Excel file");
        }
    }
}
