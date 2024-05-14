using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public class SecuritySystem
    {
        public void OnDoorOpened(object sender, EventArgs e)
        {
            Console.WriteLine("Security system is activated.");
        }
    }
}