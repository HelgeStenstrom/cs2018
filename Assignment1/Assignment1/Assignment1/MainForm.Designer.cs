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
            this.lblBredd = new System.Windows.Forms.Label();
            this.gbxMammal = new System.Windows.Forms.GroupBox();
            this.txtCatProperty = new System.Windows.Forms.TextBox();
            this.txtSpeciesProperty = new System.Windows.Forms.TextBox();
            this.lblSpeciesProperty = new System.Windows.Forms.Label();
            this.lblCatProperty = new System.Windows.Forms.Label();
            this.lbxAnimalObject = new System.Windows.Forms.ListBox();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxGender = new System.Windows.Forms.ListBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxMammal.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBredd);
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
            this.groupBox1.Size = new System.Drawing.Size(706, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Specifications";
            // 
            // lblBredd
            // 
            this.lblBredd.Location = new System.Drawing.Point(526, 34);
            this.lblBredd.Name = "lblBredd";
            this.lblBredd.Size = new System.Drawing.Size(142, 211);
            this.lblBredd.TabIndex = 16;
            this.lblBredd.Text = "This program has two ID numbers for animals,\r\nOne maintained by the AnimalManager" +
    " class,\r\none by the Animal class. \r\nThey are equivalent, but the Animal class im" +
    "plementation\r\nis much simpler.\r\n";
            // 
            // gbxMammal
            // 
            this.gbxMammal.Controls.Add(this.txtCatProperty);
            this.gbxMammal.Controls.Add(this.txtSpeciesProperty);
            this.gbxMammal.Controls.Add(this.lblSpeciesProperty);
            this.gbxMammal.Controls.Add(this.lblCatProperty);
            this.gbxMammal.Location = new System.Drawing.Point(17, 224);
            this.gbxMammal.Name = "gbxMammal";
            this.gbxMammal.Size = new System.Drawing.Size(200, 100);
            this.gbxMammal.TabIndex = 10;
            this.gbxMammal.TabStop = false;
            this.gbxMammal.Text = "Specifications";
            // 
            // txtCatProperty
            // 
            this.txtCatProperty.Location = new System.Drawing.Point(84, 28);
            this.txtCatProperty.Name = "txtCatProperty";
            this.txtCatProperty.Size = new System.Drawing.Size(68, 20);
            this.txtCatProperty.TabIndex = 4;
            this.txtCatProperty.TextChanged += new System.EventHandler(this.txtCatProperty_TextChanged);
            // 
            // txtSpeciesProperty
            // 
            this.txtSpeciesProperty.Location = new System.Drawing.Point(84, 59);
            this.txtSpeciesProperty.Name = "txtSpeciesProperty";
            this.txtSpeciesProperty.Size = new System.Drawing.Size(68, 20);
            this.txtSpeciesProperty.TabIndex = 3;
            this.txtSpeciesProperty.TextChanged += new System.EventHandler(this.txtSpeciesProperty_TextChanged);
            // 
            // lblSpeciesProperty
            // 
            this.lblSpeciesProperty.AutoSize = true;
            this.lblSpeciesProperty.Location = new System.Drawing.Point(6, 59);
            this.lblSpeciesProperty.Name = "lblSpeciesProperty";
            this.lblSpeciesProperty.Size = new System.Drawing.Size(56, 13);
            this.lblSpeciesProperty.TabIndex = 1;
            this.lblSpeciesProperty.Text = "Tail length";
            // 
            // lblCatProperty
            // 
            this.lblCatProperty.AutoSize = true;
            this.lblCatProperty.Location = new System.Drawing.Point(6, 28);
            this.lblCatProperty.Name = "lblCatProperty";
            this.lblCatProperty.Size = new System.Drawing.Size(63, 13);
            this.lblCatProperty.TabIndex = 0;
            this.lblCatProperty.Text = "No. of teeth";
            // 
            // lbxAnimalObject
            // 
            this.lbxAnimalObject.FormattingEnabled = true;
            this.lbxAnimalObject.Location = new System.Drawing.Point(378, 32);
            this.lbxAnimalObject.Name = "lbxAnimalObject";
            this.lbxAnimalObject.Size = new System.Drawing.Size(142, 225);
            this.lbxAnimalObject.TabIndex = 15;
            this.lbxAnimalObject.SelectedIndexChanged += new System.EventHandler(this.lbxAnimalObject_SelectedIndexChanged);
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
            this.groupBox4.Size = new System.Drawing.Size(683, 146);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List of registered animals";
            // 
            // lvAnimals
            // 
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.GridLines = true;
            this.lvAnimals.Location = new System.Drawing.Point(12, 32);
            this.lvAnimals.MultiSelect = false;
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(665, 97);
            this.lvAnimals.TabIndex = 0;
            this.lvAnimals.TabStop = false;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            this.lvAnimals.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvAnimals_ColumnWidthChanging);
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
            this.lbxGender.SelectedIndexChanged += new System.EventHandler(this.lbxGender_SelectedIndexChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(48, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
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
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
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
            this.gbxMammal.ResumeLayout(false);
            this.gbxMammal.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblSpeciesProperty;
        private System.Windows.Forms.Label lblCatProperty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.TextBox txtCatProperty;
        private System.Windows.Forms.TextBox txtSpeciesProperty;
        private System.Windows.Forms.ListBox lbxGender;
        private System.Windows.Forms.ListBox lbxAnimalObject;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.Label lblBredd;
    }
}

