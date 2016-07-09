namespace AcademyNinja.CommandProvider
{
    using AcademyNinja.Common;

    internal interface ICommandProvider
    {
        void ListenForKeyPress();

        event KeyPressedEventHandler KeyPressed;
    }
}