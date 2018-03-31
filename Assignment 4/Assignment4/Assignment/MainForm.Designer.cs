namespace Assignment
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxGender = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.lblBredd = new System.Windows.Forms.Label();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.lbxAnimalObject = new System.Windows.Forms.ListBox();
            this.gbxSpecification = new System.Windows.Forms.GroupBox();
            this.txtCatProperty = new System.Windows.Forms.TextBox();
            this.txtSpeciesProperty = new System.Windows.Forms.TextBox();
            this.lblSpeciesProperty = new System.Windows.Forms.Label();
            this.lblCatProperty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbxFoodSchedule = new System.Windows.Forms.ListBox();
            this.txtEaterType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxFoodStaff = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXmlImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXmlExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openBinaryFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveBinaryFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openXmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveXmlFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxSpecification.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(48, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.TxtName_Validated);
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
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(48, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            this.txtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAge_Validating);
            this.txtAge.Validated += new System.EventHandler(this.TxtAge_Validated);
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
            this.lbxGender.Size = new System.Drawing.Size(154, 95);
            this.lbxGender.TabIndex = 14;
            this.lbxGender.SelectedIndexChanged += new System.EventHandler(this.LbxGender_SelectedIndexChanged);
            this.lbxGender.Validating += new System.ComponentModel.CancelEventHandler(this.LbxGender_Validating);
            this.lbxGender.Validated += new System.EventHandler(this.LbxGender_Validated);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animal Object";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(352, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add this new animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnChange);
            this.groupBox4.Controls.Add(this.lvAnimals);
            this.groupBox4.Controls.Add(this.lblBredd);
            this.groupBox4.Location = new System.Drawing.Point(12, 379);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(688, 168);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List of registered animals";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(11, 42);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // lvAnimals
            // 
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.GridLines = true;
            this.lvAnimals.Location = new System.Drawing.Point(122, 32);
            this.lvAnimals.MultiSelect = false;
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(548, 130);
            this.lvAnimals.TabIndex = 0;
            this.lvAnimals.TabStop = false;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            this.lvAnimals.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvAnimals_ColumnClick);
            this.lvAnimals.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.LvAnimals_ColumnWidthChanging);
            this.lvAnimals.SelectedIndexChanged += new System.EventHandler(this.LvAnimals_SelectedIndexChanged);
            // 
            // lblBredd
            // 
            this.lblBredd.Location = new System.Drawing.Point(392, 0);
            this.lblBredd.Name = "lblBredd";
            this.lblBredd.Size = new System.Drawing.Size(142, 29);
            this.lblBredd.TabIndex = 16;
            this.lblBredd.Text = "?";
            // 
            // lbxCategory
            // 
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.Location = new System.Drawing.Point(215, 32);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(121, 95);
            this.lbxCategory.TabIndex = 14;
            this.lbxCategory.SelectedIndexChanged += new System.EventHandler(this.LbxCategory_SelectedIndexChanged);
            // 
            // lbxAnimalObject
            // 
            this.lbxAnimalObject.FormattingEnabled = true;
            this.lbxAnimalObject.Location = new System.Drawing.Point(352, 32);
            this.lbxAnimalObject.Name = "lbxAnimalObject";
            this.lbxAnimalObject.Size = new System.Drawing.Size(142, 95);
            this.lbxAnimalObject.TabIndex = 15;
            this.lbxAnimalObject.SelectedIndexChanged += new System.EventHandler(this.LbxAnimalObject_SelectedIndexChanged);
            // 
            // gbxSpecification
            // 
            this.gbxSpecification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxSpecification.Controls.Add(this.txtCatProperty);
            this.gbxSpecification.Controls.Add(this.txtSpeciesProperty);
            this.gbxSpecification.Controls.Add(this.lblSpeciesProperty);
            this.gbxSpecification.Controls.Add(this.lblCatProperty);
            this.gbxSpecification.Location = new System.Drawing.Point(17, 224);
            this.gbxSpecification.Name = "gbxSpecification";
            this.gbxSpecification.Size = new System.Drawing.Size(186, 98);
            this.gbxSpecification.TabIndex = 10;
            this.gbxSpecification.TabStop = false;
            this.gbxSpecification.Text = "Specifications";
            // 
            // txtCatProperty
            // 
            this.txtCatProperty.Location = new System.Drawing.Point(84, 28);
            this.txtCatProperty.Name = "txtCatProperty";
            this.txtCatProperty.Size = new System.Drawing.Size(68, 20);
            this.txtCatProperty.TabIndex = 4;
            this.txtCatProperty.TextChanged += new System.EventHandler(this.TxtCatProperty_TextChanged);
            this.txtCatProperty.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCatProperty_Validating);
            this.txtCatProperty.Validated += new System.EventHandler(this.TxtCatProperty_Validated);
            // 
            // txtSpeciesProperty
            // 
            this.txtSpeciesProperty.Location = new System.Drawing.Point(84, 59);
            this.txtSpeciesProperty.Name = "txtSpeciesProperty";
            this.txtSpeciesProperty.Size = new System.Drawing.Size(68, 20);
            this.txtSpeciesProperty.TabIndex = 3;
            this.txtSpeciesProperty.TextChanged += new System.EventHandler(this.TxtSpeciesProperty_TextChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPopulate);
            this.groupBox1.Controls.Add(this.gbxSpecification);
            this.groupBox1.Controls.Add(this.lbxAnimalObject);
            this.groupBox1.Controls.Add(this.lbxCategory);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Specifications";
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(215, 299);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 14;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.BtnPopulate_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(6, 48);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 16;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbxFoodSchedule);
            this.groupBox5.Controls.Add(this.txtEaterType);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(706, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 216);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Feeding Schedule";
            // 
            // lbxFoodSchedule
            // 
            this.lbxFoodSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.lbxFoodSchedule.FormattingEnabled = true;
            this.lbxFoodSchedule.Location = new System.Drawing.Point(10, 45);
            this.lbxFoodSchedule.Name = "lbxFoodSchedule";
            this.lbxFoodSchedule.Size = new System.Drawing.Size(188, 160);
            this.lbxFoodSchedule.TabIndex = 3;
            // 
            // txtEaterType
            // 
            this.txtEaterType.BackColor = System.Drawing.SystemColors.Control;
            this.txtEaterType.Location = new System.Drawing.Point(78, 16);
            this.txtEaterType.Name = "txtEaterType";
            this.txtEaterType.Size = new System.Drawing.Size(120, 20);
            this.txtEaterType.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Eater type";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(6, 19);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxFoodStaff);
            this.groupBox3.Controls.Add(this.btnAddStaff);
            this.groupBox3.Controls.Add(this.btnAddFood);
            this.groupBox3.Location = new System.Drawing.Point(581, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 193);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Food or staff details";
            // 
            // lbxFoodStaff
            // 
            this.lbxFoodStaff.FormattingEnabled = true;
            this.lbxFoodStaff.Location = new System.Drawing.Point(87, 19);
            this.lbxFoodStaff.Name = "lbxFoodStaff";
            this.lbxFoodStaff.Size = new System.Drawing.Size(229, 160);
            this.lbxFoodStaff.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator1,
            this.xMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(158, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.MnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(158, 22);
            this.mnuFileOpen.Text = "Open ...";
            this.mnuFileOpen.Click += new System.EventHandler(this.MnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(158, 22);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.MnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(158, 22);
            this.mnuFileSaveAs.Text = "Save As ...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.MnuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileXmlImport,
            this.mnuFileXmlExport});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // mnuFileXmlImport
            // 
            this.mnuFileXmlImport.Name = "mnuFileXmlImport";
            this.mnuFileXmlImport.Size = new System.Drawing.Size(185, 22);
            this.mnuFileXmlImport.Text = "Import from XML file";
            this.mnuFileXmlImport.Click += new System.EventHandler(this.MnuFileXmlImport_Click);
            // 
            // mnuFileXmlExport
            // 
            this.mnuFileXmlExport.Name = "mnuFileXmlExport";
            this.mnuFileXmlExport.Size = new System.Drawing.Size(185, 22);
            this.mnuFileXmlExport.Text = "Export to XML file";
            this.mnuFileXmlExport.Click += new System.EventHandler(this.MnuFileXmlExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(158, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // openBinaryFileDialog
            // 
            this.openBinaryFileDialog.FileName = "openFileDialog1";
            this.openBinaryFileDialog.Filter = "Binary serialized file | *.dat|All files | *.*";
            // 
            // saveBinaryFileDialog
            // 
            this.saveBinaryFileDialog.Filter = "Binary serialized file | *.dat";
            // 
            // openXmlFileDialog
            // 
            this.openXmlFileDialog.FileName = "openFileDialog1";
            this.openXmlFileDialog.Filter = "XML serialized file | *.xml|All files | *.*";
            // 
            // saveXmlFileDialog
            // 
            this.saveXmlFileDialog.Filter = "XML serialized file | *.xml";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Apu Animal Motel";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbxSpecification.ResumeLayout(false);
            this.gbxSpecification.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxSpecification;
        private System.Windows.Forms.TextBox txtCatProperty;
        private System.Windows.Forms.TextBox txtSpeciesProperty;
        private System.Windows.Forms.Label lblSpeciesProperty;
        private System.Windows.Forms.Label lblCatProperty;
        private System.Windows.Forms.ListBox lbxAnimalObject;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.Label lblBredd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEaterType;
        private System.Windows.Forms.ListBox lbxFoodSchedule;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxFoodStaff;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXmlImport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXmlExport;
        private System.Windows.Forms.OpenFileDialog openBinaryFileDialog;
        private System.Windows.Forms.SaveFileDialog saveBinaryFileDialog;
        private System.Windows.Forms.OpenFileDialog openXmlFileDialog;
        private System.Windows.Forms.SaveFileDialog saveXmlFileDialog;
    }
}

