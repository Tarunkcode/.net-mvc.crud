using Card.Api.Models;
using CardRecord.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Card.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : Controller
    {
        private readonly CardsDbContext cardDbContext;

        public CardController(CardsDbContext cardDbContext)
        {
            this.cardDbContext = cardDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
           var result= await cardDbContext.modals.ToListAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetOneCard")]
        public async Task<IActionResult> GetOneCard([FromRoute] Guid id)
        {
            var result = await cardDbContext.modals.FirstOrDefaultAsync(x => x.id == id);
            if(result != null)
            {
            return Ok(result);

            }
            else
            {
                return NotFound("Card Not Found");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] modal card)
        {
            card.id = Guid.NewGuid();
            await cardDbContext.modals.AddAsync(card);
            await cardDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOneCard), card.id, card);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateCard([FromRoute]Guid id, [FromBody] modal card)
        {
            var entity = await cardDbContext.modals.FirstOrDefaultAsync(x => x.id == id);
            if(entity != null)
            {
                entity.CardHolderName = card.CardHolderName;
                entity.CardNumber = card.CardNumber;
                entity.CVV = card.CVV;
                entity.ExpMon = card.ExpMon;
                entity.ExpYear = card.ExpYear;
                await cardDbContext.SaveChangesAsync();
                return Ok(entity);
            }
            else
            {
                return NotFound("Card Not Found");
            }
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteCard([FromRoute] Guid id)
        {
            var entity = await cardDbContext.modals.FirstOrDefaultAsync(x => x.id == id);
            if(entity!= null)
            {
                var result = cardDbContext.Remove(entity);
                await cardDbContext.SaveChangesAsync();
                return Ok(result);
            }
            else
            {
                return NotFound("Not Found");
            }
        }

    }
}
