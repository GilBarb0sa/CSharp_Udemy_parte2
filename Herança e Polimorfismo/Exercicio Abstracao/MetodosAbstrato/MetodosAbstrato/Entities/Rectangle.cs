using MetodosAbstrato.Entities.Enums;

namespace MetodosAbstrato.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area() 
        //Para implementar uma classe ou metodo abstrato, tem que ser override e construir o metodo aqui tbm
        {
            return Width * Height;
        }
    }
}
