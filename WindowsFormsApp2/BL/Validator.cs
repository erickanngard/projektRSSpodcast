using System;

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
}
