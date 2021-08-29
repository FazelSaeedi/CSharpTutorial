using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagement.Application.Contract.Book;
using LibraryManagement.Application;
using LibraryManagement.Domain.BookAgg;
using LibraryManagement.Infrastructure.EFCore.Repository;
using LibraryManagement.Infrastructure.EFCore;
using LibraryManagement.Application.Contract.User;
using LibraryManagement.Domain.UserAgg;
using LibraryManagement.Application.Contract.Shelf;
using LibraryManagement.Domain.ShelfAgg;
using LibraryManagement.Domain.BookshelfAgg;
using LibraryManagement.Application.Contract.BookShelf;

namespace LibraryManagement.Configuration
{

    public class LibraryManagementBoostrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {

            services.AddTransient<IBookApplication, BookApplication>();
            services.AddTransient<IBookRepository, BookRepository>();


            services.AddTransient<IUserApplication, UserApplication>();
            services.AddTransient<IUserRepository, UserRepository>();


            services.AddTransient<IShelfApplication, ShelfApplication>();
            services.AddTransient<IShelfRepository, ShelfRepository>();


            services.AddTransient<IBookShelfApplication , BookShelfApplication>();
            services.AddTransient<IBookshelfRepository , BookShelfRepository>();

            services.AddDbContext<EFContext>(x => x.UseSqlServer(connectionString));

        }

    }

}
