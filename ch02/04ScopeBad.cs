using System;

namespace Wrox.ProCShar.Basics
{
	public class ScopeTestBad
	{
		public static int Main()
		{
			int j = 20;
			for ( int i = 0; i < 10; i++ )
			{
				int j = 30; // Cant't do this-j is still in scope
				Console.WriteLine( j + i );
			}
			return 0;	
		}		
	}
}