namespace Assignment1
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxAnimalObject = new System.Windows.Forms.ListBox();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.gbxMammal = new System.Windows.Forms.GroupBox();
            this.txtTeeth = new System.Windows.Forms.TextBox();
            this.txtTail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxGender = new System.Windows.Forms.ListBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBird = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBredd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxMammal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxBird.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBredd);
            this.groupBox1.Controls.Add(this.gbxBird);
            this.groupBox1.Controls.Add(this.gbxMammal);
            this.groupBox1.Controls.Add(this.lbxAnimalObject);
            this.groupBox1.Controls.Add(this.lbxCategory);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Specifications";
            // 
            // lbxAnimalObject
            // 
            this.lbxAnimalObject.FormattingEnabled = true;
            this.lbxAnimalObject.Location = new System.Drawing.Point(378, 32);
            this.lbxAnimalObject.Name = "lbxAnimalObject";
            this.lbxAnimalObject.Size = new System.Drawing.Size(142, 225);
            this.lbxAnimalObject.TabIndex = 15;
            // 
            // lbxCategory
            // 
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.Location = new System.Drawing.Point(241, 32);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(121, 95);
            this.lbxCategory.TabIndex = 14;
            this.lbxCategory.SelectedIndexChanged += new System.EventHandler(this.lbxCategory_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvAnimals);
            this.groupBox4.Location = new System.Drawing.Point(17, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(650, 146);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List of registered animals";
            // 
            // lvAnimals
            // 
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.GridLines = true;
            this.lvAnimals.Location = new System.Drawing.Point(31, 32);
            this.lvAnimals.MultiSelect = false;
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(613, 97);
            this.lvAnimals.TabIndex = 0;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            this.lvAnimals.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvAnimals_ColumnWidthChanging);
            // 
            // gbxMammal
            // 
            this.gbxMammal.Controls.Add(this.txtTeeth);
            this.gbxMammal.Controls.Add(this.txtTail);
            this.gbxMammal.Controls.Add(this.label6);
            this.gbxMammal.Controls.Add(this.label5);
            this.gbxMammal.Location = new System.Drawing.Point(17, 224);
            this.gbxMammal.Name = "gbxMammal";
            this.gbxMammal.Size = new System.Drawing.Size(200, 100);
            this.gbxMammal.TabIndex = 10;
            this.gbxMammal.TabStop = false;
            this.gbxMammal.Text = "Mammal Specifications";
            // 
            // txtTeeth
            // 
            this.txtTeeth.Location = new System.Drawing.Point(84, 28);
            this.txtTeeth.Name = "txtTeeth";
            this.txtTeeth.Size = new System.Drawing.Size(68, 20);
            this.txtTeeth.TabIndex = 4;
            // 
            // txtTail
            // 
            this.txtTail.Location = new System.Drawing.Point(84, 59);
            this.txtTail.Name = "txtTail";
            this.txtTail.Size = new System.Drawing.Size(68, 20);
            this.txtTail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tail length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "No. of teeth";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(392, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add this new animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animal Object";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxGender);
            this.groupBox2.Location = new System.Drawing.Point(9, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // lbxGender
            // 
            this.lbxGender.FormattingEnabled = true;
            this.lbxGender.Location = new System.Drawing.Point(6, 19);
            this.lbxGender.Name = "lbxGender";
            this.lbxGender.Size = new System.Drawing.Size(188, 95);
            this.lbxGender.TabIndex = 14;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(48, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(48, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // gbxBird
            // 
            this.gbxBird.Controls.Add(this.textBox3);
            this.gbxBird.Controls.Add(this.textBox4);
            this.gbxBird.Controls.Add(this.label7);
            this.gbxBird.Controls.Add(this.label8);
            this.gbxBird.Location = new System.Drawing.Point(244, 236);
            this.gbxBird.Name = "gbxBird";
            this.gbxBird.Size = new System.Drawing.Size(200, 100);
            this.gbxBird.TabIndex = 11;
            this.gbxBird.TabStop = false;
            this.gbxBird.Text = "Bird Specifications";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tail length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "No. of teeth";
            // 
            // lblBredd
            // 
            this.lblBredd.AutoSize = true;
            this.lblBredd.Location = new System.Drawing.Point(590, 282);
            this.lblBredd.Name = "lblBredd";
            this.lblBredd.Size = new System.Drawing.Size(35, 13);
            this.lblBredd.TabIndex = 16;
            this.lblBredd.Text = "label9";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 537);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Apu Animal Motel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gbxMammal.ResumeLayout(false);
            this.gbxMammal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbxBird.ResumeLayout(false);
            this.gbxBird.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxMammal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.TextBox txtTeeth;
        private System.Windows.Forms.TextBox txtTail;
        private System.Windows.Forms.ListBox lbxGender;
        private System.Windows.Forms.ListBox lbxAnimalObject;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.GroupBox gbxBird;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBredd;
    }
}

