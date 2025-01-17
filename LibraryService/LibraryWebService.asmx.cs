﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using LibraryService.Models;
using LibraryService.Services.Implementation;
using LibraryService.Services.Interfaces;

namespace LibraryService
{
    /// <summary>
    /// Summary description for LibraryWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LibraryWebService : System.Web.Services.WebService
    {
        private readonly ILibraryRepositoryService _libraryRepositoryService;

        public LibraryWebService()
        {
            _libraryRepositoryService = new LibraryRepository(new LibraryDatabaseContext());
        }

        [WebMethod]
        public int Add(Book book)
        {
            return _libraryRepositoryService.Add(book);
        }

        [WebMethod]
        public int Delete(Book book)
        {
            return _libraryRepositoryService.Delete(book);
        }

        [WebMethod]
        public List<Book> GetAll()
        {
            return _libraryRepositoryService.GetAll().ToList();
        }

        [WebMethod]
        public List<Book> GetBooksByAuthor(string authorName)
        {
            return _libraryRepositoryService.GetByAuthor(authorName).ToList();
        }

        [WebMethod]
        public List<Book> GetBooksByCategory(string category)
        {
            return _libraryRepositoryService.GetByCategory(category).ToList();
        }

        [WebMethod]
        public Book GetById(string id)
        {
            return _libraryRepositoryService.GetById(id);
        }

        [WebMethod]
        public List<Book> GetBooksByTitle(string title)
        {
            return _libraryRepositoryService.GetByTitle(title).ToList();
        }

        [WebMethod]
        public int Update(Book book)
        {
            return _libraryRepositoryService.Update(book);
        }
    }
}
