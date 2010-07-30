using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.infrastructure.containers.custom
{
    class IDBConnectionDependencyFactory:DependencyFactory
    {
        public object create()
        {
            return new SqlConnection();
        }
    }
}
