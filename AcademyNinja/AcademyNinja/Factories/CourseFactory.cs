namespace AcademyNinja.Factories
{
    using System;

    using AcademyNinja.GameObjects.Contracts;
    using Common;
    using GameObjects.Courses;

    internal class CourseFactory : ICourseFactory
    {
        private const string InvalidCourseErrorMesssage = "Course {0} does not exists!";

        public ICourse CreateCourse(CourseType type)
        {
            switch (type)
            {
                case CourseType.HTML:
                    return new HtmlCourse();
                case CourseType.CSharp:
                    return new CSharpCourse();
                case CourseType.CSS:
                    return new CSSCourse();
                case CourseType.JavaScript:
                    return new JavaScriptCourse();
                default:
                    throw new ArgumentException(string.Format(InvalidCourseErrorMesssage, type));
            }
        }
    }
}
