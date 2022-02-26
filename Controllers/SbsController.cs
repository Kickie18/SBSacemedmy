using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBSacemedmy.Business;
using SBSacemedmy.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSacemedmy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SbsController : ControllerBase
    {
        private readonly ISbsService _SbsService;
        public SbsController(ISbsService sbsService)
        {
            _SbsService = sbsService;
        }

        [HttpGet("GetAllPlayers")]
       public async Task<ServiceResponse<List<Order>>> GetallPlayer()
        {
            return await _SbsService.GetallPlayers();
        }

        [HttpPost]
        public async Task<ServiceResponse<List<Order>>> AddPlayers(Order order)
        {
            return await _SbsService.AddPlayers(order);
        }

    }
}
