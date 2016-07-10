namespace AcademyNinja.Engine
{
    using AcademyNinja.Engine.Contracts;

    internal interface IGameRenderer
    {
        void RenderGameContext(IGameContext gameContext);
    }
}