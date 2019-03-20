using System;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace TeleCare.Repository.Base
{
    public abstract class BaseRepository<TEntity> //: IRepository<TEntity> where TEntity : class
    {
        
        //public BaseRepository()
        //{
        //    DbContext = DbContextFactory.GetContext();
        //}

        //public BaseRepository(IMSContexts context)
        //{
        //    DbContext = context;
        //}

        //private IDbSet<TEntity> DbSet
        //{
        //    get { return DbContext.Set<TEntity>(); }
        //}

        /// <summary>
        /// get exception message of validation
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        //protected string GetDetailExceptionMessage(DbEntityValidationException ex)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var failure in ex.EntityValidationErrors)
        //    {
        //        sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
        //        foreach (var error in failure.ValidationErrors)
        //        {
        //            sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
        //            sb.AppendLine();
        //        }
        //    }

        //    return sb.ToString();
        //}

        /// <summary>
        /// get exception message of validation
        /// </summary>
        /// <param name="validationResults"></param>
        /// <returns></returns>
        protected string GetDetailExceptionMessage(List<ValidationResult> validationResults)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var failure in validationResults)
            {
                sb.AppendFormat("{0} failed validation: {1}\n", string.Join(",", failure.MemberNames),
                    failure.ErrorMessage);
            }

            return sb.ToString();
        }

        /// <summary>
        /// get all
        /// </summary>
        /// <returns></returns>
        //public virtual IQueryable<TEntity> GetAll()
        //{
        //   // return DbSet.AsQueryable();
        //}

        //public virtual Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        //{
        //   // return Task.FromResult(GetAll().Where(predicate));
        //}

        /// <summary>
        /// delete it immediately when isSave is true
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        public virtual void Delete(TEntity entity, bool isSave = true)
        {
           // DbSet.Remove(entity);
            if (isSave)
            {
                //LogHistoryForModification();
                //DbContext.SaveChanges();
            }
        }

        /// <summary>
        /// delete it by id immediately when isSave is true
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isSave"></param>
        public virtual void Delete(int id, bool isSave = true)
        {
           // var entity = DbSet.Find(id);
          //  Delete(entity, isSave);
        }

        /// <summary>
        /// delete it by id immediately when isSave is true
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="refId"></param>
        /// <param name="isSave"></param>
        public virtual void Delete(int companyId, int refId, bool isSave = true)
        {
          //  var entity = DbSet.Find(companyId, refId);
         //   Delete(entity, isSave);
        }

        /// <summary>
        /// delete it by id immediately when isSave is true
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isSave"></param>
        //public virtual void DeleteRanges(IEnumerable<TEntity> entities, bool isSave = true)
        //{
        //    //entities.ToList().ForEach(x => {
        //    //    DbSet.Remove(x);

        //    });
        //    if (isSave)
        //    {
        //        //LogHistoryForModification();
        //       // DbContext.SaveChanges();
        //    }
        //}

        /// <summary>
        /// create new object when isSave is true
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        //public virtual TEntity Create(TEntity entity, bool isSave = true)
        //{
        //    var results = new List<ValidationResult>();
        //    if (Validator.TryValidateObject(entity, new ValidationContext(entity, null, null), results, true))
        //    {
        //        DbSet.Add(entity);
        //        if (isSave)
        //        {
        //            //LogHistoryForModification();
        //           // DbContext.SaveChanges();
        //            return entity;
        //        }
        //        return null;
        //    }
        //    else
        //    {
        //       // throw new DbEntityValidationException("Entity Validation Failed - errors follow:\n" +
        //       //                                       GetDetailExceptionMessage(results));
        //    }
        //}

        /// <summary>
        /// create new object when isSave is true - async
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        //public virtual async Task<TEntity> CreateAsync(TEntity entity, bool isSave = true)
        //{
        //    var results = new List<ValidationResult>();
        //    if (Validator.TryValidateObject(entity, new ValidationContext(entity, null, null), results, true))
        //    {
        //        DbSet.Add(entity);
        //        if (isSave)
        //        {
        //            //LogHistoryForModification();
        //           // await DbContext.SaveChangesAsync();
        //            return entity;
        //        }
        //        return null;
        //    }
        //    else
        //    {
        //       // throw new DbEntityValidationException("Entity Validation Failed - errors follow:\n" +
        //        //                                      GetDetailExceptionMessage(results));
        //    }
        //}

        /// <summary>
        /// create multiple objects when isSave is true
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        //public virtual IEnumerable<TEntity> CreateRanges(IEnumerable<TEntity> entities, bool isSave = true)
        //{
        //    var results = new List<ValidationResult>();
        //    entities.ToList().ForEach(x =>
        //    {
        //        //if (Validator.TryValidateObject(x, new ValidationContext(x, null, null), results, true))
        //        //    //DbSet.Add(x);
        //        //else
        //           // throw new DbEntityValidationException("Entity Validation Failed - errors follow:\n" +
        //            //                                      GetDetailExceptionMessage(results));
        //    });

        //    if (isSave)
        //    {
        //        //LogHistoryForModification();
        //       // DbContext.SaveChanges();
        //    }

        //    return entities;
        //}

        /// <summary>
        /// update it immediately when isSave is true
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        //public virtual TEntity Update(TEntity entity, bool isSave = true)
        //{
        //    //try
        //    //{
        //    //    //DbContext.Entry(entity).State = EntityState.Modified;
        //    //    if (isSave)
        //    //    {
        //    //        //LogHistoryForModification();
        //    //        //DbContext.SaveChanges();
        //    //        return entity;
        //    //    }
        //    //    return null;
        //    //}
        //    //catch (DbEntityValidationException ex)
        //    //{
        //    //    throw new DbEntityValidationException(
        //    //        "Entity Validation Failed - errors follow:\n" + GetDetailExceptionMessage(ex), ex);
        //    //}
        //}
        /// <summary>
        /// update it immediately when isSave is true for multiple update in onetable
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="isSave"></param>
        //public virtual IEnumerable<TEntity> UpdateRanges(IEnumerable<TEntity> entities, bool isSave = true)
        //{
        //    try
        //    {
        //        foreach (var entity in entities)
        //        {
        //            //DbContext.Entry(entity).State = EntityState.Modified;
        //        }
        //        if (isSave)
        //        {
        //            //LogHistoryForModification();
        //            //DbContext.SaveChanges();
        //        }
        //    }
        //    //catch (DbEntityValidationException ex)
        //    //{
        //    //    throw new DbEntityValidationException(
        //    //        "Entity Validation Failed - errors follow:\n" + GetDetailExceptionMessage(ex), ex);
        //    //}

        //    return entities;
        //}

        /// <summary>
        /// get by conditions
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        //public virtual IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return DbSet.Where(predicate);
        //}

       
        
    }

    public class DbContextFactory
    {
        private const string EfKey = "Ef_key";

       
        public static void DisposeContext()
        {
            try
            {
              //  var db = GetContext();
                //db.Dispose();
            }
            catch
            {
                // ignored
            }
        }
    }
}