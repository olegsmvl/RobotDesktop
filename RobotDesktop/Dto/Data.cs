using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Route("/data/{Values}")]
    public class Data : IReturn<DataResponse>
    {
        public int Id { get; set; }
        public string Values { get; set; }
    }

    public class DataResponse
    {
        public string Result { get; set; }
    }
}
