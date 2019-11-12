using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funq;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.Data;

namespace Server
{
    public class AppHost : AppSelfHostBase
    {
        public AppHost()
          : base("HttpListener Self-Host", typeof(DataService).Assembly) { }

        public override void Configure(Funq.Container container) 
        {
            SetConfig(new HostConfig { DebugMode = true });

            container.Register<IDbConnectionFactory>(c =>
            new OrmLiteConnectionFactory(":memory:", SqliteDialect.Provider));
        }
    }
}
