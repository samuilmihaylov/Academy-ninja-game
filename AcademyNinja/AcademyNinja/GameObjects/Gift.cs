namespace AcademyNinja.GameObjects
{
    using AcademyNinja.GameObjects.Contracts;

    internal abstract class Gift : IGift
    {
        public abstract void Apply(INinja ninja);
    }
}
