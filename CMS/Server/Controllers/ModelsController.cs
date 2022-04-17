using CMS.Server.IRepository;
using CMS.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            var models = await _unitOfWork.Makes.GetAll();
            return Ok(models);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModel(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Models.Update(model);

            try
            {
                await _unitOfWork.Save(this.HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id))
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

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostModel(Model model)
        {
            model.SetDateCreated(); /*< --not change when added to db*/

            // but this work
            //make.UpdatedBy = make.CreatedBy = HttpContext.User.Identity.Name;
            //make.DateUpdated = make.DateCreated = DateTime.Now;

            await _unitOfWork.Models.Insert(model);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetMake", new { id = model.Id }, model);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            return model == null;
        }
    }
}
