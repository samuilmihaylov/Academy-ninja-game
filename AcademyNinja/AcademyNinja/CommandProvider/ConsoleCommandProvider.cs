namespace AcademyNinja.CommandProvider
{
    using System;

    using Common;

    internal delegate void KeyPressedEventHandler(object sender, KeyPressEventArgs args);

    internal class ConsoleCommandProvider : ICommandProvider
    {
        public event KeyPressedEventHandler KeyPressed;

        public void ListenForKeyPress()
        {
            if (Console.KeyAvailable)
            {

            }
        }

        private void OnKeyPressed(KeyPressEventArgs args)
        {
            // If at least one method is attached.
            if (this.KeyPressed != null)
            {
                this.KeyPressed.Invoke(this, args);
            }
        }
    }
}
