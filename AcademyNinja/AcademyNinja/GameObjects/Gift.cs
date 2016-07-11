namespace AcademyNinja.GameObjects
{
    using AcademyNinja.Contracts;

    internal abstract class Gift : IGift
    {
        public abstract void Apply(INinja ninja);
    }
}
