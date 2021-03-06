using System;

namespace Euler
{
	public partial class Solutions
	{
	  // A "how many routes in the grid" problem.
	  // Pascal's Triangle will help us here.
	  // If we calculate out Pascal's Triangle for a given grid (n x n),
	  // we'll see that the number of paths can be seen at row 2n, column n.
	  // So all we need to do is calculate up to that and we're good.
	  public static void P015()
	  {
	    int gWide = 20;
	    int gTall = 20;
	    
	    long sVal = 1;
	    
	    for (int i = 1; i <= gTall; i++)
	      sVal = (sVal * ((gWide * 2) + 1 - i)) / i;
	      
	    Console.WriteLine(sVal.ToString());
	  }
	}
}
