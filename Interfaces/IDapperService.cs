using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace team3.Interfaces
{
    /// <summary>
    /// Isaiah Jayne
    /// Dapper is the plugin that we used to get SQLExpress to work with our solution
    /// Not entirely sure how all of this ties in
    /// </summary>
    public interface IDapperService : IDisposable
    {
        DbConnection GetConnection();
        T Get<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        int Execute(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        T Insert<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sp, DynamicParameters parms,
            CommandType commandType = CommandType.StoredProcedure);
    }
}