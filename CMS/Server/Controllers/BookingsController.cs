using CMS.Server.IRepository;
using CMS.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMS.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/bookings
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var bookings = await _unitOfWork.Bookings.GetAll();
            return Ok(bookings);
        }

        // GET: api/bookings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        // PUT: api/bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(booking);

            try
            {
                await _unitOfWork.Save(this.HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            booking.SetDateCreated(); /*< --not change when added to db*/

            // but this work
            //booking.UpdatedBy = booking.CreatedBy = HttpContext.User.Identity.Name;
            //booking.DateUpdated = booking.DateCreated = DateTime.Now;

            await _unitOfWork.Bookings.Insert(booking);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        // DELETE: api/bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return booking == null;
        }
    }
}
