using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesLabA1.Models;

namespace RazorPagesLabA1.Pages
{
    public class CustomerFormModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public Customer customerInfor { get; set; }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "Information is OK";
                ModelState.Clear();
            }
            else
            {
                Message = "Error on input data";
            }
        }
    }
}
