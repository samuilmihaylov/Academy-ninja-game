namespace AcademyNinja.UI
{
    using AcademyNinja.Engine.Contracts;

    internal interface IGameRenderer
    {
        void RenderGameContext(IGameContext gameContext);
    }
}