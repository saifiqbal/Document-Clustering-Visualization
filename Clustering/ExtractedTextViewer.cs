using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;
using Telerik.WinControls.UI;
using System.Threading;
using System.Text.RegularExpressions;

namespace Final_Year_Project_2
{

/***********************************************************************************************************
 
 NAME SPACES
 
 ---->SYSTEM.IO 
 * DESCRIPTION : It is used for reading documents .

 ------------------------------------------------------------------------------------------------------------
 Naming Conventions 
 
 --->txtBOX: this naming conventions is used for textbox for desired input or output.
 --->Cls_:this naming conventions is used for creating class object.
 
-------------------------------------------------------------------------------------------------------------
Public Methods
 --->POPULATE TREE
 * Description : Create document tree view when called.
 --->GetDrives :
 * Description : Get all the logical drives when called.
 
-------------------------------------------------------------------------------------------------------------

*************************************************************************************************************/







    public partial class ExtractedTextViewer : Telerik.WinControls.UI.RadForm
    {

        Cls_FileViewer de = new Cls_FileViewer();
       
        public ExtractedTextViewer()
        {
            


            InitializeComponent();
            Thread browse = new Thread(new ThreadStart(filldropdownMenu));
            browse.Start();
            CheckForIllegalCrossThreadCalls = false;
          
        }
 
        public void PopulateTree(string dir, RadTreeNode node)
        {
           
            //DirectoryInfo directory = new DirectoryInfo(dir);
           
            //foreach (DirectoryInfo d in directory.GetDirectories())
            //{
               
            //    RadTreeNode t = new RadTreeNode(d.Name);
               
           
              
            //    PopulateTree(d.FullName, t);
            //    //node.Nodes.Add(t); // add the node to the "master" node
            //    treeView1.Nodes.Add(t);
            //   treeView1.Nodes.Add(d.Name);
            //}
            //// lastly, loop through each file in the directory, and add these as nodes
            //foreach (FileInfo f in directory.GetFiles())
            //{
            //    // create a new node
            //    RadTreeNode k = new RadTreeNode(f.Name);
              
       
            //    node.Nodes.Add(k);
          
            //    treeView1.Nodes.Add(k);

               
            //}
        }
      
        
        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {





        
           




           

            #region old code
            //try
            //{
            //    txtBOX1.Clear();
            //    string filename = radTreeView1.SelectedNode.Text;

            //    FileStream fs = new FileStream(@"Processedfiles\" + filename, FileMode.Open, FileAccess.ReadWrite);
            //    byte[] read = new byte[4068];
            //    fs.Read(read, 0, read.Length);
            //    fs.Close();

            //    string showtext = Encoding.ASCII.GetString(read);
            //    txtBOX1.Text += showtext;

            //}
            //catch (Exception ex)
            //{
            //    ex.ToString();
            //}
            #endregion 

        }


        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

            //if (radDropDownList1.SelectedItem.Text == "TextMined Files")
            //{
            //    DirectoryInfo dr = new DirectoryInfo(@"Processedfiles");
            //    RadTreeNode tree1 = new RadTreeNode();
            //    tree1 = radTreeView1.Nodes.Add("TextMinedDocuments");
            //    tree1.ImageIndex = 2;
            //    foreach (FileInfo ff in dr.GetFiles())
            //    {
            //        string a = Convert.ToString(ff);

            //        tree1.Nodes.Add(a).ImageIndex = 1;
                    
                   

            //    }



            //}
            //else if(radDropDownList1.SelectedItem.Text=="C:Drive")
            //{

            //    radTreeView1.Nodes.Add("No Drive Selected");


            //}






        }
      
        private void RadForm2_Load(object sender, EventArgs e)
        {
           // de.CreateTree(this.radTreeView1);




        }

        private void radTreeView1_NodeExpandedChanged(object sender, RadTreeViewEventArgs e)
        {
           
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            Cls_FileViewer.Documets.RemoveRange(0, Cls_FileViewer.Documets.Count);           ///Remove previous file on new selection.//...
            Cls_FileViewer.docId.RemoveRange(0, Cls_FileViewer.docId.Count);                ///Remove DocId//.........
            Cls_FileViewer.ConceptID.RemoveRange(0, Cls_FileViewer.ConceptID.Count);
            Cls_FileViewer.Conceptsname.RemoveRange(0, Cls_FileViewer.Conceptsname.Count);
            treeView1.Nodes.Clear();                                                     ///clear old nodes in tree view.//....
            DocumentsMethod();

        }
        public void filldropdownMenu()
        {
            string rtrnAll = null;
            string SelectConcept = "SELECT CONCEPT FROM CONCEPTS";
            Cls_FileViewer fileviewer = new Cls_FileViewer();
            fileviewer.getAllConcepts(SelectConcept, rtrnAll);
            string[] Allconcetps = Cls_FileViewer.Conceptsname.ToArray();


     
            foreach (string data in Allconcetps)
            {
                //radDropDownList2 = new RadDropDownList();
                radDropDownList2.Items.Add(data);



            }








        }





        public void DocumentsMethod()
        {
            int ID=0;
            int DocId=0;
            string Docnames=null;
            string selectedDoc = radDropDownList2.SelectedItem.ToString();

            Cls_FileViewer fileVw = new Cls_FileViewer();


            string getConceptIDquerry = "select conceptid from concepts where concept=" + "'" + selectedDoc + "'";

            fileVw.getconceptId(getConceptIDquerry, ID);

            int[] conceptsID = Cls_FileViewer.ConceptID.ToArray();



            for(int i=0; i<conceptsID.Length; i++)
            {
                string getDocIDQuerry = "select docid from condocument where conid=" + "" + conceptsID[i] + ""+"and frequency>0";
                fileVw.getDocumentsID(getDocIDQuerry, DocId);
            }

            int[] DocumentsID = Cls_FileViewer.docId.ToArray();


            for (int j = 0; j < DocumentsID.Length; j++)
            {

                string DocNamesQuerry = "Select Docname from Documents where DocID=" + "" + DocumentsID[j] + "";
                fileVw.DocumentsName(DocNamesQuerry, Docnames);

            }
            string[] docuemntsName = Cls_FileViewer.Documets.ToArray();

            foreach (string Mydoc in docuemntsName)
            {

                treeView1.Nodes.Add(Mydoc).ImageIndex = 1;
            }


        }
        public void browseFile()
        {







        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            //try
            //{


                if (treeView1 != null)
                {

                    string filename = e.Node.ToString();


                    string[] splitChar = filename.Split(':');
                    string filenameOrig = splitChar[1];
                    string trimed = filenameOrig.Replace("\"", "");
                    string[] replaceSpace = trimed.Split(' ');
                  //  Regex.Unescape(filenameOrig);
                    if (filename != "")
                    {



                        StreamReader readfile = new StreamReader(@"C:\Users\saifee\Documents\R\win-library\2.13\tm\texts\txt\"+replaceSpace[1]);
                        while (readfile.EndOfStream == false)
                        {

                            string data = readfile.ReadToEnd();
                            txtBOX1.Text = data;





                        }



                    }
                }
            //}
            //catch(Exception ex)
            //{
            //    ex.ToString();
            //}
         

        }




    }
}
