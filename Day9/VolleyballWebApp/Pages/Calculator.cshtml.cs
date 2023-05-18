using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VolleyballWebApp.Pages
{
    public class CalculatorModel : PageModel
    {
        public int Result { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var form=Request.Form;

            //First 
/*            int? number1=null;
            int? number2 = null;
            try
            {
                number1 = Convert.ToInt32(form["Number1"]);
                number2 = Convert.ToInt32(form["Number2"]);
            }
            catch (Exception)
            {

            }
         //   if number !null number2!null then .result =...
*/

            //Good practice
            bool r1 = int.TryParse(form["Number1"], out int number1); //good practise if we are not sure of what was inserted
           bool r2= int.TryParse(form["Number2"], out int number2);
            if (r1 && r2)
            {
                // int result = number1 + number2;
                Result = number1 + number2; //propertie
            }
            else
            {
                //handle problem
            }
        }
    }
}
