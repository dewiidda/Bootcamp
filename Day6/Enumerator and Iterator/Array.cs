using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enumerator_and_Iterator
{
    public class Array
    {
	string[] blackPink = new string[]{
		"Jennie",
		"Fadil",
		"Jisoo",
		"Lisa"
	};
	
	blackPink[1].Dump();
	blackPink[1] = "Rizky";
	foreach (string member in blackPink)
	{
		member.Dump();
	}
}

    }
}