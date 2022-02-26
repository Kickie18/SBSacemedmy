using SBSacemedmy.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSacemedmy.Business
{
   public interface ISbsService
    {
        Task<ServiceResponse<List<Order>>> GetallPlayers();
        Task<ServiceResponse<List<Order>>> AddPlayers(Order order);
    }
}
