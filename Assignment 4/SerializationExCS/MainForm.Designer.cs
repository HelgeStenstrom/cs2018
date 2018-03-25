namespace SerializationExProjCS
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
            this.btnXMLDeserialize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDeserializeArray = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnSerializeArray = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnXMLDeserialize
            // 
            this.btnXMLDeserialize.Location = new System.Drawing.Point(286, 269);
            this.btnXMLDeserialize.Name = "btnXMLDeserialize";
            this.btnXMLDeserialize.Size = new System.Drawing.Size(191, 55);
            this.btnXMLDeserialize.TabIndex = 7;
            this.btnXMLDeserialize.Text = "XML Deserialize";
            this.btnXMLDeserialize.UseVisualStyleBackColor = true;
            this.btnXMLDeserialize.Click += new System.EventHandler(this.btnXMLDeserialize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.Location = new System.Drawing.Point(28, 269);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(201, 55);
            this.btnXMLSerialize.TabIndex = 6;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = true;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(9, 358);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(486, 129);
            this.lblMessage.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(216, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(283, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(216, 16);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(283, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Last Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "First Name";
            // 
            // btnDeserializeArray
            // 
            this.btnDeserializeArray.Location = new System.Drawing.Point(286, 186);
            this.btnDeserializeArray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeserializeArray.Name = "btnDeserializeArray";
            this.btnDeserializeArray.Size = new System.Drawing.Size(192, 56);
            this.btnDeserializeArray.TabIndex = 5;
            this.btnDeserializeArray.Text = "Deserialize Array Object";
            this.btnDeserializeArray.UseVisualStyleBackColor = true;
            this.btnDeserializeArray.Click += new System.EventHandler(this.btnDeserializeArray_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(286, 120);
            this.btnDeserialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(192, 56);
            this.btnDeserialize.TabIndex = 3;
            this.btnDeserialize.Text = "File &Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnSerializeArray
            // 
            this.btnSerializeArray.Location = new System.Drawing.Point(27, 186);
            this.btnSerializeArray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerializeArray.Name = "btnSerializeArray";
            this.btnSerializeArray.Size = new System.Drawing.Size(202, 56);
            this.btnSerializeArray.TabIndex = 4;
            this.btnSerializeArray.Text = "&Serialize Array Object";
            this.btnSerializeArray.UseVisualStyleBackColor = true;
            this.btnSerializeArray.Click += new System.EventHandler(this.btnSerializeArray_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(27, 120);
            this.btnSerialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(202, 56);
            this.btnSerialize.TabIndex = 2;
            this.btnSerialize.Text = "File &Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 517);
            this.Controls.Add(this.btnXMLDeserialize);
            this.Controls.Add(this.btnXMLSerialize);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnDeserializeArray);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerializeArray);
            this.Controls.Add(this.btnSerialize);
            this.Name = "MainForm";
            this.Text = "Serialization test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnXMLDeserialize;
        internal System.Windows.Forms.Button btnXMLSerialize;
        internal System.Windows.Forms.Label lblMessage;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnDeserializeArray;
        internal System.Windows.Forms.Button btnDeserialize;
        internal System.Windows.Forms.Button btnSerializeArray;
        internal System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Timer timer1;
    }
}

