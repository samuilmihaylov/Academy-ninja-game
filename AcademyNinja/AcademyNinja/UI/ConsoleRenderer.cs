namespace AcademyNinja.UI
{
    using System;
    using System.Collections.Generic;

    using AcademyNinja.Engine.Contracts;

    internal class ConsoleRenderer : IGameRenderer
    {
        public void DrawGameContext(IGameContext gameContext)
        {
            var courses = gameContext.Courses;

        }

        private void DrawUnits(ICollection<IBoundable> courses)
        {
            throw new NotImplementedException();
        }

        private void DrawSingleUnit(IBoundable unit)
        {
            throw new NotImplementedException();
        }
    }
}
