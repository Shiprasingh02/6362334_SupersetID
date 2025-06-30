using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory;

            
            factory = new WordDocumentFactory();
            IDocument word = factory.CreateDocument();
            word.Open();

            
            factory = new PdfDocumentFactory();
            IDocument pdf = factory.CreateDocument();
            pdf.Open();

            factory = new ExcelDocumentFactory();
            IDocument excel = factory.CreateDocument();
            excel.Open();

            Console.ReadLine(); 
        }
    }
}