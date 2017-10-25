using System;

public class Podcast
{
    private string title;
    private string category;


	public Podcast( String title, String category)
	{
        this.title = title;
        this.category = category;
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
