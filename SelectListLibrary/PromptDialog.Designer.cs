namespace SelectListLibrary
{
    partial class PromptDialog
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
            this.selectList1 = new SelectListLibrary.SelectList();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectList1
            // 
            this.selectList1.FullRowSelect = true;
            this.selectList1.Location = new System.Drawing.Point(4, 4);
            this.selectList1.MultiSelect = false;
            this.selectList1.Name = "selectList1";
            this.selectList1.SelectedItem = null;
            this.selectList1.Size = new System.Drawing.Size(528, 272);
            this.selectList1.TabIndex = 0;
            this.selectList1.UseCompatibleStateImageBehavior = false;
            this.selectList1.View = System.Windows.Forms.View.Details;
            this.selectList1.ItemSelected += new SelectListLibrary.ItemSelectedHandler(this.selectList1_ItemSelected);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(376, 280);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(456, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PromptDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(536, 308);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.selectList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PromptDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "#";
            this.Shown += new System.EventHandler(this.PromptDialog_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnOk;
        private Button btnCancel;
        internal SelectList selectList1;
    }
}