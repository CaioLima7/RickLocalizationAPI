using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BaseRepository<T> where T : class
    {
        protected readonly Context context;

        public BaseRepository(Context context)
        {
            this.context = context;
        }

        public T GetById()
        {
            return context.Find<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }
    }
}