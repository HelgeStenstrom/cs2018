namespace Inheritance
{
	partial class MainFrame
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
            this.btnIsa = new System.Windows.Forms.Button();
            this.btnDynamicBind = new System.Windows.Forms.Button();
            this.btnHasA = new System.Windows.Forms.Button();
            this.btnChief = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIsa
            // 
            this.btnIsa.Location = new System.Drawing.Point(4, 109);
            this.btnIsa.Margin = new System.Windows.Forms.Padding(2);
            this.btnIsa.Name = "btnIsa";
            this.btnIsa.Size = new System.Drawing.Size(210, 32);
            this.btnIsa.TabIndex = 7;
            this.btnIsa.Text = "Test a \"is-a\" relationship (Inheritance)";
            this.btnIsa.Click += new System.EventHandler(this.btnIsA_Click);
            // 
            // btnDynamicBind
            // 
            this.btnDynamicBind.Location = new System.Drawing.Point(4, 148);
            this.btnDynamicBind.Margin = new System.Windows.Forms.Padding(2);
            this.btnDynamicBind.Name = "btnDynamicBind";
            this.btnDynamicBind.Size = new System.Drawing.Size(210, 32);
            this.btnDynamicBind.TabIndex = 6;
            this.btnDynamicBind.Text = "Test dynamic Binding (Late Binding)";
            this.btnDynamicBind.Click += new System.EventHandler(this.btnDynamicBin_Click);
            // 
            // btnHasA
            // 
            this.btnHasA.Location = new System.Drawing.Point(4, 70);
            this.btnHasA.Margin = new System.Windows.Forms.Padding(2);
            this.btnHasA.Name = "btnHasA";
            this.btnHasA.Size = new System.Drawing.Size(210, 32);
            this.btnHasA.TabIndex = 5;
            this.btnHasA.Text = "Test a \"has-a\" relationship (aggregation)";
            this.btnHasA.Click += new System.EventHandler(this.btnHasA_Click);
            // 
            // btnChief
            // 
            this.btnChief.Location = new System.Drawing.Point(4, 31);
            this.btnChief.Margin = new System.Windows.Forms.Padding(2);
            this.btnChief.Name = "btnChief";
            this.btnChief.Size = new System.Drawing.Size(210, 32);
            this.btnChief.TabIndex = 4;
            this.btnChief.Text = "Test of Chief object";
            this.btnChief.Click += new System.EventHandler(this.btnChief_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(242, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 145);
            this.label1.TabIndex = 8;
            this.label1.Text = "This program is only for the purpose of testing.  It is recommended to run the co" +
    "de using Debug to see what happens in every part of the program.  The documentat" +
    "ion of the code is left to you.";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIsa);
            this.Controls.Add(this.btnDynamicBind);
            this.Controls.Add(this.btnHasA);
            this.Controls.Add(this.btnChief);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFrame";
            this.Text = "Test Program";
            this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button btnIsa;
		internal System.Windows.Forms.Button btnDynamicBind;
		internal System.Windows.Forms.Button btnHasA;
		internal System.Windows.Forms.Button btnChief;
        private System.Windows.Forms.Label label1;
	}
}

