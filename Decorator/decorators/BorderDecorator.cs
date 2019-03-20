using System;

namespace Decorator.decorators
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Component component) : base(component) { }

        public override void afterDraw()
        {
            Console.WriteLine("... added border");
        }
    }
}