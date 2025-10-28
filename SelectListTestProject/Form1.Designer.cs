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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            selectList1 = new SelectListLibrary.SelectList();
            imageList1 = new ImageList(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // selectList1
            // 
            selectList1.FullRowSelect = true;
            selectList1.LargeImageList = imageList1;
            selectList1.Location = new Point(8, 24);
            selectList1.MultiSelect = false;
            selectList1.Name = "selectList1";
            selectList1.SelectedItem = null;
            selectList1.Size = new Size(248, 172);
            selectList1.TabIndex = 0;
            selectList1.UseCompatibleStateImageBehavior = false;
            selectList1.ItemSelected += selectList1_ItemSelected;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "game.png");
            imageList1.Images.SetKeyName(1, "test.png");
            // 
            // button1
            // 
            button1.Location = new Point(8, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(8, 24);
            button2.Name = "button2";
            button2.Size = new Size(156, 23);
            button2.TabIndex = 2;
            button2.Text = "Prompt...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 52);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 3;
            button3.Text = "Prompt with default...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectList1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 232);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select from existing list";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(276, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 80);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prompt for a value";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 244);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private SelectListLibrary.SelectList selectList1;
        private ImageList imageList1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}