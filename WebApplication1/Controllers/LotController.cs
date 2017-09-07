using Auction.BusinessLogic.IServices;
using Auction.Data.Entities;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class LotController : ApiController
    {
        private readonly ILotService _lotService;
        public LotController(ILotService _lotService)
        {
            this._lotService = _lotService;
        }

        [HttpPost]
        [Route("api/lot/create")]
        public void CreateLot(Lot lot)
        {
            _lotService.CreateLot(lot);
        }
        
        
    }
}
