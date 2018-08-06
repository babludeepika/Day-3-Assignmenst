using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadWriteXml XML = new ReadWriteXml();
            // XML.writexml();
            XML.readxml();
        }
    }
}
