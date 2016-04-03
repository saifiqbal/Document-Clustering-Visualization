using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Final_Year_Project_2
{
    public partial class MainMenu : Telerik.WinControls.UI.ShapedForm
    {
        public MainMenu()
        {
            InitializeComponent();
            ImagePrimitive imagePrimitive = new ImagePrimitive();

            imagePrimitive.Image = Image.FromFile(@"images\back2.jpg");

            imagePrimitive.StretchHorizontally = true;

            imagePrimitive.StretchVertically = true;



            this.radCarousel1.CarouselElement.Children.Insert(1, imagePrimitive);

            //next and previous button location//...............


           





            ///End //....button postions//....



            /////SETTING crousal path//.......................................



            CarouselBezierPath carouselBezierPath1 = new CarouselBezierPath();
            carouselBezierPath1.CtrlPoint1 = new Telerik.WinControls.UI.Point3D(12.278630460448643, 48.166259168704158, 300);
            carouselBezierPath1.CtrlPoint2 = new Telerik.WinControls.UI.Point3D(87.839433293978743, 47.677261613691932, 300);
            carouselBezierPath1.FirstPoint = new Telerik.WinControls.UI.Point3D(6.3754427390791024, 50.8557457212714, -400);
            carouselBezierPath1.LastPoint = new Telerik.WinControls.UI.Point3D(93.860684769775673, 51.100244498777506, -400);
            carouselBezierPath1.ZScale = 200;


            this.radCarousel1.CarouselPath = carouselBezierPath1;
            this.radCarousel1.ForeColor = System.Drawing.Color.WhiteSmoke;






            /////////////END SETTING CROUSAL PATH//////////////////..............

           //////////NEXT AND PREVIOUS  BUTTION SETTINGS./////////
            radCarousel1.ButtonNext.Location = new Point(-400, -50);
            radCarousel1.ButtonPrevious.Location = new Point(400, -50);

            
            //...................................................//...............





        }

        private void radCarousel1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void radCarousel1_SelectedItemChanged_1(object sender, EventArgs e)
        {

        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {

        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            ExtractedTextViewer rfrm = new ExtractedTextViewer();
            rfrm.Show();
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            RadForm1 rfrm1 = new RadForm1();
            rfrm1.Show();

        }

        private void radButtonElement1_Click_1(object sender, EventArgs e)
        {
            ExtractedTextViewer rfrm2 = new ExtractedTextViewer();
            rfrm2.Show();
        }
    }
}
