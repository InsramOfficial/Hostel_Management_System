using Hostel_Management_System.Data;
using Hostel_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hostel_Management_System.Pages.Admin
{
    public class CourseModel : PageModel
    {
        DataDbContext db;
        public List<Courses> Courses { get; set; }
        public CourseModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            Courses = db.courses.ToList();
        }

    }
}
