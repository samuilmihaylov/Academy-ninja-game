namespace AcademyNinja.Console
{
    using System;

    using Common;
    using Contracts;

    internal class ConsoleCommandProvider : ICommandProvider
    {
        public event KeyPressedEventHandler KeyPressed;

        public void ListenForKeyPress()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey().Key;
                var keyArgs = new KeyPressEventArgs();
                if (key == ConsoleKey.LeftArrow)
                {
                    keyArgs.KeyType = KeyType.Left;
                    this.OnKeyPressed(keyArgs);
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    keyArgs.KeyType = KeyType.Rigth;
                    this.OnKeyPressed(keyArgs);
                }
                else if (key == ConsoleKey.Spacebar)
                {
                    keyArgs.KeyType = KeyType.Space;
                    this.OnKeyPressed(keyArgs);
                }
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
