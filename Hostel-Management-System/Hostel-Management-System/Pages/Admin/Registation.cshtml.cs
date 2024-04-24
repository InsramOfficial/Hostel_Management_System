using Hostel_Management_System.Data;
using Hostel_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostel_Management_System.Pages.Admin
{
    public class RegistationModel : PageModel
    {
        DataDbContext db;
        public List<Registration> Registations { get; set; }
        public RegistationModel(DataDbContext _db)
        {
            db= _db;
        }

        public void OnGet()
        {
            Registations = db.registations.ToList();
        }
    }
}
