using Hostel_Management_System.Data;
using Hostel_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hostel_Management_System.Pages.Admin
{
    public class AddCoursesModel : PageModel
    {
        DataDbContext db;
        public Courses Courses { get; set; }
        public AddCoursesModel(DataDbContext _db)
        {
            db = _db;
        }

        [HttpPost]
        public IActionResult OnPost(Courses courses)
        {
            db.courses.Add(courses);
            db.SaveChanges();
            return RedirectToPage("Course");
        }
    }
}
