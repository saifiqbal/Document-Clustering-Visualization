using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Telerik.WinControls.UI;
using System.Threading;

/***********************************************************************************************************
 
 NAME SPACES
 
 ---->SYSTEM.IO 
 * DESCRIPTION : It is used for reading documents .
 ---->System.Linq
 * Description : It is used for enumerable functions for iterating array values
 ---->System.Threading 
 * Description : It is used for enaabling background worker for fast reading and writing Text from Documents.
 ------------------------------------------------------------------------------------------------------------
 Naming Conventions 
 
 --->txtBOX: this naming conventions is used for textbox for desired input or output.
 --->Cls_:this naming conventions is used for creating class object.
 
-------------------------------------------------------------------------------------------------------------
Public Methods
 --->onlyReadFile
 * Description : Read Documents when call.
 --->ReadFromFolder
 * Description : Read Files From Folder when Call.
 --->GetAgglo
 * Description : perform clustering when call.
 
-------------------------------------------------------------------------------------------------------------
 Public Variables
 --->Similarities
 * type :Double
 --->Mypath
 * type :String
 --->FilePathForMatrix
 * type :string
 
-------------------------------------------------------------------------------------------------------------

*************************************************************************************************************/






namespace Final_Year_Project_2
{

    public delegate void reportFileReading(string data);      ///for printing readed text at every while loop...

    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {

        public RadForm1()
        {
            InitializeComponent();
        }




        #region Variabels
        //class openfolder.cs///......
        Cls_openfolder openfolder1 = new Cls_openfolder();
        //class openfolder.cs//..........

        static readonly char[] space = { '\t' };
        //static readonly StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries; 



        public double similarities;
        public string mypath = null;

       
        //class openfile.cs//.....
        Cls_openfile opfile = new Cls_openfile();
        
        //class openfile.cs//......
        
        
        public string filepath = null;


        public string filepathformatrix = null;


        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

        #endregion
        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {

                radTreeView1.Nodes.Clear();
                RadForm1 frm = new RadForm1();
                frm.Refresh();                   //remove all the previous cluster for new operations...
                opfile.filedialogshowFormatrix();
                filepathformatrix = opfile.getfilepath;
                

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void radButton2_Click(object sender, EventArgs e)
        {


            radTreeView1.Nodes.Clear();
            getAgglo();
          
        }
        public void getAgglo()
        {

            string method = null;
            Cls_agglomerative hClust = new Cls_agglomerative();
            string matrixpath= opfile.getfilepath;

            if (radCheckBox1.Checked==true)
            {
                method = radCheckBox1.Text;
                hClust.performclustering(matrixpath,method);


                radTreeView1.Nodes.Add("Hiearchical Clustering Single Linkage");

                radTreeView1.Nodes.Add(hClust.Node);

            }
            else if (radCheckBox2.Checked==true)
            {
                method = radCheckBox2.Text;

                hClust.performclustering(matrixpath, method);


                radTreeView1.Nodes.Add("Hiearchical Clustering Complete Linkage");

                radTreeView1.Nodes.Add(hClust.Node);




            }
            else
            {
                MessageBox.Show("Please select a Clustering Method", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            

        }
        public void onlyReadFile()
        {
            CheckForIllegalCrossThreadCalls = false;

            Cls_filereading reading = new Cls_filereading();


            Cls_filereading.report += new reportFileReading(readText);
            reading.fileread(filepath);
         
        }
        public void readText(string alldata)
        {
            txtBOX1.Text += Cls_filereading.AllData;




        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {

                txtBOX1.Clear();

                opfile.filedialogshow();
                filepath = opfile.getfilepath;
                if (filepath != "")
                {
                    radWaitingBar1.Visible = true;
                    radWaitingBar1.StartWaiting();
                    label1.Text = "Please Wait!!";
                   // radWaitingBar1.Text = "Please Wait";
                    backgroundWorker1.RunWorkerAsync();
                    


                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;

           // radWaitingBar1.StartWaiting();
            onlyReadFile();
           // radWaitingBar1.EndWaiting();
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            radWaitingBar1.EndWaiting();
            label1.Text = "Done !!";
        
           

        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("File have been processed sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.ShowDialog();
            string c = sv.FileName.ToString();

            sv.SupportMultiDottedExtensions = true;

            if (sv.FileName != "")
            {


                StreamWriter sw = new System.IO.StreamWriter(c);
                object writeData = txtBOX1.Text;
               
                sw.Write(writeData);
                sw.Close();

            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // radProgressBar1.Value1 = e.ProgressPercentage;
        }

        public void readfromFolder()
        {
            CheckForIllegalCrossThreadCalls = false;
            Cls_folderreading fr = new Cls_folderreading();
            fr.folderBrowser(mypath);
            txtBOX1.Text += fr.Retrtxt;
            txtBOX1.Clear();
            txtBOX1.Text += fr.RetrDocx;
            txtBOX1.Clear();
            txtBOX1.Text += fr.Retrhtml;
            txtBOX1.Clear();
            txtBOX1.Text += fr.Retrpdf;
            txtBOX1.Clear();

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            txtBOX1.Clear();
            openfolder1.folderpath();
            mypath = openfolder1.getpath;


            if (mypath != "")
            {
                radWaitingBar1.Visible = true;
                radWaitingBar1.StartWaiting();
                label1.Text = "Please Wait!!";
                backgroundWorker2.RunWorkerAsync();

            }

        

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            readfromFolder();
            radWaitingBar1.EndWaiting();
            label1.Text = "Done !!";


           
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("All file have been processed sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radCheckBox2.Checked = false;
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radCheckBox1.Checked = false;
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            txtBOX1.Clear();

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
           // radWaitingBar1.StartWaiting();

            Cls_SaveConcepts clsSave = new Cls_SaveConcepts();

            clsSave.RemoveConcepts();
            clsSave.RemoveDocuments();



            if (filepathformatrix != null)
            {
                // Cls_SaveConcepts.changedpercentage+=new UpdateProgress(progress_changed);

                clsSave.SaveConcepts(filepathformatrix);
            }
            else
            {
                MessageBox.Show("Please select a matrix file first", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
        void progress_changed()
        {

            //progressBar1.Maximum = Cls_SaveConcepts.Docid;

           // progressBar1.Value++;
       


        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            
            if (backgroundWorker1.IsBusy == true)
            {
                backgroundWorker1.CancelAsync();
              
            }
            else if (backgroundWorker2.IsBusy == true)
            {
                backgroundWorker2.CancelAsync();


            }



         
        }





    }
}