using System.Collections.Generic;

namespace SystemTrayApp.Interfaces
{
    public interface ITableEntity<T>
    {
        /// <summary>
        /// Get Message by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(decimal id);
        /// <summary>
        /// Update Message
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        T Update(T pMessage);
        /// <summary>
        /// Add a new Message
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        T Add(T pMessage);
        /// <summary>
        /// Remove Message by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Delete(int id);
        int Commit();
        List<T> GetAll();
    }
}
