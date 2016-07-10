namespace AcademyNinja.Contracts
{
    using AcademyNinja.Common;

    internal interface ICommandProvider
    {
        event KeyPressedEventHandler KeyPressed;

        void ListenForKeyPress();
    }
}