using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public class Door
    {
        public event EventHandler Opened;
        
        public void Open()
        {
            Console.WriteLine("Door is Opened");
            Opened?.Invoke(this, EventArgs.Empty);
        }
    }
}