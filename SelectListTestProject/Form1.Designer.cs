namespace SelectListTestProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectList1 = new SelectListLibrary.SelectList();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // selectList1
            // 
            this.selectList1.FullRowSelect = true;
            this.selectList1.LargeImageList = this.imageList1;
            this.selectList1.Location = new System.Drawing.Point(80, 40);
            this.selectList1.MultiSelect = false;
            this.selectList1.Name = "selectList1";
            this.selectList1.SelectedItem = null;
            this.selectList1.Size = new System.Drawing.Size(436, 304);
            this.selectList1.TabIndex = 0;
            this.selectList1.UseCompatibleStateImageBehavior = false;
            this.selectList1.ItemSelected += new SelectListLibrary.ItemSelectedHandler(this.selectList1_ItemSelected);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "game.png");
            this.imageList1.Images.SetKeyName(1, "test.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SelectListLibrary.SelectList selectList1;
        private ImageList imageList1;
    }
}