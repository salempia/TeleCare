using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleCare.Repository.Base
{
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// get all
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// delete entity immediately when isSave is true
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        void Delete(TEntity entity, bool isSave);
        /// <summary>
        /// delete ranges of entities in one table
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="isSave"></param>
        void DeleteRanges(IEnumerable<TEntity> entities, bool isSave = true);
        /// <summary>
        /// delete entity immediately when isSave is true
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isSave"></param>
        void Delete(int id, bool isSave);

        /// <summary>
        /// create entity immediately when isSave is true
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        TEntity Create(TEntity entity, bool isSave);

        /// <summary>
        /// create new object when isSave is true - async
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        Task<TEntity> CreateAsync(TEntity entity, bool isSave);

        /// <summary>
        /// create multiple object
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        IEnumerable<TEntity> CreateRanges(IEnumerable<TEntity> entities, bool isSave);

        /// <summary>
        /// update entity immediately when isSave is true
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        TEntity Update(TEntity entity, bool isSave);

        /// <summary>
        /// get by conditions
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        //IQueryable<TEntity> GetByCondition(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);

       

    }
}