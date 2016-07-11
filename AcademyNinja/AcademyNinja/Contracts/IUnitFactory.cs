namespace AcademyNinja.Contracts
{
    using Common;

    internal interface IUnitFactory
    {
        ICourse CreateCourse(CourseType type);

        INinja CreateNinja();
    }
}
