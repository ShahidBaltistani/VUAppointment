using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appointment.Entities;
using Appointment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment.API.Controllers
{
    [Route("Appointment")]
    //[Route("api/[controller]")]
    [ApiController]
    public class BookAppointmentController : ControllerBase
    {
        // GET: Appointment
        private readonly IBookAppointment I_BookAppointment;
        public BookAppointmentController(IBookAppointment bookAppointment)
        {
            I_BookAppointment = bookAppointment;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var appointments = await I_BookAppointment.GetAll();
            if (appointments.Count() == 0)
                return NotFound("No data found");

            return Ok(appointments);
        }

        // GET: api/BookAppointment/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<BookAppointment> GetById(int id)
        {
            var appointments = await I_BookAppointment.Get(1);
            return appointments;
        }

        // POST: api/BookAppointment
        [HttpPost("create")]
        public async Task<IActionResult>  Post([FromBody] BookAppointment model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var data = await I_BookAppointment.Add(model);
                    return Ok(data);
                }
                catch (Exception)
                {

                    return BadRequest();
                }
            }
            return BadRequest("ModelState is Invalid");
        }

        // PUT: api/BookAppointment/5
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] BookAppointment model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var data =await I_BookAppointment.Update(model);
                    return Ok(data);
                }
                catch (Exception)
                {

                    return BadRequest();
                }
            }
            return BadRequest("ModelState is Invalid");
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a Valid Id");

            var data = await I_BookAppointment.Delete(id);
            return Ok("Deleted");
        }
    }


}
