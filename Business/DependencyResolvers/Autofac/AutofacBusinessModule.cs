using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ICarService>().As<CarManager>().SingleInstance();
            builder.RegisterType<ICarDal>().As<EfCarRepository>().SingleInstance();

            builder.RegisterType<IBrandService>().As<BrandManager>().SingleInstance();
            builder.RegisterType<IBrandDal>().As<EfBrandRepository>().SingleInstance();

            builder.RegisterType<IColorService>().As<ColorManager>().SingleInstance();
            builder.RegisterType<IColorDal>().As<EfColorRepository>().SingleInstance();

            builder.RegisterType<ICustomerService>().As<CustomerManager>().SingleInstance();
            builder.RegisterType<ICustomerDal>().As<EfCustomerRepository>().SingleInstance();

            builder.RegisterType<IRentalService>().As<RentalManager>().SingleInstance();
            builder.RegisterType<IRentalDal>().As<EfRentalRepository>().SingleInstance();

            builder.RegisterType<IUserService>().As<UserManager>().SingleInstance();
            builder.RegisterType<IUserDal>().As<EfUserRepository>().SingleInstance(); ;

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).
                AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}


