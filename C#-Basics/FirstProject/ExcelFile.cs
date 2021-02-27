using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class ExcelFile: IFile
    {
        public string FileName {get;set;}
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void GenerateReport()
        {   
            Console.WriteLine($"{FileName} report..");
        }

        public void Compress()
        {
            Console.WriteLine("Compressing Excel file");
        }
    }
}
