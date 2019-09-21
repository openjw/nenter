﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nenter.Data.PagedList;

namespace Nenter.Data.EntityFramework
{
    public class DataRepository<TEntity>:IDataRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        
        public DataRepository(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _dbSet = _dbContext.Set<TEntity>();
            
           
            //_dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            
            // https://github.com/aspnet/EntityFrameworkCore/issues/15812
//            IQueryable<TEntity> query = _dbSet;
//            if (disableTracking)
//            {
//                query = query.AsNoTracking();
//            }
        }

//        public static DbSet<TEntity> ChangeTable<TEntity>(DbSet<TEntity> dbSet, string tableName) where TEntity : class
//        {
//            var dbContext = dbSet.GetService<ICurrentDbContext>().Context;
//            ChangeTableAsync(typeof(TEntity), tableName);
//            return dbSet;
//        }

        public IDbContext GetContext()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangeTableAsync(string table, CancellationToken cancellationToken = default)
        {
//            if (_dbContext.Model.FindEntityType(typeof(TEntity)).Relational() is RelationalEntityTypeAnnotations relational)
//            {
//                relational.TableName = table;
//            }
            return Task.FromResult(true);
        }

        public Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync<TChild1, TChild2, TChild3, TChild4, TChild5, TChild6>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> tChild1,
            Expression<Func<TEntity, object>> tChild2, Expression<Func<TEntity, object>> tChild3, Expression<Func<TEntity, object>> tChild4, Expression<Func<TEntity, object>> tChild5, Expression<Func<TEntity, object>> tChild6,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, object>> distinctField = null,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(TEntity instance, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(TEntity instance, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Expression<Func<TEntity, bool>> predicate, TEntity instance, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(TEntity instance, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> BulkInsertAsync(IEnumerable<TEntity> instances, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> BulkUpdateAsync(IEnumerable<TEntity> instances, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FromSql(string sql, params object[] parameters)
        {
            //FromSqlRaw("SELECT * FROM Products WHERE Name = {0}",product.Name);
            return _dbSet.FromSqlRaw(sql, parameters);
        }

        public Task<int> ExecuteAsync(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null,
            bool useTransaction = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<TEntity>> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int pageIndex = 0, int pageSize = 10,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<TResult>> GetPagedListAsync<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int pageIndex = 0, int pageSize = 10, CancellationToken cancellationToken = default(CancellationToken)) where TResult : class
        {
            throw new NotImplementedException();
        }
    }
}