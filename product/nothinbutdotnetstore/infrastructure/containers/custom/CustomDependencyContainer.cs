using System;

namespace nothinbutdotnetstore.infrastructure.containers.custom
{
    public class CustomDependencyContainer : DependencyContainer
    {
        private DependencyFactories factory;

        public CustomDependencyContainer(DependencyFactories factory)
        {
            this.factory = factory;
        }

        public Dependency an<Dependency>()
        {
            return (Dependency) factory.get_dependency_factory_for(typeof(Dependency)).create();
        }
    }
}