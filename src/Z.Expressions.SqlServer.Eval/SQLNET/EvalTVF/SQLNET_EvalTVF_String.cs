// Description: Evaluate C# code and expression in T-SQL stored procedure, function and trigger.
// Website & Documentation: https://github.com/zzzprojects/Eval-SQL.NET
// Forum & Issues: https://github.com/zzzprojects/Eval-SQL.NET/issues
// License: https://github.com/zzzprojects/Eval-SQL.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System.Collections;
using System.Data;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace Z.Expressions.SqlServer.Eval
{
    public partial struct SQLNET
    {
        [SqlFunction(DataAccess = DataAccessKind.None, SystemDataAccess = SystemDataAccessKind.None, FillRowMethodName = "Fill_SQLNET_EvalTVF_String", TableDefinition = "Value_1 NVARCHAR(MAX)")]
        public static IEnumerable SQLNET_EvalTVF_String(SQLNET sqlnet)
        {
            var obj = sqlnet.Eval();
            return DataTableHelper.GetDataRows(obj);
        }

        public static void Fill_SQLNET_EvalTVF_String(object obj, out SqlString value1)
        {
            var row = (DataRow) obj;
            value1 = new SqlString((string)row[0]);
        }
    }
}