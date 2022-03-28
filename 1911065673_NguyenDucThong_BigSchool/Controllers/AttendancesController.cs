using _1911065673_NguyenDucThong_BigSchool.DTOs;
using _1911065673_NguyenDucThong_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911065673_NguyenDucThong_BigSchool.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
      
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attdanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attdanceDto.CourseId))
                return BadRequest("The Attendance Alrealy exists !");
            var attendance = new Attendance
            {
                CourseId = attdanceDto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
