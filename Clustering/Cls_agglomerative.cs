using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Telerik.WinControls.UI;

namespace Final_Year_Project_2
{
/***********************************************************************************************************
 
    NAME SPACES
 
    ---->SYSTEM.IO 
    * DESCRIPTION : It is used for reading documents .
    ---->System.Linq
    * Description : It is used for enumerable functions for iterating array values
    ---->System.Text.RegularExpression
    * Description  : It is used for Text Extraction and separation of special characters from the Documents
   ------------------------------------------------------------------------------------------------------------
  
   -------------------------------------------------------------------------------------------------------------
   Public Methods
    --->PerformClustering
     * Description: This method take matrixfilepath as an input error will occur if null .else create tree.
 
   -------------------------------------------------------------------------------------------------------------
    Public Variables
    --->list- LST
    * type :Double
    --->SingleLinkageMin
    * type :Double
    --->list- ClusterList1
    * type :Double 
    --->list- ClusterList2
    * type :Double
    --->CompleteLinkageMax
    * type :Double 
    --->array- DocumentFrequency1
    * type :int
    --->array- DocumentFrequency2
    * type :int
    --->array- Allcosines
    * type :double
    --->Tree
    * type :TreeNode
    --->Tree2
    * type :TreeNode
    --->Similarities
    * type :Double
    --->myresult
    * type :String 
-------------------------------------------------------------------------------------------------------------
***************************************************************************************************************/









    #region Class Agglomerative

    public class Cls_agglomerative
    {


        

        #region Agglomerative variables
        /// <summary>
        /// ////Variables for Agglomerative Hiearchical Clustering..,,,,,,,,,,,,
        /// </summary>
        /// 



        public List<double> lst = new List<double>();  //for cosine values//..............
        public double singlelinkageMin;            //for singlelinkage clustering....///
        public List<double> clusterlist1 = new List<double>();
        public List<double> clusterlist2 = new List<double>();


        public delegate string add(string abc);     ///for tree view collision with thread//....

        public double completelinkageMAx;         //for clustering ...


        int[] documentfrequency1 = null;
        int[] documentfrequency2 = null;

        public double[] allcosines = null;




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

        public string[] Results = null;
        public string filepath = null;

        public string myresult = null;

        //public string filepathformatrix = null;

        public RadTreeNode tree = new RadTreeNode();
        public RadTreeNode tree2 = new RadTreeNode();





        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
        OpenFileDialog openfiledialog = new OpenFileDialog();

        #endregion

