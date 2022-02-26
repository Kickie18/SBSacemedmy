using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSacemedmy.DataModel
{
    public class ServiceResponse<T>
    {
        public T Datas { get; set; }
        public string Response { get; set; }
        public string Message { get; set; }
    }
}
