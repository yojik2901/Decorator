using System;

namespace Decorator
{
    public class TestView : Component
    {
        public void Draw()
        {
            Console.WriteLine("Draw textview");
        }
    }
}