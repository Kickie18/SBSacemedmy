using SBSacemedmy.DataContext;
using SBSacemedmy.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSacemedmy.Business
{
    public class SbsService : ISbsService
    {
        private readonly DataContextEF _dataContextEF;
        public SbsService(DataContextEF dataContextEF)
        {
            _dataContextEF = dataContextEF;
        }

        public async Task<ServiceResponse<List<Order>>> AddPlayers(Order order)
        {
            Order od = new Order()
            {
                CustomerID = order.CustomerID,
                EmployeeID = order.EmployeeID,
                OrderDate = DateTime.Now,
            };
            _dataContextEF.Orders.Add(od);
            await _dataContextEF.SaveChangesAsync();
            var result = new ServiceResponse<List<Order>>();
            result.Datas = _dataContextEF.Orders.ToList();
            result.Message = "Success";
            return result;

        }

        public async  Task<ServiceResponse<List<Order>>> GetallPlayers()
        {
           var result =  _dataContextEF.Orders.Where(x=>x.CustomerID == 2).ToList();
            var service = new ServiceResponse<List<Order>>();
            service.Datas = result;
            if (result.Any())
            {
                service.Response = "Success";
                service.Message = "Mesaage check";
            }
            else
            {
                service.Response = "Failed";
                service.Message = "Mesaage check";
            }
            return  service;
        }
    }
}
