using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Word;

namespace Final_Year_Project_2
{
    /***********************************************************************************************************
 
    NAME SPACES
 
    ---->SYSTEM.IO 
    * DESCRIPTION : It is used for reading documents .
    ---->System.Text.RegularExpression
    * Description  : It is used for Text Extraction and separation of special characters from the Documents
    ---->System.Threading 
    * Description : It is used for enaabling background worker for fast reading and writing Text from Documents.
    ---->Microsoft.Office.Interop.Word
    * Description : Enable c# to work with word documents.
    ------------------------------------------------------------------------------------------------------------

   Public Methods
    --->FolderBrowser
    * Description : ReadFiles from folder and extract text when called.
   
   public Functions
    --->RetrHtml
    * Description : return text from html file.
    --->RetrPdf
    * Description : return text from pdf
    --->RetrDocx
    * Description : return text from word doc.
    
 
   -------------------------------------------------------------------------------------------------------------
     Public Variables
   --->htmlText
   * type :String
   --->PdfText
   * type :string
   --->DocxText
   * type :string
   --->txtText
   * type :string  

   *************************************************************************************************************/






    class Cls_folderreading
    {


        Cls_openfolder openfolder1 = new Cls_openfolder();       /////

        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();           ///word file reader variable...//...for word documents..,.....

        public string htmlText;           
        public string pdfText;                   
        public string docxText;
        public string txtText;


        public void folderBrowser(string path)
        {


           
         


            if (path != "")
            {
                string[] files = Directory.GetFiles(path);
                for (int a = 0; a < files.Length; a++)
                {

                    // int counter = 0;
                    string s = files[a];

                    char[] tosplit = new char[] { '.' };

                    string[] splitwords = s.Split(tosplit);
                    string myfilename = splitwords[1];

                    if (myfilename == "htm")
                    {
                        StreamReader sr = new System.IO.StreamReader(s);


                        try
                        {
                            //for html files.....

                            while (sr.EndOfStream == false)
                            {
                                string data = sr.ReadLine();
                                string newFormation = Regex.Replace(data, @"</?\w+((\s+\w+(\s*=\s*(?:"".*?""|'.*?'|[^'"">\s]+))?)+\s*|\s*)/?>", string.Empty, RegexOptions.Singleline);
                                htmlText += newFormation.ToString();


                                char[] togetfilename = new char[] { '\\' };
                                string[] getfilename = s.Split(togetfilename);


                                string toeliminateExt = getfilename[5];
                                string[] EliminateExt = toeliminateExt.Split(tosplit);
                                string savefilename = EliminateExt[0];

                                StreamWriter stw = new StreamWriter(@"ProcessedFiles\"+savefilename + ".txt");
                                string datatoWrite = htmlText;
                                stw.WriteLine(datatoWrite);
                                stw.Close();





                            }
                            //textBox1.Clear();




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }




                    }
                    else if (myfilename == "pdf")
                    {

                        try
                        {
                            //for pdf files....uses pdfParser.cs
                            Cls_pdfparser pdf = new Cls_pdfparser();
                            string filespdf = s;
                            pdf.ExtractText(filespdf, Path.GetFileNameWithoutExtension(filespdf) + ".txt");
                            char[] arr = new char[' '];
                            string reader = Path.GetFileNameWithoutExtension(filespdf) + ".txt";

                            StreamReader Stream = new StreamReader(reader);

                            char[] togetfilename = new char[] { '\\' };
                            string[] getfilename = s.Split(togetfilename);


                            string toeliminateExt = getfilename[5];
                            string[] EliminateExt = toeliminateExt.Split(tosplit);
                            string savefilename = EliminateExt[0];


                            FileStream fs = new FileStream(@"ProcessedFiles\" + savefilename + ".txt", FileMode.Create, FileAccess.ReadWrite); 
                            while (Stream.EndOfStream == false)
                            {

                                string datamy = Stream.ReadLine();


                            
                                // StreamWriter stw = new StreamWriter(savefilename + ".txt");
                            
                                byte[] data = Encoding.ASCII.GetBytes(datamy);
                                fs.Write(data, 0, data.Length);
                              
                                


                            


                            }
                            fs.Close();

                        }
                    
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (myfilename == "docx")
                    {
                        try
                        {

                            //for word documents...

                            object nullobject = System.Reflection.Missing.Value;
                            object file = files[a];
                            Document doc = app.Documents.Open(ref file, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);

                            doc.ActiveWindow.Selection.WholeStory();
                            doc.ActiveWindow.Selection.Copy();
                            IDataObject data2 = Clipboard.GetDataObject();
                            object alldata = data2.GetData(DataFormats.Text);
                            string forregex = (string)alldata;
                            string newformation1 = Regex.Replace(forregex, "[^a-zA-Z]+", string.Empty);
                            docxText = newformation1.ToString();

                            char[] togetfilename = new char[] { '\\' };
                            string[] getfilename = s.Split(togetfilename);


                            string toeliminateExt = getfilename[5];
                            string[] EliminateExt = toeliminateExt.Split(tosplit);
                            string savefilename = EliminateExt[0];

                            StreamWriter stw = new StreamWriter(@"ProcessedFiles\"+savefilename + ".txt");
                            string datatoWrite = docxText;
                            stw.WriteLine(datatoWrite);

                            stw.Close();



                           // textBox1.Clear();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }

                    }
                    else if (myfilename == "txt")
                    {

                        try
                        {
                            //for Text Document...
                            StreamReader sr = new StreamReader(s);
                            while (sr.EndOfStream == false)
                            {


                                string data = sr.ReadLine();
                                string newFormation = Regex.Replace(data, "[^a-zA-Z]+", string.Empty, RegexOptions.Singleline);
                                txtText += newFormation.ToString();


                                char[] togetfilename = new char[] { '\\' };
                                string[] getfilename = s.Split(togetfilename);


                                string toeliminateExt = getfilename[5];
                                string[] EliminateExt = toeliminateExt.Split(tosplit);
                                string savefilename = EliminateExt[0];

                                StreamWriter stw = new StreamWriter(@"ProcessedFiles\"+savefilename + ".txt");
                                string datatoWrite = txtText;
                                stw.Write(datatoWrite);
                                stw.Close();


                            }
                           // textBox1.Clear();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }


                }
            }

        }
        public string Retrhtml
        {
            get
            {
                return htmlText;
            }
        }
        public string Retrpdf
        {
            get
            {
                return pdfText;
            }

        }
        public string RetrDocx
        {
            get
            {
                return docxText;
            }

        }
        public string Retrtxt
        {
            get
            {
                return txtText;
            }

        }

    }
}
