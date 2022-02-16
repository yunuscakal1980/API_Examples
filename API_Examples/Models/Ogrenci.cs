using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace API_Examples.Models
{
    public class Ogrenci
    {
        //Properties:
        public int Id { get; set; }

        public string Adi { get; set; }

        //Actions:
        public bool Post()
        {
            return true;
        }

        public DataTable Get()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("Adi", Type.GetType("System.String"));
            dt.AcceptChanges();

            DataRow dr = dt.NewRow();
            dr["Id"] = 1;
            dr["Adi"] = "Yunus";

            DataRow dr2 = dt.NewRow();
            dr2["Id"] = 2;
            dr2["Adi"] = "Emre";

            DataRow dr3 = dt.NewRow();
            dr3["Id"] = 3;
            dr3["Adi"] = "Zeynep";

            dt.Rows.Add(dr);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.AcceptChanges();

            dt.TableName = "dtTable";

            return dt;
        }

        public DataTable Get(int _id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("Adi", Type.GetType("System.String"));
            dt.AcceptChanges();

            DataRow dr = dt.NewRow();
            dr["Id"] = 1;
            dr["Adi"] = "Yunus";

            DataRow dr2 = dt.NewRow();
            dr2["Id"] = 2;
            dr2["Adi"] = "Emre";

            DataRow dr3 = dt.NewRow();
            dr3["Id"] = 3;
            dr3["Adi"] = "Zeynep";

            dt.Rows.Add(dr);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.AcceptChanges();

            DataTable dtResult = dt.Select("Id='" + _id.ToString() + "'").CopyToDataTable();

            dtResult.TableName = "dtTable";

            return dtResult;
        }

        public bool Put()
        {
            return true;
        }

        public bool Delete(int _id)
        {
            return true;
        }
    }
}