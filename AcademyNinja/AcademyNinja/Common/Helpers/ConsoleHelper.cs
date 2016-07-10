namespace AcademyNinja.Common.ConsoleHelpers
{
    using System;

    using GameObjects;
    using GameObjects.Courses;

    internal static class ConsoleHelper
    {
        public static string[][] GetFigureDrawing(Type figureType)
        {
            string[][] figureDrawing = null;
            if (figureType == typeof(CSharpCourse))
            {
                figureDrawing = new[]{
                    new[] { "#", "#", "#"," ", "#", "#", "#"," ", "#", " ", "#" },
                    new[] { "|", " ", " "," ", " ", "\\", " "," ","#", "#", "#" },
                    new[] { "#", "#", "#"," ", "#", "#", "#", " ", "#", " ", "#" }
                };
            }
            else if (figureType == typeof(CssCourse))
            {
                figureDrawing = new[]{
                    new[] { "#", "#", "#"," ", "#", "#", "#"," ", "#", "#", "#" },
                    new[] { "|", " ", " "," ", " ", "\\", " "," "," ", "\\", " " },
                    new[] { "#", "#", "#"," ", "#", "#", "#", " ", "#", "#", "#" }
                };
            }
            else if (figureType == typeof(HtmlCourse))
            {
                figureDrawing = new[]{
                    new[] { "#", " ", "#", " ", "#", "#", "#", " ", "#", "  ", "#" },
                    new[] { "#", "#", "#", " ", " ", "#", " ", " ", "#", "\\/", "#" },
                    new[] { "#", " ", "#", " ", " ", "#", " ", " ", "#", " ", " #" }
                };
            }
            else if (figureType == typeof(JavaScriptCourse))
            {
                figureDrawing = new[] {
                    new[] { "#", "#", "#", " ", "#", "#", "#", " ", "#", "#", "#" },
                    new[] { " ", " ", "#", " ", " ", "\\", " ", " ", "|", " ", " " },
                    new[] { " ", "#", "#", " ", "#", "#", "#", " ", "#", "#", "#" }
                };
            }
            else if (figureType == typeof(SpecialCourse))
            {
                figureDrawing = new[]{
                    new[] { "#", "#", "#", " ", "#", "#", "#", " ", "#", "#", "#" },
                    new[] { "#", " ", "#", " ", "#", " ", "#", " ", "#", "#", "#" },
                    new[] { "#", "#", "#", " ", "#", "#", "#", " ", "#", " ", " " }
                };
            }
            else if (figureType == typeof(Ninja))
            {
                figureDrawing = new[]{
                    new[] { " 0" },
                    new[] { "/|\\/" },
                    new[] { "/ \\" }
                };

                figureDrawing = new[]{
                    new[] { " ", "0" },
                    new[] { "/|", "\\/" },
                    new[] { "/ \\" }
                };
            }
            else
            {
                throw new ArgumentException("figureType");
            }

            return figureDrawing;
        }
    }
}
