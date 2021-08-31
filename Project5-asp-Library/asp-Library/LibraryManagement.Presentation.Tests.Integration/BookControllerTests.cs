using asp_Library;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using Xunit;
using RESTFulSense.Clients;
using LibraryManagement.Domain.BookAgg;
using System.Collections.Generic;

namespace LibraryManagement.Presentation.Tests.Integration
{
    public class BookControllerTests
    {
        [Fact]
        public async void Should_Get_All_Courses()
        {

            // arrange
            var applicationFactory = new WebApplicationFactory<Startup>();
            var httpClient = applicationFactory.CreateClient();
            var restclient = new RESTFulApiFactoryClient(httpClient);

            // Act
            var actual = await restclient.GetContentAsync<List<Book>>("/api/Book/GetAllBook");



            // Assert


        }
    }
}
