using Logger;

namespace UserInterface.UtilityFunctions
{
    public class UiVerification
    {
        /// <summary>
        /// Verifies that the input of the user from the UI conforms to WebAPI specifications
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public static string VerifyInputOfEmpolyee(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            try
            {
                string message;
                if (string.IsNullOrEmpty(firstName) || firstName.Count() > 30)
                {
                    message = $"firstname is either empty or larger than 30 characters";
                }
                else if (string.IsNullOrEmpty(lastName) || lastName.Count() > 30)
                {
                    message = $"lastname is either empty or larger than 30 characters";
                }
                else if (string.IsNullOrEmpty(email) || !email.Contains('@') || email.Count() > 60)
                {
                    message = $"email is either empty, does not contain a @ or larger than 60 characters";
                }
                else if (dateOfBirth == DateTime.MinValue)
                {
                    message = $"date of birth is not a valid date, please choose another";
                }
                else { message = "valid"; }

                return message;
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                throw;
            }

            
        }
    }
}
