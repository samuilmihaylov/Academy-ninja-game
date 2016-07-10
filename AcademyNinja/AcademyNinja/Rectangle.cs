namespace AcademyNinja
{
    internal class Rectangle : IBound
    {
        public Rectangle(int width, int heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }

        public Rectangle(int width, int heigth, Position position) : this(width, heigth)
        {
            this.Position = position;
        }

        public int Height { get; private set; }

        public int Width { get; private set; }

        public Position Position { get; private set; }
    }
}
