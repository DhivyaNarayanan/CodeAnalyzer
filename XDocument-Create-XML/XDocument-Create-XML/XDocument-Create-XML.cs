/////////////////////////////////////////////////////////////////////
// XDocument-Create-XML.cs - demonstrate creating an XML file      //
//                           using System.Xml.Linq.XDocument       //
//                                                                 //
// Jim Fawcett, CSE681 - Software Modeling and Analysis, Fall 2014 //
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XDocument_Create_XML
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("\n  Create XML file using XDocument");
      Console.Write("\n =================================\n");

      XDocument xml = new XDocument();
      xml.Declaration = new XDeclaration("1.0", "utf-8", "yes");
     /*
      *  It is a quirk of the XDocument class that the XML declaration,
      *  a valid processing instruction element, cannot be added to the
      *  XDocument's element collection.  Instead, it must be assigned
      *  to the document's Declaration property.
      */
      XComment comment = new XComment("Demonstration XML");
      xml.Add(comment);

      XElement root = new XElement("root");
      xml.Add(root);
      XElement child1 = new XElement("child1", "child1 content");
      XElement child2 = new XElement("child2");
      XElement grandchild21 = new XElement("grandchild21", "content of grandchild21");
      child2.Add(grandchild21);
      root.Add(child1);
      root.Add(child2);

      Console.Write("\n{0}\n", xml.Declaration);
      Console.Write(xml.ToString());
      Console.Write("\n\n");
    }
  }
}
