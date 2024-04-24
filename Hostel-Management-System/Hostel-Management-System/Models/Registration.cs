using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostel_Management_System.Models
{
    [Table("registration")]
    public class Registration
    {
        [Key]
        public int id { get; set; }
        public int roomno { get; set; }
        public decimal fees { get; set; }
        public string foodstatus { get; set; }
        public DateTime Start_Date { get; set; }
        public int duration { get; set; }
        public string Department { get; set; }
        public string regno { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string contactno { get; set; }
        public string emailid { get; set; }
        public string guardianName { get; set; }
        public string guardianRelation { get; set; }
        public string guardianContactno { get; set; }
        public string corresCIty { get; set; }
        public string pmntAddress { get; set; }
        public string pmntCity { get; set; }
        public string pmnatetState { get; set; }
        public DateTime posting_date { get; set; }
    }
}
