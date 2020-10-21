using ApiBestPractice.Business.Abstract;
using ApiBestPractice.Business.Concrete;
using ApiBestPractice.DataAccess.Abstract;
using ApiBestPractice.DataAccess.Concrete.EntityFramework;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
        }
    }
}
