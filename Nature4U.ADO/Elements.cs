using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nature4U.TYPES;
using System.Data;
using System.Data.SqlClient;


namespace Nature4U.ADO
{
    public static class Elements
    {
        public static List<BodyParts> Parts(string connection)
        {
            List<BodyParts> lstBodyParts = new List<BodyParts>();
            DBConnection con = new DBConnection(connection);
            DataTable parts = con.GetDataTable("usp_BodyParts_Select");
            foreach (DataRow row in parts.Rows)
            {
                BodyParts objBodyP = new BodyParts();
                objBodyP.BodyPartID = (row["BodyPartID"] == DBNull.Value) ? int.MinValue : Convert.ToInt32(row["BodyPartID"]);
                objBodyP.Name = (row["Name"] == DBNull.Value) ? string.Empty : row["Name"].ToString();
                objBodyP.Description = (row["Description"] == DBNull.Value) ? string.Empty : row["Description"].ToString();
                objBodyP.BodyParentID = (row["BodyParentID"] == DBNull.Value) ? int.MinValue : Convert.ToInt32(row["BodyParentID"]);
                lstBodyParts.Add(objBodyP);
            }
            return lstBodyParts;
        }
        public static int InsertParts(string connection, BodyParts objParts)
        {
            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter() { ParameterName = "@Name", SqlDbType = System.Data.SqlDbType.VarChar, Value = objParts.Name});
            Parameters.Add(new SqlParameter() { ParameterName = "@Description", SqlDbType = System.Data.SqlDbType.VarChar, Value = objParts.Description });
            Parameters.Add(new SqlParameter() { ParameterName = "@BodyParentID", SqlDbType = System.Data.SqlDbType.Int, Value = objParts.BodyParentID });
            DBConnection con = new DBConnection(connection);
            return Convert.ToInt32(con.GetScalar("usp_BodyParts_Insert", Parameters));
        }
    }
}
