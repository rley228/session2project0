using Session2api.Entities;

namespace Session2api.Models
{
    public class StaffModel
    {
        public int IdStaff { get; set; }

        public string? LastName { get; set; }

        public string? FisrtName { get; set; }

        public string? MiddleName { get; set; }

        public string? FIO {  get; set; }

        public DateOnly? Birthday { get; set; }

        public int? IdDivision { get; set; }

        public string? Division { get; set; }

        public string? Position { get; set; }

        public string? Leader { get; set; }

        public string? Assistant { get; set; }

        public string? WorkPhone { get; set; }

        public string? PersonalPhone { get; set; }

        public string? Cabinet { get; set; }

        public string? Email { get; set; }

        public string? OtherInfo { get; set; }

        public StaffModel(Staff staff)
        {
            IdStaff = staff.IdStaff;
            FisrtName = staff.FisrtName;
            MiddleName = staff.MiddleName;
            FIO = $"{staff.LastName} {staff.FisrtName} {staff.MiddleName}";
            Birthday = staff.Birthday;
            LastName = staff.LastName;
            WorkPhone = staff.WorkPhone;
            PersonalPhone = staff.PersonalPhone;
            IdDivision = staff.IdDivision;
            Division = staff.IdDivisionNavigation?.DivName;
            Position = staff.Position;
            Leader = staff.Leader;
            Assistant = staff.Assistant;
            Cabinet = staff.Cabinet;
            Email = staff.Email;
            OtherInfo = staff.OtherInfo;
        }
    }
}
