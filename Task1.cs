using System;

namespace Test1
{
    public class Task1Event
    {
        public delegate void ButtonClickHandler(object sender, EventArgs e);
        public event ButtonClickHandler ButtonClick;
        public void OnClick() {
            ButtonClick(this, EventArgs.Empty);
        }
    }
    public class Taks1Handle {
        private static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button was clicked!");
        }

        public static void Main()
        {
            Task1Event button = new Task1Event();
            button.ButtonClick += Button_Click;
            button.OnClick();
        }
    }
}
