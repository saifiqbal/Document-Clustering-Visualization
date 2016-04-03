using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Data.OleDb;

namespace Final_Year_Project_2
{


    /***********************************************************************************************************
 
   NAME SPACES
 
   ---->SYSTEM.IO 
   * DESCRIPTION : It is used for reading documents .
   ---->System.Data.Oledb
   * Description  : Use for Access Database Connection ,Read and write operation
     ------------------------------------------------------------------------------------------------------------

  Public Methods
   --->GetConceptId
   * Description : Read Concept id from the database.
   --->AllConcepts
   * Description :Read all concepts from the database.
   --->GetDocumentId
   * Description :Read all documentid from the database.
   --->DocumentName
   * Description :Read all Document name from the database.
  -------------------------------------------------------------------------------------------------------------
    Public Variables
  --->Conceptsname
  * type :list array(string)
  --->Conceptsid
  * type :list array(int)
  --->Docid
  * type :list array(int)
    --->Documents
  * type :list array(string)

  *************************************************************************************************************/




    class Cls_FileViewer
    {

            #region variables
        public static List<string> Conceptsname = new List<string>();
            public static List<int> ConceptID = new List<int>();
            public static List<int> docId = new List<int>();
            public static List<string> Documets = new List<string>();
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database\\datamatrix.accdb";
            public OleDbConnection con;

        #endregion
           
            

          


            public Cls_FileViewer()
            {
               
                con = new OleDbConnection(connection);
                con.Open();
            }
            //public void ExplorerDocuments(string querry)
            //{

            //    string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database\\datamatrix.accdb";
            //    OleDbConnection cond = new OleDbConnection(connection);
            //    cond.Open();
            //    OleDbCommand cmd = new OleDbCommand();
            //    OleDbDataAdapter da = new OleDbDataAdapter();
            //    System.Data.DataTable dt = new System.Data.DataTable();
            //    cmd.Connection = cond;
            //    cmd.CommandText = querry;
            //    cmd.ExecuteNonQuery();
            //    da.SelectCommand = cmd;



            //    OleDbDataReader reader;
            //    reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //       // ConceptID = reader.GetInt32(0);                  ///we get concept id here from data base//.............       


            //    }
            //    reader.Close();


            //}


            public void oledbconnection(OleDbConnection con)
            {
               
                con = new OleDbConnection(connection);
                con.Open();
                


            }


        

            public void getconceptId(string querry,int ID)
            {

           
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                System.Data.DataTable dt = new System.Data.DataTable();
                cmd.Connection = con;
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;



                OleDbDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader.GetInt32(0);                  ///we get concept id here from data base//.............       
                    ConceptID.Add(ID);

                }
                reader.Close();

            }
            public void getAllConcepts(string querry, string returnAll)
            {
           
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                System.Data.DataTable dt = new System.Data.DataTable();
                cmd.Connection = con;
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;



                OleDbDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    returnAll = reader.GetString(0);                 ///we get concept id here from data base//.............       
                    Conceptsname.Add(returnAll);

                }
                reader.Close();







            }
            public void getDocumentsID(string querry,int DocID)
            {

               
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                System.Data.DataTable dt = new System.Data.DataTable();
                cmd.Connection = con;
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;



                OleDbDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DocID= reader.GetInt32(0);                 ///we get concept id here from data base//.............       
                    docId.Add(DocID);

                }
                reader.Close();











            }

         
            public void DocumentsName(string querry,string DocNames)
            {
             
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                System.Data.DataTable dt = new System.Data.DataTable();
                cmd.Connection = con;
                cmd.CommandText = querry;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;



                OleDbDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DocNames = reader.GetString(0);                 ///we get concept id here from data base//.............       
                    Documets.Add(DocNames);

                }
                reader.Close();

                con.Close();
            }
           

    }
}
