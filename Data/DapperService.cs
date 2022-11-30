using team3.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
namespace BookApp.Data
{
    /// <summary>
    /// Isaiah Jayne
    /// This is the implementation of the IDapperService interface
    /// </summary>
    public class DapperService : IDapperService
    {
        private readonly IConfiguration _config;
        /// <summary>
        /// Isaiah Jayne
        /// Constructor for a DapperService Object
        /// </summary>
        /// <param name="config"></param>
        public DapperService(IConfiguration config)
        {
            _config = config;
        }
        /// <summary>
        /// Isaiah Jayne
        /// Establishes connection with Database
        /// </summary>
        /// <returns>SqlConnection linked to Database</returns>
        public DbConnection GetConnection()
        {
            return new SqlConnection
               (_config.GetConnectionString("DefaultConnection"));
        }
        /// <summary>
        /// Isaiah Jayne
        /// Gets a row from one of the tables within the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T Get<T>(string sp, DynamicParameters parms,
           CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection
               (_config.GetConnectionString("DefaultConnection"));
            return db.Query<T>(sp, parms,
               commandType: commandType).FirstOrDefault();
        }
        /// <summary>
        /// Isaiah Jayne
        /// Gets all the rows from a table in the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public List<T> GetAll<T>(string sp, DynamicParameters parms,
           CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection
               (_config.GetConnectionString("DefaultConnection"));
            return db.Query<T>(sp, parms,
               commandType: commandType).ToList();
        }
        /// <summary>
        /// Isaiah Jayne
        /// Executes a store procedure within the database
        /// </summary>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string sp, DynamicParameters parms,
           CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection
               (_config.GetConnectionString("DefaultConnection"));
            return db.Execute(sp, parms, commandType: commandType);
        }
        /// <summary>
        /// Inserts a row into a table in the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T Insert<T>(string sp, DynamicParameters parms,
           CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection
               (_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType:
                       commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }
            return result;
        }
        /// <summary>
        /// Updates a row in a table in the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T Update<T>(string sp, DynamicParameters parms,
           CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection
               (_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType:
                       commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }
            return result;
        }
        public void Dispose()
        {
        }
    }
}