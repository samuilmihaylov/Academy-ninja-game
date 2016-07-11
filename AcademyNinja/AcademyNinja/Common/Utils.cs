namespace AcademyNinja.Common
{
    internal static class Utils
    {
        public static int CalculateCentralPosition(int totalSize, int figureSize)
        {
            return (totalSize - figureSize) / 2;
        }
    }
}
