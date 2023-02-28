namespace asp_api_assignment
{
    public static class SumStringArray
    {
        /// <summary>
        /// 
        /// Takes a list of string and tries to calculate the sum of the strings converted to decimals.
        /// Numbers with "." in them will be considered a full number. Therefore 1.222 = 1222.
        /// Null numbers will be skipped. Values that failed to be converted will be skipped.
        /// 
        /// </summary>
        /// <param name="values">List of string with possible null values</param>
        /// <returns></returns>
        public static decimal calculateSum(List<string?> values)
        {
            decimal sum = 0;
            for (int index = 0; index < values.Count; index++)
            {
                string value = values[index];
                if (value == null) continue;
                if (value.Contains(".")) value = value.Replace(".", "");
                try
                {
                    decimal convertedValue = decimal.Parse(value, System.Globalization.NumberStyles.Float);
                    sum += convertedValue;
                }
                catch (FormatException) {
                    // No behaviour for inappropriate string formats was provided, so I am simply skipping the value
                    continue;
                } 
            }
            return sum;
        }
    }
}
