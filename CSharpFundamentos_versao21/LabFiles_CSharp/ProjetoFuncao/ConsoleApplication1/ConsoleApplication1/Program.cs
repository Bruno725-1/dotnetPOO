using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Vector v = new Vector();
				
		    v.add("one");
		    v.add("second");
		    v.add("3rd");
		    v.add(new Integer(4));
		    v.add(new Float(5.0F));
		    v.add("second"); // duplicate, is added
		    v.add(new Integer(4)); // duplicate, is added

            Console.ReadKey();

        }
    }
}
