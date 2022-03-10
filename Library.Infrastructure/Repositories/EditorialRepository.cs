﻿using Library.Core.Entities;
using Library.Core.Interfaces;
using Library.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repositories
{
    public class EditorialRepository :   BaseRepository<Editorials>, IEditorialRepository
    {
        private readonly libraryContext _context;

        public EditorialRepository(libraryContext context) : base(context) { }


       /* public async Task<IEnumerable<Editorials>> GetEditorials()
        {
            var editorials = await _context.Editorials.ToListAsync();
            return editorials;
        }*/




    }
}
