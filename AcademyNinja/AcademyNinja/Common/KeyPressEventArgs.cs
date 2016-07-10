namespace AcademyNinja.Common
{
    using System;

    internal class KeyPressEventArgs : EventArgs
    {
        public KeyType KeyType { get; set; }
    }
}
