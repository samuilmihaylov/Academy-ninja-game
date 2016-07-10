namespace AcademyNinja.Common.ConsoleHelpers
{
    using System;
    using GameObjects.Courses;
    using GameObjects;
    internal static class ConsoleHelper
    {
        public static string[][] GetFigureMatrix(Type figureType)
        {
            throw new NotImplementedException("GetFigureMatrix");

            if (figureType == typeof(CSharpCourse))
            {

                string[][] csharp = {
                new[] { "#", "#", "#"," ", "#", "#", "#"," ", "#", " ", "#"},
                new[] { "|", " ", " "," ", " ", "\\", " "," ","#", "#", "#" },
                new[] { "#", "#", "#"," ", "#", "#", "#", " ", "#", " ", "#"}
            };

                return csharp;
            }
            else if (figureType == typeof(CSSCourse))
            {
                string[][] css = {
                new[] { "#", "#", "#"," ", "#", "#", "#"," ", "#", "#", "#"},
                new[] { "|", " ", " "," ", " ", "\\", " "," "," ", "\\", " " },
                new[] { "#", "#", "#"," ", "#", "#", "#", " ", "#", "#", "#"}
            };

                return css;
            }
            else if (figureType == typeof(HtmlCourse))
            {
                string[][] html = {
                new[] { "#", " ", "#"," ", "#", "#", "#"," ", "#", "  ", "#" },
                new[] { "#", "#", "#"," ", " ", "#", " "," ", "#", "\\/", "#" },
                new[] { "#", " ", "#"," ", " ", "#", " ", " ", "#", " ", " #" }
            };

                return html;
            }
            else if (figureType == typeof(JavaScriptCourse))
            {
                string[][] js = {
                new[] { "#", "#", "#"," ", "#", "#", "#"," ",  "#", "#", "#",},
                new[] { " ", " ", "#"," ", " ", "\\", " "," ", "|", " ", " ",},
                new[] { " ", "#", "#", " ", "#", "#", "#", " ","#", "#", "#",}
            };

                return js;
            }
            else if (figureType == typeof(SpecialCourse))
            {
                string[][] oop = {
                new[] { "#", "#", "#"," ", "#", "#", "#"," ", "#", "#", "#",},
                new[] { "#", " ", "#"," ", "#", " ", "#"," ", "#", "#", "#",},
                new[] { "#", "#", "#"," ", "#", "#", "#", " ","#", " ", " ",}
            };

                return oop;
            }
            else if (figureType == typeof(Ninja))
            {
                string[][] ninja = {
                new[] {" 0"},
                new[] {"/|\\/"},
                new[] {"/ \\"}
            };

                return ninja;
            }
        }
    }
}
