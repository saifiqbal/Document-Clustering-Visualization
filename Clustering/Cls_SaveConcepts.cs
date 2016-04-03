using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace Final_Year_Project_2
{
    /***********************************************************************************************************
 
        NAME SPACES
 
        ---->SYSTEM.IO 
        * DESCRIPTION : It is used for reading documents .
        ---->System.Linq
        * Description : It is used for enumerable functions for iterating array values
        ------------------------------------------------------------------------------------------------------------
  
       -------------------------------------------------------------------------------------------------------------
       Public Methods
        --->SaveConcepts
         * Description: This method take matrixfilepath as an input error will occur if null .else Store to DataBase.
        --->RemoveConcepts
         * Description:Remove All The Previous Concepts from the database
         --->RemoveDocuments
         * Description:Remove All The Previous Documents from the database
       -------------------------------------------------------------------------------------------------------------
        Public Variables
        --->OlebdConnection- Connection
        * type :AccessDatabase Connection
      
    -------------------------------------------------------------------------------------------------------------
    ***************************************************************************************************************/


    class Cls_SaveConcepts
    {

        public string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database\\datamatrix.accdb";
       
       // public static event UpdateProgress changedpercentage;
       // public static int Docid;
        public static string[] items = null;


        public void SaveConcepts(string MatrixPath)
        {
            int ConceptID = 0;
            int DocID = 0;
            // string Frequency = null;

              OleDbConnection cond = new OleDbConnection(connection);
              cond.Open();




            try
            {


               

                    StreamReader sr = new StreamReader(MatrixPath);
                    //object[, ,] arr1 = new object[4, 2, 4];
                    //byte[] arr2 = new byte[byte.MaxValue];

                    while (sr.EndOfStream == false)
                    {
                        string data = sr.ReadToEnd();

                         items = data.Split('\n');


                        string concepts = items[0];    //get Concepts here//............................................................
                        string[] Allconcepts = concepts.Split('\t');

                        //////loop for entering Concepts in the Database//......................../////////////////////////////////////////....
                        for (int con = 0; con < Allconcepts.Length; con++)
                        {
                            try
                            {

                        





                                string querry = "INSERT INTO Concepts(Concept) " + "VALUES ('" + Allconcepts[con] + "')";
                            
                                OleDbCommand cmd = new OleDbCommand();
                                OleDbDataAdapter da = new OleDbDataAdapter();
                                System.Data.DataTable dt = new System.Data.DataTable();
                                cmd.Connection = cond;
                                cmd.CommandText = querry;
                                cmd.ExecuteNonQuery();
                                da.InsertCommand = cmd;

                            }
                            catch (Exception ex)
                            {
                                ex.ToString();
                            }
                        }
                        //.////////.......................................................................................................

                        ///............loop for entering DocNames in the Documents Table//................................................
                        ///
                        for (int D = 1; D < items.Length; D++)
                        {

                            string docname = items[D];
                            string[] splitting = docname.Split('\t');
                            string OnlyDocname = splitting[0];



                            string querry = "INSERT INTO Documents(DocName) " + "VALUES ('" + OnlyDocname + "')";
                    
                            OleDbCommand cmd = new OleDbCommand();
                            OleDbDataAdapter da = new OleDbDataAdapter();
                            System.Data.DataTable dt = new System.Data.DataTable();
                            cmd.Connection = cond;
                            cmd.CommandText = querry;
                            cmd.ExecuteNonQuery();
                            da.InsertCommand = cmd;


                        }





                        ////////code for ConDocument Table 



                        for (int Docid = 1; Docid < items.Length; Docid++)
                        {


                            string docname = items[Docid];
                            string[] splitting = docname.Split('\t');
                            string OnlyDocname = splitting[0];                         ///we get docname to get docid from documents table//.....


                            string querryDoc = "SELECT DocID From Documents Where DocName=" + "'" + OnlyDocname + "'";

                      

                            OleDbCommand cmdDoc = new OleDbCommand();
                            OleDbDataAdapter daDoc = new OleDbDataAdapter();
                            System.Data.DataTable dtDoc = new System.Data.DataTable();
                            cmdDoc.Connection = cond;
                            cmdDoc.CommandText = querryDoc;
                            cmdDoc.ExecuteNonQuery();
                            daDoc.SelectCommand = cmdDoc;



                            OleDbDataReader readerDoc;
                            readerDoc = cmdDoc.ExecuteReader();
                            while (readerDoc.Read())
                            {
                                DocID = readerDoc.GetInt32(0);                   ///we get concept id here from data base//.............       


                            }
                            readerDoc.Close();



                           
                            for (int conid = 0; conid < Allconcepts.Length; conid++)
                            {

                                string conceptname = Allconcepts[conid];


                                // string querry = "INSERT INTO Documents(DocName) " + "VALUES ('" + OnlyDocname + "')";

                                string querry = "SELECT ConceptID From Concepts Where Concept=" + "'" + conceptname + "'";

                              
                              
                                OleDbCommand cmd = new OleDbCommand();
                                OleDbDataAdapter da = new OleDbDataAdapter();
                                System.Data.DataTable dt = new System.Data.DataTable();
                                cmd.Connection = cond;
                                cmd.CommandText = querry;
                                cmd.ExecuteNonQuery();
                                da.SelectCommand = cmd;



                                OleDbDataReader reader;
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    ConceptID = reader.GetInt32(0);                  ///we get concept id here from data base//.............       


                                }
                                reader.Close();






                                for (int freq = 1; freq < splitting.Length; freq++)
                                {


                                    if (freq <= conid)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        string DocFreq = splitting[freq];

                                        string querryCondoc = "INSERT INTO ConDocument(ConID,DocID,Frequency) " + "VALUES ('" + ConceptID + "','" + DocID + "','" + Convert.ToInt32(DocFreq) + "')";
                            
                                    
                                        OleDbCommand cmdCondoc = new OleDbCommand();
                                        OleDbDataAdapter daCondoc = new OleDbDataAdapter();
                                        System.Data.DataTable dtcondoc = new System.Data.DataTable();
                                        cmdCondoc.Connection = cond;
                                        cmdCondoc.CommandText = querryCondoc;
                                        cmdCondoc.ExecuteNonQuery();
                                        da.InsertCommand = cmdCondoc;

                                        break;
                                    }
                                }
                              
                            }




                        }
                    }
                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }


        /// <summary>
        /// this method is used to delete previous data in the database.,,,,,,,,,,,,,,,
        /// </summary>
        public void RemoveConcepts()
        {



            OleDbCommand cmd = new OleDbCommand("emptyall");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = new OleDbConnection(connection);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            


        }
        public void RemoveDocuments()
        {

           

            OleDbCommand cmd = new OleDbCommand("RemoveDocuments");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = new OleDbConnection(connection);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();




        }



    }
}
