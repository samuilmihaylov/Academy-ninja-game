namespace AcademyNinja.UI
{
    using System;
    using System.Collections.Generic;

    using Common.ConsoleHelpers;
    using Contracts;
    using Common;

    internal class ConsoleRenderer : IGameRenderer
    {
        public ConsoleRenderer()
        {
            Console.SetWindowSize(Constants.WindowWidth, Constants.WindowHeigth);
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        public void DrawGameContext(IGameContext gameContext)
        {
            this.DrawUnits(gameContext.Courses);
            this.DrawSingleUnit(gameContext.Player);
        }

        private void DrawUnits(IEnumerable<IEnumerable<IBoundable>> courses)
        {
            foreach (var row in courses)
            {
                foreach (var item in row)
                {
                    this.DrawSingleUnit(item);
                }
            }
        }

        private void DrawSingleUnit(IBoundable unit)
        {
            Type unitType = unit.GetType();
            var unitRepresentation = ConsoleHelper.GetFigureDrawing(unitType);
            int xPosition = unit.Bound.Position.X;
            int yPosition = unit.Bound.Position.Y;
            foreach (var row in unitRepresentation)
            {
                Console.SetCursorPosition(xPosition, yPosition++);
                foreach (var symbol in row)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }
    }
}
