using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_build.Model
{
    public static  class ContainerBuilderExtensions
    {
        private static IContainerBuilder RegisterType(
            this IContainerBuilder builder, 
            Type service,
            Type implementation,
            _LifeTime __LifeTime)
        {
            builder.Register(
                new TypeBasedServiceDescriptor()
                {
                    ImplementationType = implementation,
                    ServiceType = service,
                    LifeTime = __LifeTime
                });

            return builder;
        }

        private static IContainerBuilder RegisterFactory(
            this IContainerBuilder builder,
            Type service,
            Func<IScope, object> _factory,
            _LifeTime __LifeTime)
        {
            builder.Register(
                new FactoryBasedServiceDescriptor()
                {
                    factory = _factory,
                    ServiceType = service,
                    LifeTime = __LifeTime
                });

            return builder;
        }


        private static IContainerBuilder RegisterInstance(
            this IContainerBuilder builder,
            Type service,
            object instance
            )
        {
            builder.Register(
                new InstanceBasedServiceDescriptor(service, instance));

            return builder;
        }

        //**************************************************************

        public static IContainerBuilder RegisterSinglton(
            this IContainerBuilder builder,
            Type serviceInterface,
            Type serviceImplementation)
        {
            return builder.RegisterType(serviceInterface, serviceImplementation,_LifeTime.Singlton);
        }

        public static IContainerBuilder RegisterTranscient(
            this IContainerBuilder builder,
            Type serviceInterface,
            Type serviceImplementation)
        {
            return builder.RegisterType(serviceInterface, serviceImplementation, _LifeTime.Transcient);
        }
        public static IContainerBuilder RegisterScoped(
            this IContainerBuilder builder,
            Type serviceInterface,
            Type serviceImplementation)
        {
            return builder.RegisterType(serviceInterface, serviceImplementation, _LifeTime.Scoped);
        }



        // Generic

        public static IContainerBuilder RegisterTranscient<IService, IImplementation>(
            this IContainerBuilder builder) where IImplementation : IService
        {
            return builder.RegisterType(typeof(IService), typeof(IImplementation), _LifeTime.Transcient);
        }

        public static IContainerBuilder RegisterScoped<IService, IImplementation>(
            this IContainerBuilder builder) where IImplementation : IService
        {
            return builder.RegisterType(typeof(IService), typeof(IImplementation), _LifeTime.Scoped);
        }

        public static IContainerBuilder RegisterSinglton<IService, IImplementation>(
        this IContainerBuilder builder) where IImplementation : IService
        {
            return builder.RegisterType(typeof(IService), typeof(IImplementation), _LifeTime.Singlton);
        }

        // FactoryBased

        public static IContainerBuilder RegisterTranscient(
            this IContainerBuilder builder,
            Type service,
            Func<IScope, object> factory)
        {
            return builder.RegisterFactory(service, factory, _LifeTime.Transcient);
        }

        public static IContainerBuilder RegisterTranscient<TService>(
            this IContainerBuilder builder,
            Type service,
            Func<IScope, object> factory)
        {
            return builder.RegisterFactory(
                typeof(TService), 
                s=> factory(s), 
                _LifeTime.Transcient);
        }

        public static IContainerBuilder RegisterScoped(
            this IContainerBuilder builder,
            Type service,
            Func<IScope, object> factory)
        {
            return builder.RegisterFactory(service, factory, _LifeTime.Scoped);
        }

        public static IContainerBuilder RegisterSinglton(
            this IContainerBuilder builder,
            Type service,
            Func<IScope, object> factory)
        {
            return builder.RegisterFactory(service, factory, _LifeTime.Singlton);
        }

        // Instance

        public static IContainerBuilder RegisterSinglton<T>(
            this IContainerBuilder builder,
            Type service,
            object instance)
        {
            return builder.RegisterInstance(typeof(T), instance);
        }

    }
}
