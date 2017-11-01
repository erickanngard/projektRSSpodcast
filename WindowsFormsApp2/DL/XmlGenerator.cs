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

    public void EditValuePodcast(Podcast p, String newTitle)//String newCategroy, String newUrl
    {// får inte den att funka 
        /*
        String rootDir = "XML_Data";
        String xmlfile = "xmldata";
        String path = rootDir + "/" + xmlfile + ".xml";

        if (!File.Exists(path))
        {
            new List<Podcast>();// return innan
        }

        XmlDocument xmlDom = new XmlDocument();
        xmlDom.Load(path);


        List<Podcast> listOfPodcast = loadLocalFiles();

        foreach( Podcast pod in listOfPodcast)
        {
            foreach (XmlNode n in xmlDom.DocumentElement.SelectNodes("items/Podcast"))
            {
                if (pod.title == p.title && pod.title == n.SelectSingleNode("title").InnerText)
                {
                    n.SelectSingleNode("tile").InnerText = newTitle;
                }
                /*if (pod.category == p.category)
                {
                    XmlNode node = xmlDom.SelectSingleNode("/items/Podcast[category= ' " + p.category + " ']");
                    node.Attributes["category"].Value = newCategroy;
                }
                if (pod.url == p.url)
                {
                    XmlNode node = xmlDom.SelectSingleNode("/items/Podcast[url= ' " + p.url + " ']");
                    node.Attributes["url"].Value = newUrl;
                }*/
                /*if(pod.interval == p.interval)
                {
                    //XmlNode node = xmlDom.SelectSingleNode("root/items/Podcast[interval= " + p.interval + " ]");
                    //node.Attributes[0].Value = newInterval;
                }
            }
        }
        xmlDom.Save(path);
    */

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
                
