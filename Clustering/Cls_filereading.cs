using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;

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
     ------------------------------------------------------------------------------------------------------------

    Public Methods
     --->File Read
     * Description : ReadFile and extract text when called.
    
    public function
     --->OnlyText
     * Description : Return text extracted from a Document.
    -------------------------------------------------------------------------------------------------------------
      Public Variables
    --->AllData
    * type :String
 
 

    *************************************************************************************************************/

    public class Cls_filereading
    {



        OpenFileDialog openfiledialog = new OpenFileDialog();

        public static string AllData = null;     ///Print data to textbox.///..............


        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();           ///word file reader variable...//...for word documents..,.....



        public static  event reportFileReading report;

        public void fileread(string filepath)
        {
            try
            {
                Regex rr = new Regex("<[^>]+>");
                string data;

               // CheckForIllegalCrossThreadCalls = false;

                if (filepath != "")
                {

                    

                    StreamReader sr = new StreamReader(filepath.ToString());

                    
                    if (openfiledialog.FilterIndex == 2)
                    {
                        try
                        {

                            if (report != null)
                            {
                                //for word documents...
                                object obfilepath = (object)filepath;

                                object nullobject = System.Reflection.Missing.Value;
                                Document doc = app.Documents.Open(ref obfilepath, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);

                                doc.ActiveWindow.Selection.WholeStory();
                                doc.ActiveWindow.Selection.Copy();
                                IDataObject data2 = Clipboard.GetDataObject();
                                object alldata = data2.GetData(DataFormats.Text);
                                string forregex = (string)alldata;
                                string newformation1 = Regex.Replace(forregex, "[^a-zA-Z]+", string.Empty);


                                AllData = newformation1.ToString();


                                report(AllData);
                            }
                            
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }



                    }
                    else if (openfiledialog.FilterIndex == 5)
                    {
                        try
                        {

                            //for word documents...

                            if (report != null)
                            {

                                object obfilepath = (object)filepath;

                                object nullobject = System.Reflection.Missing.Value;
                                Document doc = app.Documents.Open(ref obfilepath, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);

                                doc.ActiveWindow.Selection.WholeStory();
                                doc.ActiveWindow.Selection.Copy();
                                IDataObject data2 = Clipboard.GetDataObject();
                                object alldata = data2.GetData(DataFormats.Text);
                                string forregex = (string)alldata;
                                string newformation1 = Regex.Replace(forregex, "[^a-zA-Z]+", string.Empty);


                                AllData = newformation1.ToString();


                                report(AllData);


                            }



                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }


                    }
                    else if (openfiledialog.FilterIndex == 3)
                    {
                        try
                        {
                            //for html files.....

                            while (sr.EndOfStream == false)
                            {

                                if (report != null)
                                {

                                    data = sr.ReadLine();
                                    string newFormation = Regex.Replace(data, @"</?\w+((\s+\w+(\s*=\s*(?:"".*?""|'.*?'|[^'"">\s]+))?)+\s*|\s*)/?>", string.Empty, RegexOptions.Singleline);
                                    AllData = newFormation.ToString();

                                    report(AllData);


                                }

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (openfiledialog.FilterIndex == 1)
                    {
                        try
                        {
                            //for pdf files....uses pdfParser.cs
                            Cls_pdfparser pdf = new Cls_pdfparser();
                            string files = (string)filepath;
                            pdf.ExtractText(files, Path.GetFileNameWithoutExtension(files) + ".txt");
                            char[] arr = new char[' '];
                            string reader = Path.GetFileNameWithoutExtension(files) + ".txt";

                            StreamReader Stream = new StreamReader(reader);
                            while (Stream.EndOfStream == false)
                            {


                                if (report != null)
                                {
                                    
                                    AllData = Stream.ReadLine();


                                    report(AllData);


                                }

                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (openfiledialog.FilterIndex == 4)
                    {
                        try
                        {
                            //for Text Document...

                            while (sr.EndOfStream == false)
                            {
                                if (report != null)
                                {
                                    data = sr.ReadLine();
                                    string newFormation = Regex.Replace(data, "[^a-zA-Z]+", string.Empty, RegexOptions.Singleline);
                                    AllData = newFormation.ToString();


                                    report(AllData);


                                }


                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }
        public string onlyText
        {
            get
            {

                return AllData;

            }
            set
            {
                AllData = value;
            }


        }













    }
}
