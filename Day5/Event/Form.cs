using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public class Form
    {
        public void HandleButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("Button was clicked!");
        }
    }
}