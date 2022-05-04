
namespace StudentuSarasas
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pridetiVardas = new System.Windows.Forms.TextBox();
			this.pridetiPavarde = new System.Windows.Forms.TextBox();
			this.pridetiNuotrauka = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pridetiPrideti = new System.Windows.Forms.Button();
			this.redaguotiRedaguoti = new System.Windows.Forms.Button();
			this.redaguotiNuotrauka = new System.Windows.Forms.Button();
			this.redaguotiPavarde = new System.Windows.Forms.TextBox();
			this.redaguotiVardas = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.redaguotiTrinti = new System.Windows.Forms.Button();
			this.studentaiList = new System.Windows.Forms.ListBox();
			this.pridetiPictureBox = new System.Windows.Forms.PictureBox();
			this.redaguotiPictureBox = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pridetiPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.redaguotiPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pridetiPictureBox);
			this.groupBox1.Controls.Add(this.pridetiPrideti);
			this.groupBox1.Controls.Add(this.pridetiNuotrauka);
			this.groupBox1.Controls.Add(this.pridetiPavarde);
			this.groupBox1.Controls.Add(this.pridetiVardas);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(229, 255);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pridėti studentą";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vardas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pavardė:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nuotrauka:";
			// 
			// pridetiVardas
			// 
			this.pridetiVardas.Location = new System.Drawing.Point(81, 22);
			this.pridetiVardas.Name = "pridetiVardas";
			this.pridetiVardas.Size = new System.Drawing.Size(142, 22);
			this.pridetiVardas.TabIndex = 3;
			// 
			// pridetiPavarde
			// 
			this.pridetiPavarde.Location = new System.Drawing.Point(81, 50);
			this.pridetiPavarde.Name = "pridetiPavarde";
			this.pridetiPavarde.Size = new System.Drawing.Size(142, 22);
			this.pridetiPavarde.TabIndex = 4;
			// 
			// pridetiNuotrauka
			// 
			this.pridetiNuotrauka.Location = new System.Drawing.Point(81, 78);
			this.pridetiNuotrauka.Name = "pridetiNuotrauka";
			this.pridetiNuotrauka.Size = new System.Drawing.Size(142, 23);
			this.pridetiNuotrauka.TabIndex = 5;
			this.pridetiNuotrauka.Text = "Pasirinkti...";
			this.pridetiNuotrauka.UseVisualStyleBackColor = true;
			this.pridetiNuotrauka.Click += new System.EventHandler(this.pridetiNuotrauka_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.redaguotiPictureBox);
			this.groupBox2.Controls.Add(this.redaguotiTrinti);
			this.groupBox2.Controls.Add(this.redaguotiRedaguoti);
			this.groupBox2.Controls.Add(this.redaguotiNuotrauka);
			this.groupBox2.Controls.Add(this.redaguotiPavarde);
			this.groupBox2.Controls.Add(this.redaguotiVardas);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(12, 273);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(229, 287);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Redaguoti studentą";
			// 
			// pridetiPrideti
			// 
			this.pridetiPrideti.Location = new System.Drawing.Point(9, 226);
			this.pridetiPrideti.Name = "pridetiPrideti";
			this.pridetiPrideti.Size = new System.Drawing.Size(214, 23);
			this.pridetiPrideti.TabIndex = 6;
			this.pridetiPrideti.Text = "Pridėti";
			this.pridetiPrideti.UseVisualStyleBackColor = true;
			this.pridetiPrideti.Click += new System.EventHandler(this.pridetiPrideti_Click);
			// 
			// redaguotiRedaguoti
			// 
			this.redaguotiRedaguoti.Location = new System.Drawing.Point(9, 225);
			this.redaguotiRedaguoti.Name = "redaguotiRedaguoti";
			this.redaguotiRedaguoti.Size = new System.Drawing.Size(214, 23);
			this.redaguotiRedaguoti.TabIndex = 13;
			this.redaguotiRedaguoti.Text = "Redaguoti";
			this.redaguotiRedaguoti.UseVisualStyleBackColor = true;
			this.redaguotiRedaguoti.Click += new System.EventHandler(this.redaguotiRedaguoti_Click);
			// 
			// redaguotiNuotrauka
			// 
			this.redaguotiNuotrauka.Location = new System.Drawing.Point(81, 77);
			this.redaguotiNuotrauka.Name = "redaguotiNuotrauka";
			this.redaguotiNuotrauka.Size = new System.Drawing.Size(142, 23);
			this.redaguotiNuotrauka.TabIndex = 12;
			this.redaguotiNuotrauka.Text = "Pasirinkti...";
			this.redaguotiNuotrauka.UseVisualStyleBackColor = true;
			this.redaguotiNuotrauka.Click += new System.EventHandler(this.redaguotiNuotrauka_Click);
			// 
			// redaguotiPavarde
			// 
			this.redaguotiPavarde.Location = new System.Drawing.Point(81, 49);
			this.redaguotiPavarde.Name = "redaguotiPavarde";
			this.redaguotiPavarde.Size = new System.Drawing.Size(142, 22);
			this.redaguotiPavarde.TabIndex = 11;
			// 
			// redaguotiVardas
			// 
			this.redaguotiVardas.Location = new System.Drawing.Point(81, 21);
			this.redaguotiVardas.Name = "redaguotiVardas";
			this.redaguotiVardas.Size = new System.Drawing.Size(142, 22);
			this.redaguotiVardas.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Nuotrauka:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Pavardė:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "Vardas:";
			// 
			// redaguotiTrinti
			// 
			this.redaguotiTrinti.Location = new System.Drawing.Point(9, 254);
			this.redaguotiTrinti.Name = "redaguotiTrinti";
			this.redaguotiTrinti.Size = new System.Drawing.Size(211, 23);
			this.redaguotiTrinti.TabIndex = 14;
			this.redaguotiTrinti.Text = "Trinti";
			this.redaguotiTrinti.UseVisualStyleBackColor = true;
			this.redaguotiTrinti.Click += new System.EventHandler(this.redaguotiTrinti_Click);
			// 
			// studentaiList
			// 
			this.studentaiList.FormattingEnabled = true;
			this.studentaiList.ItemHeight = 16;
			this.studentaiList.Location = new System.Drawing.Point(247, 12);
			this.studentaiList.Name = "studentaiList";
			this.studentaiList.Size = new System.Drawing.Size(413, 548);
			this.studentaiList.TabIndex = 4;
			this.studentaiList.SelectedIndexChanged += new System.EventHandler(this.studentaiList_SelectedIndexChanged);
			// 
			// pridetiPictureBox
			// 
			this.pridetiPictureBox.Location = new System.Drawing.Point(9, 107);
			this.pridetiPictureBox.Name = "pridetiPictureBox";
			this.pridetiPictureBox.Size = new System.Drawing.Size(211, 113);
			this.pridetiPictureBox.TabIndex = 5;
			this.pridetiPictureBox.TabStop = false;
			// 
			// redaguotiPictureBox
			// 
			this.redaguotiPictureBox.Location = new System.Drawing.Point(12, 106);
			this.redaguotiPictureBox.Name = "redaguotiPictureBox";
			this.redaguotiPictureBox.Size = new System.Drawing.Size(211, 113);
			this.redaguotiPictureBox.TabIndex = 7;
			this.redaguotiPictureBox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 569);
			this.Controls.Add(this.studentaiList);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Stundentų sąrašas";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pridetiPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.redaguotiPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button pridetiPrideti;
		private System.Windows.Forms.Button pridetiNuotrauka;
		private System.Windows.Forms.TextBox pridetiPavarde;
		private System.Windows.Forms.TextBox pridetiVardas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button redaguotiTrinti;
		private System.Windows.Forms.Button redaguotiRedaguoti;
		private System.Windows.Forms.Button redaguotiNuotrauka;
		private System.Windows.Forms.TextBox redaguotiPavarde;
		private System.Windows.Forms.TextBox redaguotiVardas;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox studentaiList;
		private System.Windows.Forms.PictureBox pridetiPictureBox;
		private System.Windows.Forms.PictureBox redaguotiPictureBox;
	}
}

