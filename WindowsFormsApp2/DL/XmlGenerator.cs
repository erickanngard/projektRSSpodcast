using System;
using System.Text;
using System.Xml;
using WindowsFormsApp2.BL;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

public class XmlGenerator
{
    
    public static bool SavePodcast(Podcast p)
    {
        XmlDocument xmlDom = new XmlDocument();
        
        String rootDir = "XML_Data";
        String xmlfile = "xmldata";
        String path = rootDir + "/" + xmlfile + ".xml";
        String fileContent = serializePodcast(p);

        if (!Directory.Exists(rootDir))
        {
            Directory.CreateDirectory(rootDir);
        }

        
        
        if (!File.Exists(path))
        {
            // Skapa och lägg till

            XmlElement rootNode = xmlDom.CreateElement("root");
            XmlElement items = xmlDom.CreateElement("items");
            XmlDocument newPod = new XmlDocument();
            
            newPod.LoadXml(fileContent);
            XmlNode node = newPod.DocumentElement;

            XmlNode importNode = items.OwnerDocument.ImportNode(node, true);

            items.AppendChild(importNode);
            rootNode.AppendChild(items);
            xmlDom.AppendChild(rootNode);
            

        }
        else
        {
            //Append
            xmlDom.Load(path);

            XmlDocument newPod = new XmlDocument();
            newPod.LoadXml(fileContent);
            XmlNode node = newPod.DocumentElement;

            XmlNode items = xmlDom.DocumentElement.SelectSingleNode("items");

            XmlNode importNode = items.OwnerDocument.ImportNode(node, true);
            items.AppendChild(importNode);
        
        }

        xmlDom.Save(path);


        return false;
    }

    private static string serializePodcast(Podcast p)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Podcast));
        String fileContent = "";

        using (var w = new StringWriter())
        {
            using (XmlWriter xw = XmlWriter.Create(w))
            {
                xmlSerializer.Serialize(w, p);
                fileContent = w.ToString();
                return fileContent;
            }
        }
    }

    public static List<Podcast> loadLocalFiles()
    {
        String rootDir = "XML_Data";
        String xmlfile = "xmldata";
        String path = rootDir + "/" + xmlfile + ".xml";

        if (!File.Exists(path))
        {
            return new List<Podcast>();
        }

        XmlDocument xmlDom = new XmlDocument();
        xmlDom.Load(path);

        List<Podcast> listOfLocalPods = new List<Podcast>();

        foreach (XmlNode n in xmlDom.DocumentElement.SelectNodes("items/Podcast"))
        {
            var title = n.SelectSingleNode("title").InnerText;
            var cat = n.SelectSingleNode("category").InnerText;
            var url = n.SelectSingleNode("url").InnerText;
            int interval;
            Int32.TryParse(n.SelectSingleNode("interval").InnerText, out interval);


            listOfLocalPods.Add(new Podcast(title, cat, url, interval, new List<Episode>()));
        }

        return listOfLocalPods;
    }
}

/**
string DirectoryName = @"XML-Library/" + RSSCategory + "/";
            if ((!Directory.Exists(DirectoryName)))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            return DirectoryName;

*/
                
