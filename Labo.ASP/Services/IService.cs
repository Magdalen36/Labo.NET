﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Services
{
    public interface IService<T, U>
        where T : class
        where U : class

    {
        bool Delete(int d);
        IEnumerable<T> GetAll();
        U GetById(int id);
        void Insert(U form);
        void Update(U form);
    }
}
