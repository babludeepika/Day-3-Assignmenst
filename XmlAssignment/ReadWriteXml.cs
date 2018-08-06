using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace XmlAssignment
{
    internal class ReadWriteXml
    {
        List<parts> plist = new List<parts>();

        public ReadWriteXml()

        {
            
            plist.Add(new

                parts

            {

                Item = "Motherboard",

                Manufacturer = "ASUS",

                Model = "P3B-F",

                Cost = 123.00

            });

            plist.Add(new

                 parts

            {

                Item = "Video Card",

                Manufacturer = "ATI",

                Model = "All-in-Wonder Pro",

                Cost = 160.00

            });

            plist.Add(new
            parts

            {

                Item = "Sound Card",

                Manufacturer = "Creative Labs",

                Model = "Blaster Live",

                Cost = 80.00

            });

            plist.Add(new

              parts

            {

                Item = "inch Monitor",

                Manufacturer = "inch Monitor",

                Model = "995E",

                Cost = 290.00

            });

        }
        public void writexml()
        {
            XmlWriter w = XmlWriter.Create(" c:\\files\\parts.xml");
            w.WriteStartDocument();
            w.WriteStartElement("parts");
            foreach (var b in plist)
            {
                w.WriteStartElement("parts");


                w.WriteElementString("item", b.Item);
                w.WriteElementString("manufacturer", b.Manufacturer);
                w.WriteElementString("model", b.Model);

                w.WriteElementString("cost", b.Cost.ToString());
                w.WriteEndElement();


            }


            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("xml created");

        }


        public void readxml()
        {
            XElement xe = XElement.Load("c:\\files\\parts.xml");
            var data = xe.Elements();
            foreach (var d in data)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("********");

            
            var data2 = from t in xe.Elements("parts")
                        where (int)t.Element("cost") > 150
                        select t;
            foreach (var d in data2)
                Console.WriteLine(d);

            Console.WriteLine("********");
            foreach (var d in data)
                Console.WriteLine(d.Element("item").Value + " " + d.Element("cost").Value);
        }
    }
}