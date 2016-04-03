namespace Final_Year_Project_2
{
    partial class ExtractedTextViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractedTextViewer));
            this.txtBOX1 = new Telerik.WinControls.UI.RadTextBox();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.telerikTheme1 = new Telerik.WinControls.Themes.TelerikTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.txtBOX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBOX1
            // 
            this.txtBOX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBOX1.Location = new System.Drawing.Point(260, 71);
            this.txtBOX1.Multiline = true;
            this.txtBOX1.Name = "txtBOX1";
            // 
            // 
            // 
            this.txtBOX1.RootElement.StretchVertically = true;
            this.txtBOX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBOX1.Size = new System.Drawing.Size(797, 437);
            this.txtBOX1.TabIndex = 1;
            this.txtBOX1.TabStop = false;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "File";
            this.radMenuItem1.AccessibleName = "File";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Exit";
            this.radMenuItem2.AccessibleName = "Exit";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Exit";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Owner = null;
            this.radMenu1.Size = new System.Drawing.Size(1063, 20);
            this.radMenu1.TabIndex = 2;
            this.radMenu1.Text = "radMenu1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "drive-win-icon.png");
            this.imageList1.Images.SetKeyName(1, "File-icon.png");
            this.imageList1.Images.SetKeyName(2, "folder-icon.png");
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(260, 35);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 24);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Search Documents";
            this.radButton1.ThemeName = "Breeze";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(13, 71);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(241, 437);
            this.treeView1.TabIndex = 6;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.DropDownAnimationEnabled = true;
            this.radDropDownList2.Location = new System.Drawing.Point(13, 35);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.ShowImageInEditorArea = true;
            this.radDropDownList2.Size = new System.Drawing.Size(241, 20);
            this.radDropDownList2.TabIndex = 7;
            this.radDropDownList2.Text = "Select Content";
            // 
            // ExtractedTextViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1063, 534);
            this.Controls.Add(this.radDropDownList2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.txtBOX1);
            this.Name = "ExtractedTextViewer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Document Finder";
            this.ThemeName = "Breeze";
            this.Load += new System.EventHandler(this.RadForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBOX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtBOX1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
       // private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.Themes.TelerikTheme telerikTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
       // private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private System.Windows.Forms.TreeView treeView1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
    }
}