        #region MethodPerformClustering
        ////////////Clustering//...........................////////////////
        public void performclustering(string filepathformatrix, string method)
        {

            try
            {
                List<object> names = new List<object>();                 //list for adding names and Cosine angle between Documents//..............
                List<string> valuesonly = new List<string>();           //only cosine values //...
                List<int> ListForMerging = new List<int>();            //list containing index of those document needed to merge //...............
                List<int> minimumFreq = new List<int>();              //Comparing Document Frequency here//.................for minimum one/.....


                List<string> forFileFREQ = new List<string>();         //This list will contain document names and frequency for while loop//................

                List<string> PrintTree = new List<string>();                                            //print Merged documents to the tree view//...........................................
                string mergeDocForTree = null;


                // tree.Nodes.Clear();    ////clearing old nodes/...........
                // tree2.Nodes.Clear();   ///clearing old nodes//...........



                int counter = 0;


                object[] checkingmin = null;

                object namestoadd = null;


                if (filepathformatrix != null)
                {

                    StreamReader sr = new StreamReader(filepathformatrix);


                    //radTreeView1.Nodes.Clear();

                    ////use less code//..../..........

                    clusterlist1.RemoveRange(0, clusterlist1.Count);                  //empty all clusters from list singlelinkage//...
                    clusterlist2.RemoveRange(0, clusterlist2.Count);     //empty all clusters from list completer linkage//....
                    ///adding heading to tree view/....................................
                    lst.RemoveRange(0, lst.Count);

                    ////use less code ends here///.............................

                    while (sr.EndOfStream == false)
                    {

                        string alldata = sr.ReadToEnd();                  //read all data from matrix file
                        char[] mychar = new char[] { '\n' };                   //split using newline 
                        string[] myarray = alldata.Split(mychar);
                        string[] myarray1 = myarray;         //get all data into an array//.....


                        string[] onlyFilenameAndFreq = new string[myarray1.Length - 1];           //maintain Doc name and freq and update of doc....doc1-2 etc
                        Array.Copy(myarray1, 1, onlyFilenameAndFreq, 0, myarray1.Length - 1);





                        //Tree view heading here//.....................................

                        //........................................................

                        string[] filefreq = onlyFilenameAndFreq;



                        if (method == "Single Linkage")
                        {
                            while (filefreq.Length > 1)              //loop till one element remains.
                            {

                                forFileFREQ = filefreq.ToList(); //conversion to list and inserting to new list

                                for (int i = 0; i < filefreq.Length; i++)
                                {

                                    string s = filefreq[i];                                //to get only concepts frequency..,,,,///

                                    char[] freq = new char[] { '\t' };

                                    string[] getf1 = s.Split(freq);

                                    //only for adding file name to the tree//.


                                    string filename1 = getf1[0];



                                    //.//....................................






                                    string[] targetedfreq1 = new string[getf1.Length - 1];

                                    Array.Copy(getf1, 1, targetedfreq1, 0, getf1.Length - 1);

                                    string[] DocumentFreq1 = targetedfreq1;
                                    documentfrequency1 = Array.ConvertAll<string, int>(DocumentFreq1, Convert.ToInt32);




                                    for (int j = 0; j < filefreq.Length; j++)
                                    {

                                        string t = filefreq[j];

                                        char[] freq1 = new char[] { '\t', '\n' };

                                        string[] getf2 = t.Split(freq1);


                                        //only for adding file name to the tree//.


                                        string filename2 = getf2[0];



                                        //.....////...........................




                                        string[] targetedfreq2 = new string[getf2.Length - 1];


                                        Array.Copy(getf2, 1, targetedfreq2, 0, getf2.Length - 1);

                                        string[] DocumentFreq2 = targetedfreq2;


                                        documentfrequency2 = Array.ConvertAll<string, int>(DocumentFreq2, Convert.ToInt32);



                                        //all document frequecny will be used for cosine formula's below.....
                                        ////the vector of more than two document will be used for clustering//,,,,,
                                        //////////////
                                        /////...
                                        ////
                                        ///...
                                        ///

                                        ///breaking loop for fullfilling requirments//....
                                        if (j <= i)
                                        {

                                            continue;
                                        }
                                        else if (j > i)
                                        {
                                            //changes ///,......

                                            double dotproduct = Enumerable.Range(0, documentfrequency1.Length).Sum(g => documentfrequency1[g] * documentfrequency2[g]);

                                            ///changes///...

                                            //norm of two vectors//....
                                            double normD1 = Enumerable.Range(0, documentfrequency1.Length).Sum(g => documentfrequency1[g] * documentfrequency1[g]);
                                            double normD2 = Enumerable.Range(0, documentfrequency2.Length).Sum(g => documentfrequency2[g] * documentfrequency2[g]);

                                            ///final norm/...
                                            double NormD1 = Math.Sqrt(normD1);
                                            double NormD2 = Math.Sqrt(normD2);


                                            //////euclidean formula similarities of documents

                                            double Distance = dotproduct / (NormD1 * NormD2);


                                            //distance in radians//...
                                            double DistanceRad = Math.PI * Distance / 180.0;



                                            //final ans//...cosine//...
                                            similarities = Math.Cos(DistanceRad);

                                            double similaritiesFinal = Math.Acos(similarities);               //Cos Inverse here

                                            namestoadd = filename1 + "," + filename2 + ":" + similaritiesFinal;

                                            //textBox1.Text += similarities + "\r\n";


                                        }

                                        lst.Add(similarities);    //use less/....          //adding all cosine to list aRRAY 

                                        lst.Sort();          //use less/....


                                        ///
                                        names.Add(namestoadd);



                                    }



                                }
                                object[] io = names.ToArray();  //only for display filenames and cosine similarities between files...


                                string[] iostring = Array.ConvertAll<object, string>(io, Convert.ToString);     ///New cosine will be add at every loop....


                                char[] oosplit = new char[] { ':' };

                                for (int o = 0; o < iostring.Length; o++)
                                {


                                    string newlinesplit = iostring[o];


                                    string[] tosplit = newlinesplit.Split(oosplit);


                                    for (int p = 1; p < tosplit.Length; p++)
                                    {


                                        string psplit = tosplit[p];


                                        valuesonly.Add(psplit);




                                    }


                                    checkingmin = valuesonly.ToArray();


                                    ///this value will match to array list and it will merge those document who have minimum cosines....


                                }


                                object minimumCosinesbtwDoc = Enumerable.Range(0, checkingmin.Length).Min(m => checkingmin[m]);   ///to check consines minimum between doc like doc1 and doc2 doc1 and doc 3 etc,.,,,, 



                                ///here we are using cosine minimum of doc index to use it for merging doc ......///,....
                                ///
                                int valueindex = valuesonly.FindIndex(item => item == minimumCosinesbtwDoc);



                                //merging those who are closer first//............

                                object mergeDoc = io[valueindex];
                                string mergDocString = mergeDoc.ToString();


                                for (int fq = 0; fq < filefreq.Length; fq++)
                                {

                                    string[] mergedocument = mergDocString.Split(',', ':');

                                    for (int mg = 0; mg < mergedocument.Length - 1; mg++)
                                    {


                                        if (mg <= fq)
                                        {
                                            Regex rr = new Regex(mergedocument[mg]);
                                            Match matches = rr.Match(filefreq[fq]);


                                            if (matches.Success == true)
                                            {

                                                ListForMerging.Add(fq);
                                            }
                                            continue;

                                        }
                                        else if (mg > fq)
                                        {
                                            break;
                                        }


                                    }



                                }

                                int[] newindex = ListForMerging.ToArray();



                                //now merging documents using newindex //....
                                for (int merge = 0; merge < newindex.Length - 1; merge++)
                                {

                                    int value1 = newindex[merge];       //index of closed matching Document/...........
                                    ////using this  index value merge string[]filefreq index with each other 

                                    string getDoc1 = filefreq[value1];


                                    string[] getDocument1 = getDoc1.Split('\t', '\n');

                                    string getDocName1 = getDocument1[0];

                                    string[] getDocFreq1 = new string[getDocument1.Length - 1];

                                    Array.Copy(getDocument1, 1, getDocFreq1, 0, getDocument1.Length - 1);

                                    int[] Document1Freq = Array.ConvertAll<string, int>(getDocFreq1, Convert.ToInt32);






                                    for (int nmer = 0; nmer < newindex.Length; nmer++)
                                    {



                                        if (nmer == merge)
                                        {

                                            continue;

                                        }
                                        else if (nmer > merge)
                                        {

                                            int value2 = newindex[nmer];               //index of closed matching document//........




                                            string getDoc2 = filefreq[value2];

                                            string[] getDocument2 = getDoc2.Split('\t', '\n');

                                            string getDocName2 = getDocument2[0];

                                            string[] getDocFreq2 = new string[getDocument2.Length - 1];

                                            Array.Copy(getDocument2, 1, getDocFreq2, 0, getDocument2.Length - 1);

                                            int[] Document2Freq = Array.ConvertAll<string, int>(getDocFreq2, Convert.ToInt32);






                                            for (int df = 0; df < Document1Freq.Length; df++)
                                            {




                                                int frq1 = Document1Freq[df];

                                                for (int df1 = 0; df1 < Document2Freq.Length; df1++)
                                                {

                                                    if (df == df1)                                    ///for finding minimum frequencies of two documents../////////////////////
                                                    ///
                                                    {

                                                        int frq2 = Document2Freq[df1];


                                                        int min = Math.Min(frq1, frq2);                ///minimum Because of Single Linkage Method//.............

                                                        minimumFreq.Add(min);                       //adding Frequencies two an array list //...................
                                                        ///////////////////////////////////////////////.............

                                                    }
                                                    else if (df1 < df)
                                                    {
                                                        continue;


                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }

                                                }


                                            }

                                            int[] mergedFile = minimumFreq.ToArray();

                                            string[] mergedfileS = Array.ConvertAll<int, string>(mergedFile, Convert.ToString);


                                            forFileFREQ.RemoveAt(value2);
                                            forFileFREQ.RemoveAt(value1);   ///removing First Doc//.. ///removing Second Doc/....
                                            ///

                                            string allmergFReq = string.Join("\t", mergedfileS);


                                            //For tree Only


                                            string MergedDocAndFreq = getDocName1 + "-" + getDocName2 + "\t" + allmergFReq;



                                            forFileFREQ.Add(MergedDocAndFreq);         ///adding newmerged Doc and Frequency to List.....



                                        }
                                    }
                                }

                                string[] copytoFileFreq = forFileFREQ.ToArray();

                                filefreq = copytoFileFreq;




                                ////////////////..............Tree View.................................////////////////////////////.....


                                for (int tr = 0; tr < filefreq.Length; tr++)
                                {

                                    string printing = filefreq[tr];

                                    string[] printing1 = printing.Split('\t');

                                    for (int op = 0; op < filefreq.Length; op++)
                                    {

                                        if (op == tr)
                                        {

                                            string pp = printing1[0];

                                            PrintTree.Add(pp);
                                            break;
                                        }
                                        else if (op > tr)
                                        {
                                            break;
                                        }
                                    }



                                }


                                Results = PrintTree.ToArray();

                                counter++;
                                tree = tree2.Nodes.Add("Doc Cluster" + counter);


                                foreach (string Treetoprint in Results)
                                {

                                    tree.Nodes.Add(Treetoprint);

                                }

                                ///........................End Tree view..............................////////////////////

                                names.RemoveRange(0, names.Count);               //Removing Previous Values of document names and frequency/...........
                                valuesonly.RemoveRange(0, valuesonly.Count);    //Removing previous values  only cosiness/.......................
                                ListForMerging.RemoveRange(0, ListForMerging.Count);//Removing index of previos merged documents//..................
                                minimumFreq.RemoveRange(0, minimumFreq.Count); // Removing single likage min freq of two doc EG. Doc1- Doc2....
                                PrintTree.RemoveRange(0, PrintTree.Count);     //same as above;;..............

                            }
                        }
                        else if (method == "Complete Linkage")
                        {


                            while (filefreq.Length > 1)              //loop till one element remains.
                            {

                                forFileFREQ = filefreq.ToList(); //conversion to list and inserting to new list

                                for (int i = 0; i < filefreq.Length; i++)
                                {

                                    string s = filefreq[i];                                //to get only concepts frequency..,,,,///

                                    char[] freq = new char[] { '\t' };

                                    string[] getf1 = s.Split(freq);

                                    //only for adding file name to the tree//.


                                    string filename1 = getf1[0];



                                    //.//....................................






                                    string[] targetedfreq1 = new string[getf1.Length - 1];

                                    Array.Copy(getf1, 1, targetedfreq1, 0, getf1.Length - 1);

                                    string[] DocumentFreq1 = targetedfreq1;
                                    documentfrequency1 = Array.ConvertAll<string, int>(DocumentFreq1, Convert.ToInt32);




                                    for (int j = 0; j < filefreq.Length; j++)
                                    {

                                        string t = filefreq[j];

                                        char[] freq1 = new char[] { '\t', '\n' };

                                        string[] getf2 = t.Split(freq1);


                                        //only for adding file name to the tree//.


                                        string filename2 = getf2[0];



                                        //.....////...........................




                                        string[] targetedfreq2 = new string[getf2.Length - 1];


                                        Array.Copy(getf2, 1, targetedfreq2, 0, getf2.Length - 1);

                                        string[] DocumentFreq2 = targetedfreq2;


                                        documentfrequency2 = Array.ConvertAll<string, int>(DocumentFreq2, Convert.ToInt32);



                                        //all document frequecny will be used for cosine formula's below.....
                                        ////the vector of more than two document will be used for clustering//,,,,,
                                        //////////////
                                        /////...
                                        ////
                                        ///...
                                        ///

                                        ///breaking loop for fullfilling requirments//....
                                        if (j <= i)
                                        {

                                            continue;
                                        }
                                        else if (j > i)
                                        {
                                            //changes ///,......

                                            double dotproduct = Enumerable.Range(0, documentfrequency1.Length).Sum(g => documentfrequency1[g] * documentfrequency2[g]);

                                            ///changes///...

                                            //norm of two vectors//....
                                            double normD1 = Enumerable.Range(0, documentfrequency1.Length).Sum(g => documentfrequency1[g] * documentfrequency1[g]);
                                            double normD2 = Enumerable.Range(0, documentfrequency2.Length).Sum(g => documentfrequency2[g] * documentfrequency2[g]);

                                            ///final norm/...
                                            double NormD1 = Math.Sqrt(normD1);
                                            double NormD2 = Math.Sqrt(normD2);


                                            //////euclidean formula similarities of documents

                                            double Distance = dotproduct / (NormD1 * NormD2);


                                            //distance in radians//...
                                            double DistanceRad = Math.PI * Distance / 180.0;



                                            //final ans//...cosine//...
                                            similarities = Math.Cos(DistanceRad);

                                            double similaritiesFinal = Math.Acos(similarities);               //Cos Inverse here

                                            namestoadd = filename1 + "," + filename2 + ":" + similaritiesFinal;

                                            //textBox1.Text += similarities + "\r\n";


                                        }

                                        lst.Add(similarities);    //use less/....          //adding all cosine to list aRRAY 

                                        lst.Sort();          //use less/....


                                        ///
                                        names.Add(namestoadd);



                                    }



                                }
                                object[] io = names.ToArray();  //only for display filenames and cosine similarities between files...


                                string[] iostring = Array.ConvertAll<object, string>(io, Convert.ToString);     ///New cosine will be add at every loop....


                                char[] oosplit = new char[] { ':' };

                                for (int o = 0; o < iostring.Length; o++)
                                {


                                    string newlinesplit = iostring[o];


                                    string[] tosplit = newlinesplit.Split(oosplit);


                                    for (int p = 1; p < tosplit.Length; p++)
                                    {


                                        string psplit = tosplit[p];


                                        valuesonly.Add(psplit);




                                    }


                                    checkingmin = valuesonly.ToArray();


                                    ///this value will match to array list and it will merge those document who have minimum cosines....


                                }


                                object minimumCosinesbtwDoc = Enumerable.Range(0, checkingmin.Length).Min(m => checkingmin[m]);   ///to check consines minimum between doc like doc1 and doc2 doc1 and doc 3 etc,.,,,, 



                                ///here we are using cosine minimum of doc index to use it for merging doc ......///,....
                                ///
                                int valueindex = valuesonly.FindIndex(item => item == minimumCosinesbtwDoc);



                                //merging those who are closer first//............

                                object mergeDoc = io[valueindex];
                                string mergDocString = mergeDoc.ToString();


                                for (int fq = 0; fq < filefreq.Length; fq++)
                                {

                                    string[] mergedocument = mergDocString.Split(',', ':');

                                    for (int mg = 0; mg < mergedocument.Length - 1; mg++)
                                    {


                                        if (mg <= fq)
                                        {
                                            Regex rr = new Regex(mergedocument[mg]);
                                            Match matches = rr.Match(filefreq[fq]);


                                            if (matches.Success == true)
                                            {

                                                ListForMerging.Add(fq);
                                            }
                                            continue;

                                        }
                                        else if (mg > fq)
                                        {
                                            break;
                                        }


                                    }



                                }

                                int[] newindex = ListForMerging.ToArray();



                                //now merging documents using newindex //....
                                for (int merge = 0; merge < newindex.Length - 1; merge++)
                                {

                                    int value1 = newindex[merge];       //index of closed matching Document/...........
                                    ////using this  index value merge string[]filefreq index with each other 

                                    string getDoc1 = filefreq[value1];


                                    string[] getDocument1 = getDoc1.Split('\t', '\n');

                                    string getDocName1 = getDocument1[0];

                                    string[] getDocFreq1 = new string[getDocument1.Length - 1];

                                    Array.Copy(getDocument1, 1, getDocFreq1, 0, getDocument1.Length - 1);

                                    int[] Document1Freq = Array.ConvertAll<string, int>(getDocFreq1, Convert.ToInt32);






                                    for (int nmer = 0; nmer < newindex.Length; nmer++)
                                    {



                                        if (nmer == merge)
                                        {

                                            continue;

                                        }
                                        else if (nmer > merge)
                                        {

                                            int value2 = newindex[nmer];               //index of closed matching document//........




                                            string getDoc2 = filefreq[value2];

                                            string[] getDocument2 = getDoc2.Split('\t', '\n');

                                            string getDocName2 = getDocument2[0];

                                            string[] getDocFreq2 = new string[getDocument2.Length - 1];

                                            Array.Copy(getDocument2, 1, getDocFreq2, 0, getDocument2.Length - 1);

                                            int[] Document2Freq = Array.ConvertAll<string, int>(getDocFreq2, Convert.ToInt32);






                                            for (int df = 0; df < Document1Freq.Length; df++)
                                            {




                                                int frq1 = Document1Freq[df];

                                                for (int df1 = 0; df1 < Document2Freq.Length; df1++)
                                                {

                                                    if (df == df1)                                    ///for finding minimum frequencies of two documents../////////////////////
                                                    ///
                                                    {

                                                        int frq2 = Document2Freq[df1];


                                                        int min = Math.Max(frq1, frq2);                ///minimum Because of Single Linkage Method//.............

                                                        minimumFreq.Add(min);                       //adding Frequencies two an array list //...................
                                                        ///////////////////////////////////////////////.............

                                                    }
                                                    else if (df1 < df)
                                                    {
                                                        continue;


                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }

                                                }


                                            }

                                            int[] mergedFile = minimumFreq.ToArray();

                                            string[] mergedfileS = Array.ConvertAll<int, string>(mergedFile, Convert.ToString);


                                            forFileFREQ.RemoveAt(value2);
                                            forFileFREQ.RemoveAt(value1);   ///removing First Doc//.. ///removing Second Doc/....
                                            ///

                                            string allmergFReq = string.Join("\t", mergedfileS);


                                            //For tree Only


                                            string MergedDocAndFreq = getDocName1 + "-" + getDocName2 + "\t" + allmergFReq;



                                            forFileFREQ.Add(MergedDocAndFreq);         ///adding newmerged Doc and Frequency to List.....



                                        }
                                    }
                                }

                                string[] copytoFileFreq = forFileFREQ.ToArray();

                                filefreq = copytoFileFreq;




                                ////////////////..............Tree View.................................////////////////////////////.....


                                for (int tr = 0; tr < filefreq.Length; tr++)
                                {

                                    string printing = filefreq[tr];

                                    string[] printing1 = printing.Split('\t');

                                    for (int op = 0; op < printing1.Length; op++)
                                    {

                                        if (op == tr)
                                        {

                                            string pp = printing1[0];

                                            PrintTree.Add(pp);
                                            break;
                                        }
                                        else if (op > tr)
                                        {
                                            break;
                                        }
                                    }



                                }


                                Results = PrintTree.ToArray();

                                counter++;
                                tree = tree2.Nodes.Add("Doc Cluster" + counter);


                                foreach (string Treetoprint in Results)
                                {

                                    tree.Nodes.Add(Treetoprint);

                                }

                                ///........................End Tree view..............................////////////////////

                                names.RemoveRange(0, names.Count);               //Removing Previous Values of document names and frequency/...........
                                valuesonly.RemoveRange(0, valuesonly.Count);    //Removing previous values  only cosiness/.......................
                                ListForMerging.RemoveRange(0, ListForMerging.Count);//Removing index of previos merged documents//..................
                                minimumFreq.RemoveRange(0, minimumFreq.Count); // Removing single likage min freq of two doc EG. Doc1- Doc2....
                                PrintTree.RemoveRange(0, PrintTree.Count);     //same as above;;..............

                            }


                        }

                    }


                }
             
                else
                {
                    MessageBox.Show("Open Matrix File First For Clustering", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public RadTreeNode Node
        {
            get
            {
                return tree2;

            }
            set
            {

                tree = value;
            }




        }



    }
        #endregion
}
    #endregion