using System;
using System.Collections.Generic;
using System.Data;

namespace DbAccess.DbAdpater
{
    public interface IDbAdapter
    {
        IDbCommand Cmd { get; }
        IDbConnection Conn { get; }

        int ExecuteQuery(string storedProecure, IDbDataParameter[] parameters, Action<IDbDataParameter[]> returnParameters = null);
        T ExecuteScalar<T>(string storedProcedure, IDbDataParameter[] parameters);
        List<T> LoadObject<T>(string storedProcedure, IDbDataParameter[] parameters = null) where T : class;
    }
}