using System;
using System.Xml;

public class Class1
{
	public static Class1(String name)
	{
        // create xmlDocument
        XmlDocument doc = new XmlDocument();
        doc.LoadXml("<item><name>"+ name +"</name></item>");

        // add url element for rss
        XmlElement newElem = doc.CreateElement("url");
        newElem.InnerText = url;
        doc.DovumentElement.AppendChild(newElem);

        // Save the document to file. 
        doc.Save("bajs.xml");
    }
}
                