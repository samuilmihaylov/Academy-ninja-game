namespace AcademyNinja.Contracts
{
    using Common;

    internal interface ICourseFactory
    {
        ICourse CreateCourse(CourseType type);
    }
}
