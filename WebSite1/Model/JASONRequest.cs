using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JASONRequest
/// </summary>
public class JASONRequest
{   
        public int id { get;set; }
        public string name { get; set;}
        public bool isComplete { get; set; }

    public  void ToString() => Console.Write("hi :)");
}