using ExercResolvidoMetodosAbstratos.Enums;

namespace ExercResolvidoMetodosAbstratos.Entities
{
    class Rectangle : Shape // quando se tem um metodo abstreto, você é obrigado a implementar ele
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
