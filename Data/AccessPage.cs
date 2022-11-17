using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace team3.Data
{
    /// <summary>
    /// This class handles the entry text box on the Index.razor page
    /// It only consists of a string and essentially works as a validator
    /// For now the the only requirement for the access code is that it is a string of 10 digits (too match a standard phone number)
    /// However, the functionality for checking these codes against the access codes held by the hunt in the database is currently in progress
    /// </summary>
    public class AccessPage
    {
        Regex rx = new Regex(@"\d{10}");                                                        //The regular expression that access codes are checked against
        [Required(ErrorMessage = "You must enter your phone number!!")]                           //Not really sure what this does tbh, but they had it in the code i stole
        [RegularExpression(@"\d{10}", ErrorMessage = "Must enter a valid phone number!!")]        //This requirement checks the string that is pulled from the text box against the regular expression
        public string accessCode { get; set; }                                                 //The string pulled from the textbox

        /// <summary>
        /// Constructor for the AccessPage class
        /// Initializes the accessCode variable to an empty string and that's it for now.
        /// </summary>
        public AccessPage()
        {
            accessCode = "";
        }

    }
}
