using System;

namespace Decorator
{
    public class Window : Component
    {
        public void Draw()
        {
            Console.WriteLine("Draw window");
        }
    }
}