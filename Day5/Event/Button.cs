using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
    public class Button
    {
        public event ButtonClickedEventHandler Clicked;

        public void OnClicked()
        {
            if (Clicked != null)
            {
                Clicked(this, EventArgs.Empty);
            }
        }
    }
}