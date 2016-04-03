namespace Final_Year_Project_2
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            this.radCarousel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            this.radCarousel1.AnimationDelay = 25;
            this.radCarousel1.AnimationFrames = 50;
            this.radCarousel1.BackgroundImage = global::Final_Year_Project_2.Properties.Resources.back2;
            this.radCarousel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.radCarousel1.CarouselElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radCarousel1.CarouselElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.radCarousel1.CarouselElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(50.398406374501995D, 54.561403508771932D, 0D);
            carouselEllipsePath1.FinalAngle = -100D;
            carouselEllipsePath1.InitialAngle = -90D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-27.988047808764939D, 9.2982456140350873D, -50D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(24.25912787207335D, -12.356679099323111D, -60D);
            carouselEllipsePath1.ZScale = 500D;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.Controls.Add(this.radLabel1);
            this.radCarousel1.Controls.Add(this.radTitleBar1);
            this.radCarousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarousel1.EnableAutoLoop = true;
            this.radCarousel1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement4,
            this.radButtonElement5,
            this.radButtonElement2,
            this.radButtonElement1,
            this.radButtonElement3});
            this.radCarousel1.Location = new System.Drawing.Point(0, 0);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.OpacityChangeCondition = Telerik.WinControls.UI.OpacityChangeConditions.SelectedIndex;
            this.radCarousel1.SelectedIndex = 0;
            this.radCarousel1.Size = new System.Drawing.Size(1022, 635);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            this.radCarousel1.ThemeName = "ControlDefault";
            this.radCarousel1.SelectedItemChanged += new System.EventHandler(this.radCarousel1_SelectedItemChanged_1);
            ((Telerik.WinControls.UI.RadCarouselElement)(this.radCarousel1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            ((Telerik.WinControls.UI.RadCarouselElement)(this.radCarousel1.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            ((Telerik.WinControls.UI.RadCarouselElement)(this.radCarousel1.GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.CarouselItemsContainer)(this.radCarousel1.GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ((Telerik.WinControls.UI.CarouselItemsContainer)(this.radCarousel1.GetChildAt(0).GetChildAt(2))).CanFocus = false;
            ((Telerik.WinControls.UI.CarouselItemsContainer)(this.radCarousel1.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.CarouselItemsContainer)(this.radCarousel1.GetChildAt(0).GetChildAt(2))).StretchHorizontally = true;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarousel1.GetChildAt(0).GetChildAt(4))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radLabel1.Location = new System.Drawing.Point(30, 43);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radLabel1.Size = new System.Drawing.Size(220, 46);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "MAIN MENU";
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.radTitleBar1.Caption = "TEXT MINING AND VISUAL ANALYTICS";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(1022, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "TEXT MINING AND VISUAL ANALYTICS";
            this.radTitleBar1.ThemeName = "Office2007Black";
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.AccessibleDescription = "radButtonElement4";
            this.radButtonElement4.AccessibleName = "radButtonElement4";
            this.radButtonElement4.ClickMode = Telerik.WinControls.ClickMode.Hover;
            this.radButtonElement4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonElement4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radButtonElement4.Image = global::Final_Year_Project_2.Properties.Resources.R_icon;
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.ShowBorder = false;
            this.radButtonElement4.Text = "R SOTWARE";
            this.radButtonElement4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElement4.Click += new System.EventHandler(this.radButtonElement4_Click);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).GradientPercentage2 = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radButtonElement5
            // 
            this.radButtonElement5.AccessibleDescription = "radButtonElement5";
            this.radButtonElement5.AccessibleName = "radButtonElement5";
            this.radButtonElement5.ClickMode = Telerik.WinControls.ClickMode.Hover;
            this.radButtonElement5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonElement5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radButtonElement5.Image = global::Final_Year_Project_2.Properties.Resources.Alarm_Error_icon;
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.ShowBorder = false;
            this.radButtonElement5.Text = "EXIT";
            this.radButtonElement5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElement5.Click += new System.EventHandler(this.radButtonElement5_Click);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).GradientPercentage2 = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "TextMining";
            this.radButtonElement2.AccessibleName = "TextMining";
            this.radButtonElement2.AutoSize = true;
            this.radButtonElement2.ClickMode = Telerik.WinControls.ClickMode.Hover;
            this.radButtonElement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonElement2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radButtonElement2.Image = global::Final_Year_Project_2.Properties.Resources.text_mining_analytics_survey_software2;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "TextMining";
            this.radButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElement2.Click += new System.EventHandler(this.radButtonElement2_Click);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).GradientPercentage2 = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "DOC VIEWER";
            this.radButtonElement1.AccessibleName = "DOC VIEWER";
            this.radButtonElement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonElement1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radButtonElement1.Image = global::Final_Year_Project_2.Properties.Resources.folder;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "TEXT VIEWER";
            this.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click_1);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).GradientPercentage2 = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.AccessibleDescription = "CLUSTERING";
            this.radButtonElement3.AccessibleName = "CLUSTERING";
            this.radButtonElement3.ClickMode = Telerik.WinControls.ClickMode.Hover;
            this.radButtonElement3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonElement3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radButtonElement3.Image = global::Final_Year_Project_2.Properties.Resources.text_mining_analytics_survey_software2;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.ShowBorder = false;
            this.radButtonElement3.Text = "CLUSTERING";
            this.radButtonElement3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).GradientPercentage2 = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 635);
            this.Controls.Add(this.radCarousel1);
            this.Name = "MainMenu";
            this.Text = "ShapedForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            this.radCarousel1.ResumeLayout(false);
            this.radCarousel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement5;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;

    }
}
