namespace AcademyNinja.UI
{
    using System;
    using System.Collections.Generic;

    using AcademyNinja.Engine.Contracts;
    using Common.ConsoleHelpers;

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
            var player = gameContext.Player;
            this.DrawSingleUnit(player);
        }

        private void DrawUnits(ICollection<IBoundable> courses)
        {
            throw new NotImplementedException();
        }

        private void DrawSingleUnit(IBoundable unit)
        {
            Type unitType = unit.GetType();
            string[][] unitRepresentation = ConsoleHelper.GetFigureMatrix(unitType);
            foreach (var row in unitRepresentation)
            {
                foreach (var symbol in row)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
        }
    }
}
