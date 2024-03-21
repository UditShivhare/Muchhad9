using System.ComponentModel.DataAnnotations;

namespace LoginApiN.Models
{
    public class SignInModel
    {
         
        public string Email {  get; set; }

        public string Password { get; set; }
    }
}
