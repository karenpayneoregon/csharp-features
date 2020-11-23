namespace Relational_Pattern_Matching
{
    public static class LanguageExtensions
    {
        /// <summary>
        /// use Switch expression to determine where a int value falls
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string Determination(this int sender) => sender switch
        {
            <= 0 => "Less than or equal to 0",
            > 0 and <= 10 => "More than 0 but less than or equal to 10",
            _ => "More than 10"
        };
    }
}