using System;

namespace Decorator.decorators
{
    public class ColorDecorator : Decorator
    {
        public ColorDecorator(Component component) : base(component) { }

        public override void afterDraw()
        {
            Console.WriteLine("... added color");
        }
    }
}