using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Outils;
using System.Data.SqlClient;
using CompetencePlus.Tools;

namespace CompetencePlus.PackageModules
{
  public  class ModuleDAO : IGestion<Module>
    {

      public Module getModulepre(int id)
      {
          List<Module> m = new List<Module>();
          string req = "Select * from [Module] where id = " + id;
          OleDbDataReader da = MyConnection.ExecuteReader(req);
          while (da.Read())
          {
              m.Add(new Module(da.GetInt32(0), new PackageFilieres.FiliereDAO().FindById(da.GetInt32(1)), da.GetString(3), da.GetInt32(4), da.GetString(5), da.GetString(6), da.GetString(7), da.GetString(8), da.GetString(8), da.GetString(9), da.GetString(10), da.GetString(11),da.GetString(12)));
          }
          MyConnection.Close();
          return m.ElementAt(0);
      }

      public List<Module> Select()
      {
          List<Module> liste = new List<Module>();
          string req = "select * from Modules";
          OleDbDataReader da = MyConnection.ExecuteReader(req);
          while (da.Read())
          {

              liste.Add(new Module(da.GetInt32(0), new PackageFilieres.FiliereDAO().FindById(da.GetInt32(1)), da.GetString(3), da.GetInt32(4), da.GetString(5), da.GetString(6), da.GetString(7), da.GetString(8), da.GetString(8), da.GetString(9), da.GetString(10), da.GetString(11), da.GetString(12)));
              
          }
        
          MyConnection.Close();
          return liste;
      }


      public void Add(Module o)
      {
          string req = "insert into [Modules](Filiere_id,nom,duree,strategieEnseignement,apprentisage,evaluation,materiel,equipement,competence,presentation,description,Code,Precision_id) values("  + o.Id_f.Id + ",'" + o.Nom + "'," + o.Duree + ",'" + o.StrategieEnseignement + "','" + o.Apprentisage + "','" + o.Evaluation + "','" + o.Materiel + "','" + o.Equipement + "','" + o.Competence + "','" + o.Presentation + "','" + o.Description + "','" + o.Code + "',"+1+")";
          MyConnection.ExecuteNonQuery(req);
      }
      
      public void Update(Module o)
      {
          string req = "update [Modules] set Filiere_id =" + o.Id_f.Id + ",nom = '" + o.Nom + "', duree = " + o.Duree + ",strategieEnseignement = '" + o.StrategieEnseignement + "',apprentisage = '" + o.Apprentisage + "', evaluation = '" + o.Evaluation + "',materiel = '" + o.Materiel + "',equipement = '" + o.Equipement + "',competence = '" + o.Competence + "',presentation = '" + o.Presentation + "',description = '" + o.Description + "',Code = '" + o.Code + "',Precision_id =" + 1 +" where id = "+o.ID;
          MyConnection.ExecuteNonQuery(req);
      }

      public void Delete(int id)
      {
          string req = "delete from [Modules] where id = " + id;
          MyConnection.ExecuteNonQuery(req);
      }

      public Module FindById(int id)
      {
          List<Module> liste = new List<Module>();
          string req = "select * from Modules where id = " + id;
          OleDbDataReader da = MyConnection.ExecuteReader(req);
          while (da.Read())
          {

              liste.Add(new Module(da.GetInt32(0), new PackageFilieres.FiliereDAO().FindById(da.GetInt32(1)), da.GetString(3), da.GetInt32(4), da.GetString(5), da.GetString(6), da.GetString(7), da.GetString(8), da.GetString(8), da.GetString(9), da.GetString(10), da.GetString(11), da.GetString(12)));

          }

          MyConnection.Close();
          return liste.ElementAt(0);
      }

      public List<Module> findbyname(Module m)
      {
          string req = "select * from [modules]";
          if (m.Nom != "" || m.Description != "" || m.Id_f.Id !=0||m.Duree != 0)
          {
              req += " where ";
          }
          bool and = false;
          if (m.Nom != "")
          {
              req += " nom like '%" + m.Nom + "%'";
              and = true;
          }
          if(m.Id_f.Id!=0){
              req += " and Filiere_id like '%" + m.Id_f.Id + "%'";
              and = true;
          }
          
          if (m.Description != null)
          {
              if (and)
              {
                  req += " and description like '%" + m.Description + "%'";
              }
              and = true;
          }
          if (m.Duree != null)
          {
              if (and)
                  req += " and duree like " + m.Duree;
          }
        

          List<Module> liste = new List<Module>();
          OleDbDataReader da = MyConnection.ExecuteReader(req);
          while (da.Read())
          {

              liste.Add(new Module(da.GetInt32(0), new PackageFilieres.FiliereDAO().FindById(da.GetInt32(1)), da.GetString(3), da.GetInt32(4), da.GetString(5), da.GetString(6), da.GetString(7), da.GetString(8), da.GetString(8), da.GetString(9), da.GetString(10), da.GetString(11), da.GetString(12)));
          }
          return liste;
      }
     
    }
}
