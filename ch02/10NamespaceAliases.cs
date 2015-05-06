using System;
using Introduction = Wrox.ProCSharp.Basics;
class Test
{
	public static int Main()
	{
		Introduction::NamespaceExample NSEx =
			new Introduction::NamespaceExample();
		
		Console.WriteLine( NSEx.GetNamespace() );
		return 0;
	}	
}

namespace Wrox.ProCSharp.Basics
{
	class NamespaceExample
	{
		public string GetNamespace()
		{
			return this.GetType().Namespace;	
		}
	}
}