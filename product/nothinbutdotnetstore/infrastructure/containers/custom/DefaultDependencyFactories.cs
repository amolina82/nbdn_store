using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace nothinbutdotnetstore.infrastructure.containers.custom
{
    public class DefaultDependencyFactories:DependencyFactories
    {
        public DependencyFactory get_dependency_factory_for(Type type)
        {
            if (typeof(Type) == typeof(IDbConnection))
                return new IDBConnectionDependencyFactory();
            return null;
        }
    }
}
