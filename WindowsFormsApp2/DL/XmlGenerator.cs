using System;
using System.Xml;

public class XmlGenerator
{
	public XmlGenerator(String name, String url)
	{
        // create xmlDocument
        XmlDocument doc = new XmlDocument();
        doc.LoadXml("<item><name>"+ name +"</name></item>");

        // add url element for rss
        XmlElement newElem = doc.CreateElement("url");
        newElem.InnerText = url;
        doc.DocumentElement.AppendChild(newElem);

        // Save the document to file. 
        doc.Save("bajs.xml");
    }
}
                