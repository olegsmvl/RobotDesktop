using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System.IO;

namespace Server
{
    public class DataService : Service
    {
        public object Any(Data request)
        {
            return new DataResponse { Result = $"Hello, {request.Values}!" };
        }

        public object Post(Data request)
        {
            var dbFactory = new OrmLiteConnectionFactory(Path.Combine(Directory.GetCurrentDirectory(), "databaseData.sqlite"), SqliteDialect.Provider) ;
            var db = dbFactory.Open();
            db.CreateTable<Data>();

            db.Insert(request);

            return new DataResponse { Result = $"Hello, {request.Values}!" };
        }
    }
}
