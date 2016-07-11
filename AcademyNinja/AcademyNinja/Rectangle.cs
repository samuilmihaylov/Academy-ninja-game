using AcademyNinja.Common;
using AcademyNinja.Common.Validator;

namespace AcademyNinja
{
    internal class Rectangle : IBound
    {
        private int height;
        private int width;
        private Position position;

        public Rectangle(int width, int heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }

        public Rectangle(int width, int heigth, Position position) : this(width, heigth)
        {
            this.Position = position;
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                Validator.ValidateIfZero(value, string.Format(Constants.ValueCannotBeZero, "Height"));

                this.height = value;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                Validator.ValidateIfZero(value, string.Format(Constants.ValueCannotBeZero, "Width"));

                this.width = value;
            }
        }

        public Position Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
    }
}
