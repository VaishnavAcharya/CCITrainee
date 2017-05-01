using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoAppFromScratch.Models;
using ToDoAppFromScratch.Repository;


namespace ToDoAppFromScratch.UnitOfWork
{
    public class GenericUnitOfWork
    {
        private ToDoEntity dbEntity = new ToDoEntity();

        public GenericRepository<TEntityType> GetRepoInstance<TEntityType>() where TEntityType : class
        {
            return new GenericRepository<TEntityType>(dbEntity);
        }

        public void SaveChanges()
        {
            dbEntity.SaveChanges();
        }
    }
}