using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.decorators;

namespace Decorator
{
    class Program
    {
        private static Component _window;
        private static Component _textView;


        static void Main(string[] args)
        {
            bool showBorder = true;

            if (showBorder)
            {
                _window = new BorderDecorator(new Window());
                _textView = new BorderDecorator(new TestView());
            }
            else
            {
                _textView = new TestView();
                _window = new Window();
            }

            _textView.Draw();
            _window.Draw();

            Component window = new Window();
            window.Draw();

            Component windowWithBorder =new BorderDecorator(new Window());

            windowWithBorder.Draw();

            Component textView = new BorderDecorator(new ColorDecorator(new TestView()));

            textView.Draw();
        }
    }
}
