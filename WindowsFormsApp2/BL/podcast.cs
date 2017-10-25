using System;

public class Podcast
{
    private string title;
    private string category;
    public string url { get; set; }
    public int interval { get; set; }
    public Array[] episodes;
    


	public Podcast( String title, String category, String url, int interval)
	{
        this.title = title;
        this.category = category;
        this.url = url;
        this.interval = interval;
    }

    public void SetTitel(String title)
    {
        this.title = title;
    }
    public void SetCategory(String category)
    {
        this.category = category;
    }
    public String getTitle()
    {
        return this.title;
    }
    public String getCategory()
    {
        return this.category;
    }
    
}