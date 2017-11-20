using System;
using System.Collections.Generic;



namespace WindowsFormsApp2.BL
{ 
public class Validator
{

    private bool result;
	public Validator()
	{
        this.result = false;

	}

    public bool ValidateText (String t)
    {
        return result; // returns bool if its sucessfull sdsd

    }

    public bool ValidateEndsWithRSS(String t)
    {
        result = false;

        if (t.EndsWith("rss.xml"))
        {
            result = true;
        }
        return result;
    }
    public bool ValidateTextBoxNotEmpty(String t)
    {
        return !String.IsNullOrEmpty(t);
    }

    static public int gerneratePodcastID()
    {
            PodcastController pc = new PodcastController();
            List<Podcast> pl = pc.LoadLocalPodcasts();
            int i = 0;
            if (pl.Count > 0)
            {
                Podcast p = pl[pl.Count - 1];  
                i = p.id + 1;
            }
         
            return i;
    }
}
}