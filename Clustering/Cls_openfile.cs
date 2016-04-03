using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace Final_Year_Project_2
{

    /***********************************************************************************************************
 
 
   ------------------------------------------------------------------------------------------------------------

  Public Functions
   --->FilediaglogShowForMatrix
   * Description : This functions open a filedialog for matrix file when called.
   --->FileDialogshow
   * Description : This function open a filedialog for simple textfile.
 
  -------------------------------------------------------------------------------------------------------------
    Public Variables
   --->filepath
   * Type :string 

  *************************************************************************************************************/

    public class Cls_openfile
    {
        OpenFileDialog open = new OpenFileDialog();
        public string filepath=null;



        public string filedialogshow()
        {
            open.Filter = "PDF FILES|*.pdf|WORD DOCUMENT|*.docx|HTML DOCUMENT|*.htm|TEXT DOCUMENT|*.txt|Rich Text Format|*.rtf";
            open.ShowDialog();
            filepath = open.FileName.ToString();
            return filepath;


        }
        public string getfilepath
        {

            get
            {

                return filepath;

            }



        }
        public string filedialogshowFormatrix()
        {
            open.Filter = "TEXT DOCUMENT|*.txt";
            open.ShowDialog();
            filepath = open.FileName.ToString();
            return filepath;


        }



    }
}
