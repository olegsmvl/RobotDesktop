using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class DataService : Service
    {
        public object Any(Data request)
        {
            return new DataResponse { Result = $"Hello, {request.Values}!" };
        }
    }
}
