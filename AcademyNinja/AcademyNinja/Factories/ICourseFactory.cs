namespace AcademyNinja.Factories
{
    using AcademyNinja.GameObjects.Contracts;
    using Common;

    internal interface ICourseFactory
    {
        ICourse CreateCourse(CourseType type);
    }
}
