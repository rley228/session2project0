using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Session2api.Entities;
using Session2api.Models;

namespace Session2api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<StaffModel> GetStaffList()
        {
            using (var db = new DbRoadsRusiaContext())
            {
                var staffList = db.Staff.Include(p => p.IdDivisionNavigation).ToList().ConvertAll(p => new StaffModel(p));
                return staffList;
            }
        }

        [HttpPut]
        public async void PutStaff([FromBody] StaffResponce staff)
        {
            using (var db = new DbRoadsRusiaContext())
            {
                var existingStaff = db.Staff.FirstOrDefault(p => p.IdStaff == staff.IdStaff);

                if (existingStaff != null)
                {
                    var updateStaff = new StaffResponce()
                    {
                        IdStaff = staff.IdStaff,
                        Assistant = staff.Assistant,
                        Email = staff.Email,
                        FisrtName = staff.FisrtName,
                        LastName = staff.LastName,
                        MiddleName = staff.MiddleName,
                        Birthday = staff.Birthday,
                        Cabinet = staff.Cabinet,
                        IdDivision = staff.IdDivision,
                        Position = staff.Position,
                        PersonalPhone = staff.PersonalPhone,
                        WorkPhone = staff.WorkPhone,
                        Leader = staff.Leader, 
                        OtherInfo = staff.OtherInfo,
                    };

                    db.Entry(existingStaff).CurrentValues.SetValues(updateStaff);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
