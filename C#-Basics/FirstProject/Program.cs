using System;
using FirstProject.Enums;
using ClassLibrary;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.CreatedOn = DateTime.Now;
            excelFile.Filename = "excel-file";
            excelFile.GenerateReport();

            Class1 test = new Class1();
        }
    }

}
