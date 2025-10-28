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
            selectList1 = new SelectList();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // selectList1
            // 
            selectList1.FullRowSelect = true;
            selectList1.Location = new Point(4, 4);
            selectList1.MultiSelect = false;
            selectList1.Name = "selectList1";
            selectList1.SelectedItem = null;
            selectList1.Size = new Size(528, 272);
            selectList1.TabIndex = 0;
            selectList1.UseCompatibleStateImageBehavior = false;
            selectList1.View = View.Details;
            selectList1.ItemSelected += selectList1_ItemSelected;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(376, 280);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(456, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // PromptDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(536, 308);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(selectList1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PromptDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "#";
            Shown += PromptDialog_Shown;
            ResumeLayout(false);

        }

        #endregion
        private Button btnOk;
        private Button btnCancel;
        internal SelectList selectList1;
    }
}