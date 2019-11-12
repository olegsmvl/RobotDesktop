using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Server
{
    [Route("/data")]
    public class Data : IReturn<DataResponse>
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Values { get; set; }
    }

    public class DataResponse
    {
        public string Result { get; set; }
    }
}
