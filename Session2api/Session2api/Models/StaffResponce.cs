using Session2api.Entities;

namespace Session2api.Models
{
    public class StaffResponce
    {
        public int IdStaff { get; set; }

        public string? LastName { get; set; }

        public string? FisrtName { get; set; }

        public string? MiddleName { get; set; }

        public DateOnly? Birthday { get; set; }

        public int? IdDivision { get; set; }

        public string? Position { get; set; }

        public string? Leader { get; set; }

        public string? Assistant { get; set; }

        public string? WorkPhone { get; set; }

        public string? PersonalPhone { get; set; }

        public string? Cabinet { get; set; }

        public string? Email { get; set; }

        public string? OtherInfo { get; set; }
    }
}
