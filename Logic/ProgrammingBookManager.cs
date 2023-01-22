using Zaliczenie_JIPP_Jakub_Bialek.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Zaliczenie_JIPP_Jakub_Bialek.Data;

namespace Zaliczenie_JIPP_Jakub_Bialek
{
    public class ProgrammingBookManager
    {
        public ProgrammingBookManager AddBook(ProgrammingBookModel bookModel)
        {
            using (var context = new ProgrammingBookContext())
            {
                context.Add(bookModel);
                context.SaveChanges();
            }
            return this;
        }

        public ProgrammingBookManager RemoveBook(int id)
        {
            return this;
        }

        public ProgrammingBookManager UpdateBook(ProgrammingBookModel bookModel)
        {
            return this;
        }

        public ProgrammingBookManager ChangeTitle(int id, string newTitle)
        {
            return this;
        }

        public ProgrammingBookManager GetBook(int id)
        {
            return null;
        }

        public List<ProgrammingBookManager> GetBooks()
        {
            return null;
        }
    }
}
