using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebToolbelt.DAL.Interfaces;
using WebToolbelt.Entities.DbContext;
using WebToolbelt.Entities.Entities;

namespace WebToolbelt.DAL.Repositories
{
    public class LanguagesRepository : ILanguagesRepository, IDisposable
    {
        private readonly WebToolbeltDbContext context;

        public LanguagesRepository(WebToolbeltDbContext context)
        {
            this.context = context;
        }

        public Language Get(int id)
        {
            return context.Languages.Find(id);
        }

        public IEnumerable<Language> GetAll()
        {
            return context.Languages.ToList();
        }

        public void Insert(Language entity)
        {
            context.Languages.Add(entity);
        }

        public void Delete(int id)
        {
            Language entity = context.Languages.Find(id);
            context.Languages.Remove(entity);
        }

        public void Update(Language entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
