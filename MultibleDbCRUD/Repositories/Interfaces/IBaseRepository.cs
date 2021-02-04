﻿using Microsoft.EntityFrameworkCore;
using MultibleDbCRUD.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultibleDbCRUD.Repositories.Interfaces
{
    public interface IBaseRepository<TContext, T> where TContext : DbContext where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Find(string id);
        void Add(T value);
        bool Update(T Value);
        void SaveChange();
    }
}