namespace AcademyNinja.Factories
{
    using System;

    using Common;
    using GameObjects.Courses;
    using Contracts;

    internal class CourseFactory : ICourseFactory
    {
        private const string InvalidCourseErrorMesssage = "Course {0} does not exists!";

        public ICourse CreateCourse(CourseType type)
        {
            var bounds = new Rectangle(Constants.CourseDrawingWidth, Constants.CourseDrawingHeigth);
            switch (type)
            {
                case CourseType.HTML:
                    return new HtmlCourse(bounds);
                case CourseType.CSharp:
                    return new CSharpCourse(bounds);
                case CourseType.CSS:
                    return new CssCourse(bounds);
                case CourseType.JavaScript:
                    return new JavaScriptCourse(bounds);
                default:
                    throw new ArgumentException(string.Format(InvalidCourseErrorMesssage, type));
            }
        }
    }
}
