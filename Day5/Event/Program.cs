using Event;
internal class Program
{
    private static void Main()
    {
        Form form = new Form();
		Button button = new Button();
		button.Clicked += form.HandleButtonClick;
		button.OnClicked();

        SecuritySystem security = new();
		Door door = new();
		door.Opened += security.OnDoorOpened;
		door.Open();
    }
}