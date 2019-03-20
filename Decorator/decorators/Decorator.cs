namespace Decorator.decorators
{
    //класс для всех декораторов, от него будут наследоваться все существующие декораторы
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public abstract void afterDraw();

        public void Draw()
        {
            _component.Draw();
            afterDraw();
        }
    }
}