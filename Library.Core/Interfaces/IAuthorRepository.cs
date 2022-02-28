﻿using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Interfaces
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Authors>> GetAuthors();
        Task<Authors> GetAuthor(int id);
        Task InsertAuthor(Authors author);
        Task<bool> UpdateAuthor(Authors author);
        Task<bool> DeleteAuthor(int id);
    }
}
