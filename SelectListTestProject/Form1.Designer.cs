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
            this.selectList1 = new SelectListLibrary.SelectList();
            this.SuspendLayout();
            // 
            // selectList1
            // 
            this.selectList1.FullRowSelect = true;
            this.selectList1.Location = new System.Drawing.Point(80, 40);
            this.selectList1.MultiSelect = false;
            this.selectList1.Name = "selectList1";
            this.selectList1.Size = new System.Drawing.Size(436, 304);
            this.selectList1.TabIndex = 0;
            this.selectList1.UseCompatibleStateImageBehavior = false;
            this.selectList1.ItemSelected += new SelectListLibrary.ItemSelectedHandler(this.selectList1_ItemSelected);
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
    }
}