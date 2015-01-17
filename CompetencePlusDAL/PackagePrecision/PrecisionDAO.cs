using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Outils;
using CompetencePlus.PackageModules;
using System.Data.OleDb;
using System.Data.SqlClient;
using CompetencePlus.Tools;
namespace CompetencePlus.PackagePrecision
{
    public class PrecisionDAO : IGestion<Precision>
    {


        public void Add(Precision o)
        {
            string req = "insert into [Precisions](nom,description,duree,ordre,modules_id) values('"+ o.Nom + "','" + o.Description + "'," + o.Duree + "," + o.Ordre + "," + o.Modules_id.ID + ")";
            MyConnection.ExecuteNonQuery(req);

        }

        public void Update(Precision o)
        {
            string req = "update Precisions set nom = '" + o.Nom + "', description = '" + o.Description + "', duree = " + o.Duree + ", ordre = " + o.Ordre + ", modules_id = " + o.Modules_id.ID + " where id = " + o.Id;
            MyConnection.ExecuteNonQuery(req);
        }

        public void Delete(int id)
        {
            string req = "Delete From Precisions where id = " + id;
            MyConnection.ExecuteNonQuery(req);
        }

        public List<Precision> Select()
        {

            List<Precision> p = new List<Precision>();
            string req = "Select * From Precisions";
            OleDbDataReader sqr = MyConnection.ExecuteReader(req);
            while (sqr.Read())
            {
                p.Add(new Precision(sqr.GetInt32(0),sqr.GetInt32(1),sqr.GetString(2),sqr.GetString(3),sqr.GetInt32(4),sqr.GetInt32(5),new ModuleDAO().FindById(sqr.GetInt32(6))));
               // p.Add(new Precision(sqr.GetInt32(0), sqr.GetInt32(1), sqr.GetString(2), sqr.GetString(3), sqr.GetInt32(4), sqr.GetInt32(5),new ModuleDAO().FindById(sqr.GetInt32(6))));
            }
            MyConnection.Close();
            return p;
        }


        public Precision FindById(int id)
        {
            List<Precision> p = new List<Precision>();
            string req = "Select * From [Precisions] where id=" + id;
            OleDbDataReader sqr = MyConnection.ExecuteReader(req);
            while (sqr.Read())
            {
                p.Add(new Precision(sqr.GetInt32(0), sqr.GetInt32(1), sqr.GetString(2), sqr.GetString(3), sqr.GetInt32(4), sqr.GetInt32(5),  new ModuleDAO().FindById(sqr.GetInt32(6))));
            }
            MyConnection.Close();
            return p.ElementAt(0);
        }
        public List<Precision> GetallPres(int id)
        {
            List<Precision> p = new List<Precision>();
            string req = "Select * From [Precisions] where modules_id =" + id;
            OleDbDataReader sqr = MyConnection.ExecuteReader(req);
            while (sqr.Read())
            {
                p.Add(new Precision(sqr.GetInt32(0), sqr.GetInt32(1), sqr.GetString(2), sqr.GetString(3), sqr.GetInt32(4), sqr.GetInt32(5), new ModuleDAO().FindById(sqr.GetInt32(6))));
            }
            MyConnection.Close();
            return p;
            
        }
    }
}
