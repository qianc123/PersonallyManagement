using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PersonnelManagementSystem
{
    class SqlHelper
    {
        #region 数据库连接
        /// <summary> 
        /// 获取数据库连接字符串 
        /// </summary> 
        /// <returns>返回连接字符串</returns> 
        private static string GetConnString()
        {
            return ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }
        /// <summary> 
        /// 获取有效的数据库连接对象 
        /// </summary> 
        /// <returns>返回连接对象</returns> 
        public static SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection(SqlHelper.GetConnString());
            conn.Open();
            return conn;
        }
        #endregion
        /// <summary>
        /// 封装Command对象的ExecuteNonQuery方法完成增删改操作(重载+1)
        /// </summary>
        /// <param name="strsql">insert|update|delete打头的SQL语句</param>
        /// <param name="prms">传给Command对象的相关参数</param>
        /// <returns>返回数据影响的行数(大于1代表成功，等于0代表失败)</returns>
        public static int ExecuteNonQuery(string strsql,params SqlParameter[] prms)
        {
            using (SqlConnection conn = GetConn())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = strsql;
                    AttachParameters(comm, prms);
                    return comm.ExecuteNonQuery();
                }
            }
        }
        public static DataTable getDataTable(string sqlstr)//Dataset数据集
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            using (SqlConnection conn = GetConn())
            {
                using (SqlCommand sqlcom = new SqlCommand(sqlstr, conn))
                {
                    using (SqlDataAdapter sqlad = new SqlDataAdapter(sqlcom))
                    {
                        sqlad.Fill(ds);
                        dt = ds.Tables[0];
                    }
                }
            }
            return dt;
        }
        /// <summary>
        /// 获取数据，返回DataReader(重载+1）
        /// </summary>
        /// <param name="strsql">以Select打头的SQL语句</param>
        /// <param name="_params">给Command对象赋值的参数</param>
        /// <returns>返回SqlDataReader</returns>
        public static SqlDataReader ExecuteDataReader(string strsql, params SqlParameter[] prms)
        {
            SqlConnection conn = GetConn();
            using (SqlCommand comm = new SqlCommand(strsql, conn))//自产自消
            {
                AttachParameters(comm, prms);

                try
                {
                    return comm.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (SqlException ex)
                {
                    conn.Close();
                    throw ex;
                }
            }

        }

        /// <summary>
        /// 获取返回数据第一行第一列值(重载+1)
        /// </summary>
        /// <param name="strsql">SQL查询语句</param>
        /// <param name="prms">SqlParameter参数</param>
        /// <returns>返回一Object类型的数据</returns>              
        public static object ExecuteScalar(string strsql, params SqlParameter[] prms)
        {
            using (SqlConnection conn = GetConn())
            {
                using (SqlCommand comm = new SqlCommand(strsql, conn))
                {
                    AttachParameters(comm, prms);
                    return comm.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 用于给Command对象的Sqlparams参数赋值的内部辅助方法
        /// </summary>
        /// <param name="comm">命令对象</param>
        /// <param name="prms">参数数组</param>
        private static void AttachParameters(SqlCommand comm, SqlParameter[] prms)
        {
            //判断命令是否为空
            if (comm == null) throw new ArgumentNullException("command");
            //清除命令参数
            comm.Parameters.Clear();
            //将非null值参数对象添加至命令参数集合中
            if (prms != null)
            {
                foreach (SqlParameter p in prms)
                {
                    if (p != null)
                    {
                        comm.Parameters.Add(p);
                    }
                }
            }
        }
    }
}
