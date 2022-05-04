using System;
using System.Collections.Concurrent;

public class ConcurrentClass
{
	public ConcurrentClass()
	{

	}

	public List makeList(List a)
    {
		a.Add(1);
		return a;
    }
}
