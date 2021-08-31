using FluentAssertions;
using LibraryManagement.Domain.BookAgg;
using LibraryManagement.Infrastructure.EFCore;
using LibraryManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Transactions;
using Xunit;

namespace LibraryManagement.Tests.Integration
{
    public class BookRepositoryTests : IClassFixture<RealDatabaseFixture>
    {
        private readonly BookRepository _bookRepository;

        public BookRepositoryTests(RealDatabaseFixture realDatabaseFixture)
        {
            _bookRepository = new BookRepository(realDatabaseFixture.EFContext);
        }

        [Fact]
        public void BookRepository_Should_Be_Greater_Than_Zero()
        {

            //act
            var courses = _bookRepository.Get();


            //assert
            courses.Should().HaveCountGreaterThan(0);

        }




        [Fact]
        public void BookRepository_Should_CreateCorse()
        {

           // Arrange
            var book = new Book("new Title" , 1349845987352 , 292);


            // Act
            _bookRepository.Create(book);
            _bookRepository.SaveChanges();



           // Assert
           var result = _bookRepository.Get();
           result.Should().Contain(result);
            
               
        } 



    }
}
