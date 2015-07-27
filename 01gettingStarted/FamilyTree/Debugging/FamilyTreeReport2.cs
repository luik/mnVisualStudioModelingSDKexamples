
//Generated material. Generating code in C#.

using System;
using System.Collections.Generic;
using Core;

public class ElementsProvider
{
	private List<Element> elements;
	public List<Element> Elements
	{
		get {return elements;}
	}

	public ElementsProvider()
	{
		elements = new List<Element>();

		elements.Add(new Element("ExampleElement1"));
		elements.Add(new Element("ExampleElement2"));
		elements.Add(new Element("ExampleElement3"));
		}

}
