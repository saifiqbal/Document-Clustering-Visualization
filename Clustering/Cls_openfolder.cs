using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final_Year_Project_2
{

  /***********************************************************************************************************
 
 


 Public Functions
  --->FolderPath
  * Description : This function get the path of the selected folder.
 
 
 -------------------------------------------------------------------------------------------------------------
   Public Variables
 --->Path 
  * Type :string 
 *************************************************************************************************************/
























    public class Cls_openfolder
    {
        public string path;
        FolderBrowserDialog fb = new FolderBrowserDialog();
       
        public string folderpath()
        {


            fb.ShowDialog();
            path= fb.SelectedPath.ToString();
            return path;

        }
        public string getpath
        {
            get
            {

                return path;


            }
            set
            {
                path = value;
            }



        }
    }
}
