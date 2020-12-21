using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Teste.Business.Interfaces;
using Teste.Business.Models;
using Teste.Data.Context;

namespace Teste.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly TesteDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(TesteDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual  async Task<TEntity> BuscarId(Guid Id)
        {
            return await DbSet.FindAsync(Id);
        }

        public virtual async Task<List<TEntity>> BuscarTodos()
        {
            return await DbSet.ToListAsync();
        }
        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }
        public virtual async Task Remover(Guid Id)
        {
            DbSet.Remove(new TEntity { Id = Id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
