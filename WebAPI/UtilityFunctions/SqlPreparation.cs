namespace WebAPI.UtilityFunctions
{
    public class SqlPreparation
    {
     /// <summary>
     /// Checks if the value can be converted to the needed typ
     /// </summary>
     /// <param name="column"></param>
     /// <param name="value"></param>
     /// <param name="convertedValue">value covereted to the needed type for sql search.
     /// id,firstname,lastname and email will be convereted to string to make use of Like in the sql search</param>
     /// <returns>returns true if it succeeds in doing so else, it returns false</returns>
        public static bool VerifyType(string column, string value, out dynamic convertedValue)
        {
            bool success;
            switch (column.ToLower())
            {
                case "id":
                    int intOutParam;
                    success = int.TryParse(value, out intOutParam);
                    convertedValue = value + "%";
                    break;
                 
                case "firstname":
                case "email":
                case "lastname":
                    success = true;
                    convertedValue = value + "%";
                    break;

                case "dateofbirth":
                    DateTime outParam;
                    success = DateTime.TryParse(value, out outParam);
                    convertedValue = outParam;
                    break;

                case "currentlyemployed":
                    bool convertedBool;
                    success = bool.TryParse(value, out convertedBool);
                    convertedValue = convertedBool;
                    break;

                default:
                    convertedValue = "";
                    return false;
            }

            return success;
        }
        /// <summary>
        /// based on the column it will choose the appropriate querystring
        /// </summary>
        /// <param name="column"></param>
        /// <returns>returns the string</returns>
        public static string FindAppropriateQueryString(string column)
        {
            string queryString;
            switch (column.ToLower())
            {
                case "id":
                    queryString = $"SELECT * FROM public.employees where cast({column} as text) LIKE @value order by id ASC;";
                    break;

                case "firstname":
                case "email":
                case "lastname":
                    queryString = $"SELECT * FROM public.employees where lower({column}) LIKE lower(@value) order by id ASC;";
                    break;

                case "dateofbirth":
                    queryString = $"SELECT * FROM public.employees where {column} = @value order by id ASC;";
                    break;

                case "currentlyemployed":
                    queryString = $"SELECT * FROM public.employees where {column} = @value order by id ASC;";
                    break;

                default:
                    return "";
            }
            return queryString;
        }
    }
}
