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

        public static string Determination1(this int sender)
        {
            var result = "";

            switch (sender)
            {
                case < 0:
                    result = "Less than or equal to 0";
                    break;
                case > 0 and <= 10:
                    result = "More than 0 but less than or equal to 10";
                    break;
                default:
                    result = "More than 10";
                    break;
            }

            return result;
        }
        public static string DeterminationEx(this int sender) => sender switch
            {
                < 0 => "Less than or equal to 0",
                > 0 and <= 10 => "More than 0 but less than or equal to 10",
                _ => "More than 10"
            };
    
        public static string Determination2(this int sender)
        {
            var result = sender switch
            {
                < 0 => "Less than or equal to 0",
                > 0 and <= 10 => "More than 0 but less than or equal to 10",
                _ => "More than 10"
            };

            return result;
        }

        public static string Determination3(this int sender)
        {
            var result = sender switch
            {
                1 or 2 or 3 => "one two or three",
                4 => "four",
                _ => "More than four"
            };

            return result;
        }
        public static string DeterminationConventional(this int sender)
        {
            var result = "";
            
            if (sender < 0)
            {
                result = "Less than or equal to 0";
            }else if (sender > 0 && sender <= 10)
            {
                result = "More than 0 but less than or equal to 10";
            }
            else
            {
                result = "More than 10";
            }

            return result;
        }
    }
}