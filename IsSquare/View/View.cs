using System;
public class View : IView
{
    public void Show(string s)
    {
        Console.Clear();
        Console.WriteLine(s);    
    }
}