namespace AcademyNinja.UI
{
    using System;
    using System.Collections.Generic;

    using AcademyNinja.Engine.Contracts;
    using Common.ConsoleHelpers;
    using Contracts;

    internal class ConsoleRenderer : IGameRenderer
    {
        private const int ConsoleWidth = 150;
        private const int ConsoleHeigth = 40;

        public ConsoleRenderer()
        {
            Console.SetWindowSize(ConsoleWidth, ConsoleHeigth);
        }

        public void DrawGameContext(IGameContext gameContext)
        {
            this.DrawUnits(gameContext.Courses);
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
