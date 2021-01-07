
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq; 

public class HelloWorld
{
	public static void Main(string[] args)
	{
		Console.WriteLine ("Hello XML World");
		XDocument document = XDocument.Load("../data/products.xml");
		var products = document.Descendants("product");
		foreach (var x in products) {
			Console.WriteLine (" Product: {0}", x);
		}
		var myList = products.Select(x => new { id = x.Attribute("id").Value });
		myList.ToList().ForEach(x => { Console.WriteLine("ID: " + x.id); });
		Console.WriteLine ("Bye XML World");
	}
}

