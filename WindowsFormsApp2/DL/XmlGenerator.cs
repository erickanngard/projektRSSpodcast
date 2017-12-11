using System;
using System.Text;
using System.Xml;
using WindowsFormsApp2.BL;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml.XPath;

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
        String path = rootDir + "/" + xmlfile + ".xml";//

        if (!File.Exists(path))
        {
            return new List<Podcast>();
        }

        XmlDocument xmlDom = new XmlDocument();
        try {
            xmlDom.Load(path);
        }
        catch (StackOverflowException e)
        {
            Console.WriteLine(e);
        }

        List<Podcast> listOfLocalPods = new List<Podcast>();

        foreach (XmlNode n in xmlDom.DocumentElement.SelectNodes("items/Podcast"))
        {
            var title = n.SelectSingleNode("title").InnerText;
            var cat = n.SelectSingleNode("category").InnerText;
            var url = n.SelectSingleNode("url").InnerText;
            var id = Int32.Parse(n.SelectSingleNode("id").InnerText);
            int interval;
            Int32.TryParse(n.SelectSingleNode("interval").InnerText, out interval);
            listOfLocalPods.Add(new Podcast(title, cat, url, interval, id, new List<Episode>()));
        }

        return listOfLocalPods;
    }

    public void DeleteCategory(String Category)
    {
        String rootDir = "XML_Data";
        String xmlfile = "xmldata";
        String path = rootDir + "/" + xmlfile + ".xml";

        if (!File.Exists(path))
        {
            new List<Podcast>();// return innan
        }

        XmlDocument xmlDom = new XmlDocument();
        xmlDom.Load(path);
        XmlNodeList xmlNodes = xmlDom.SelectNodes("items/Podcast");

        List<Podcast> listOfPodcast = loadLocalFiles();
        List<Podcast> PodcastinCat = new List<Podcast>();
        
        foreach ( Podcast pod in listOfPodcast)
        {
            if(pod.category == Category)
            {
                PodcastinCat.Add(pod);
            }
            
        }
        foreach (Podcast p in PodcastinCat) {
            foreach (XmlNode n in xmlDom.DocumentElement.SelectNodes("items/Podcast"))
            {
                var cat = n.SelectSingleNode("category").InnerText;
                if ( cat== Category)
                {
                    n.SelectSingleNode("category").InnerText = "0";
                }
                
            }
        }
        xmlDom.Save(path);
    }

    public void deletePodcast( Podcast p )
    {
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
        int test = 0;

        foreach (XmlNode n in xmlDom.DocumentElement.SelectNodes("items/Podcast"))
        {
            int node = Int32.Parse(n.SelectSingleNode("id").InnerText);
            if (p.id == node)
            {
                n.ParentNode.RemoveChild(n);
            }
        }
        
        xmlDom.Save(path);

    }

    public void EditValuePodcast(Podcast p, String newTitle, String newCategroy, String newUrl)
    {// får inte den att funka 
        
        String rootDir = "XML_Data";
        String xmlfile = "xmldata";
        String path = rootDir + "/" + xmlfile + ".xml";

        if (!File.Exists(path))
        {
            new List<Podcast>();// return innan
        }

        XmlDocument xmlDom = new XmlDocument();
        xmlDom.Load(path);
       // XPathNavigator xmlNav = xmlDom.CreateNavigator();

       // XmlNamespaceManager xmlManager = new XmlNamespaceManager(xmlNav.NameTable);
        
        List<Podcast> listOfPodcast = loadLocalFiles();

        foreach( Podcast pod in listOfPodcast)
        {
            foreach (XmlNode n in xmlDom.DocumentElement.SelectNodes("/items/Podcast"))
            {
                if ( pod.id == p.id )
                {
                    n.Attributes["title"].Value = newTitle;
                    n.SelectSingleNode("title").InnerText = newTitle;
                    n.SelectSingleNode("category").InnerText = newCategroy;
                    n.SelectSingleNode("url").InnerText = newUrl;

                    /*if (pod.title == p.title && pod.title == n.SelectSingleNode("title").InnerText)
                    {
                       
                    }
                    if (pod.category == p.category && pod.category == n.SelectSingleNode("category").InnerText)
                    {
                         // den sätter den nya cat på alla som har den cat
                    }
                    if (pod.url == p.url && pod.url == n.SelectSingleNode("url").InnerText)
                    {
                        
                    }*/
                }
                //if(pod.interval == p.interval)
                //{
                    //XmlNode node = xmlDom.SelectSingleNode("root/items/Podcast[interval= " + p.interval + " ]");
                    //node.Attributes[0].Value = newInterval;
                //}
            }
        }
        xmlDom.Save(path);
    

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
                
