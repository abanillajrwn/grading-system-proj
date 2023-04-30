
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;



namespace Grading_System
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

        //Required by the Windows Form Designer
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.TextBox11 = new System.Windows.Forms.TextBox();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.TextBox13 = new System.Windows.Forms.TextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBox15 = new System.Windows.Forms.TextBox();
            this.TextBox17 = new System.Windows.Forms.TextBox();
            this.TextBox16 = new System.Windows.Forms.TextBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.TextBox18 = new System.Windows.Forms.TextBox();
            this.TextBox19 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.FRST = new System.Windows.Forms.Button();
            this.NXT = new System.Windows.Forms.Button();
            this.LAST = new System.Windows.Forms.Button();
            this.PREV = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.STUDID = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PRNT = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(230, 541);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(97, 62);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Compute";
            this.ToolTip1.SetToolTip(this.Button1, "COMPUTE GRADES\r\n    Automatically compute all the \r\ngrades of specefic students.");
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.DarkRed;
            this.Button2.Location = new System.Drawing.Point(783, 577);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 24);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Exit";
            this.ToolTip1.SetToolTip(this.Button2, "EXIT PROGRAM");
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(43, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Firstname :";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(124, 91);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(203, 20);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(43, 121);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 17);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Lastname :";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(124, 117);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(203, 20);
            this.TextBox2.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox1.Controls.Add(this.label16);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.TextBox5);
            this.GroupBox1.Controls.Add(this.TextBox4);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(29, 166);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(298, 51);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "                                   20                   EG                 10%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(11, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "Attendance";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(43, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 15);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Score:";
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox5.Location = new System.Drawing.Point(236, 19);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.Size = new System.Drawing.Size(46, 21);
            this.TextBox5.TabIndex = 12;
            this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            this.TextBox4.AcceptsTab = true;
            this.TextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox4.Location = new System.Drawing.Point(169, 20);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(46, 21);
            this.TextBox4.TabIndex = 11;
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(98, 21);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(46, 21);
            this.TextBox3.TabIndex = 3;
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.TextBox9);
            this.GroupBox3.Controls.Add(this.TextBox11);
            this.GroupBox3.Controls.Add(this.TextBox10);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(29, 286);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(298, 62);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "                                   50                   EG                 20%";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(45, 25);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 15);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Score:";
            // 
            // TextBox9
            // 
            this.TextBox9.Location = new System.Drawing.Point(98, 23);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(46, 21);
            this.TextBox9.TabIndex = 5;
            this.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox9.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // TextBox11
            // 
            this.TextBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox11.Location = new System.Drawing.Point(236, 25);
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.ReadOnly = true;
            this.TextBox11.Size = new System.Drawing.Size(46, 21);
            this.TextBox11.TabIndex = 19;
            this.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox10
            // 
            this.TextBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox10.Location = new System.Drawing.Point(169, 25);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.ReadOnly = true;
            this.TextBox10.Size = new System.Drawing.Size(46, 21);
            this.TextBox10.TabIndex = 20;
            this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.label14);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.TextBox12);
            this.GroupBox4.Controls.Add(this.TextBox14);
            this.GroupBox4.Controls.Add(this.TextBox13);
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(29, 354);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(298, 51);
            this.GroupBox4.TabIndex = 8;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "                                  100                 EG                 30%";
            this.GroupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(45, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 15);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Score:";
            // 
            // TextBox12
            // 
            this.TextBox12.Location = new System.Drawing.Point(98, 19);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(46, 21);
            this.TextBox12.TabIndex = 6;
            this.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox14
            // 
            this.TextBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox14.Location = new System.Drawing.Point(236, 20);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.ReadOnly = true;
            this.TextBox14.Size = new System.Drawing.Size(46, 21);
            this.TextBox14.TabIndex = 24;
            this.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox13
            // 
            this.TextBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox13.Location = new System.Drawing.Point(169, 20);
            this.TextBox13.Name = "TextBox13";
            this.TextBox13.ReadOnly = true;
            this.TextBox13.Size = new System.Drawing.Size(46, 21);
            this.TextBox13.TabIndex = 23;
            this.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.label15);
            this.GroupBox5.Controls.Add(this.Label7);
            this.GroupBox5.Controls.Add(this.TextBox15);
            this.GroupBox5.Controls.Add(this.TextBox17);
            this.GroupBox5.Controls.Add(this.TextBox16);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(29, 411);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(298, 57);
            this.GroupBox5.TabIndex = 8;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "                                   100                 EG                 30%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Exam";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(41, 28);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(48, 15);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Score:";
            // 
            // TextBox15
            // 
            this.TextBox15.Location = new System.Drawing.Point(98, 22);
            this.TextBox15.Name = "TextBox15";
            this.TextBox15.Size = new System.Drawing.Size(46, 21);
            this.TextBox15.TabIndex = 7;
            this.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox17
            // 
            this.TextBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox17.Location = new System.Drawing.Point(236, 21);
            this.TextBox17.Name = "TextBox17";
            this.TextBox17.ReadOnly = true;
            this.TextBox17.Size = new System.Drawing.Size(46, 21);
            this.TextBox17.TabIndex = 27;
            this.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox16
            // 
            this.TextBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox16.Location = new System.Drawing.Point(169, 21);
            this.TextBox16.Name = "TextBox16";
            this.TextBox16.ReadOnly = true;
            this.TextBox16.Size = new System.Drawing.Size(46, 21);
            this.TextBox16.TabIndex = 28;
            this.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.label10);
            this.GroupBox6.Controls.Add(this.TextBox18);
            this.GroupBox6.Controls.Add(this.TextBox19);
            this.GroupBox6.Controls.Add(this.Label8);
            this.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(29, 474);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(298, 61);
            this.GroupBox6.TabIndex = 9;
            this.GroupBox6.TabStop = false;
            // 
            // TextBox18
            // 
            this.TextBox18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox18.Location = new System.Drawing.Point(90, 25);
            this.TextBox18.Name = "TextBox18";
            this.TextBox18.ReadOnly = true;
            this.TextBox18.Size = new System.Drawing.Size(98, 24);
            this.TextBox18.TabIndex = 29;
            // 
            // TextBox19
            // 
            this.TextBox19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox19.Location = new System.Drawing.Point(194, 28);
            this.TextBox19.Name = "TextBox19";
            this.TextBox19.ReadOnly = true;
            this.TextBox19.Size = new System.Drawing.Size(98, 17);
            this.TextBox19.TabIndex = 30;
            this.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox19.TextChanged += new System.EventHandler(this.TextBox19_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(39, 33);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(48, 16);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "&Grade:";
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.Location = new System.Drawing.Point(409, 69);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView1.RowHeadersWidth = 15;
            this.DataGridView1.Size = new System.Drawing.Size(481, 466);
            this.DataGridView1.TabIndex = 10;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Black;
            this.Button3.Location = new System.Drawing.Point(29, 576);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(93, 27);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "Clear All";
            this.ToolTip1.SetToolTip(this.Button3, "CLEAR ALL\r\nAllows you to erase all the current details \r\nthat can be found in all" +
        " textbox.");
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(272, 13);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(352, 29);
            this.Label11.TabIndex = 13;
            this.Label11.Text = "STUDENT GRADING SYSTEM";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(902, 57);
            this.Panel1.TabIndex = 14;
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.Black;
            this.Button4.Location = new System.Drawing.Point(127, 575);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(97, 27);
            this.Button4.TabIndex = 15;
            this.Button4.Text = "Save";
            this.ToolTip1.SetToolTip(this.Button4, "SAVE RECORD\r\n    It allow\'s the user to save the new record.");
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.Black;
            this.Button5.Location = new System.Drawing.Point(409, 546);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(107, 26);
            this.Button5.TabIndex = 16;
            this.Button5.Text = "Load";
            this.ToolTip1.SetToolTip(this.Button5, "LOAD STUDENTS\r\n    It loads all the student information in the datagridview.\r\nAnd" +
        " the user\'s are allow to view specefic student\'s data by\r\ndouble clicking the ce" +
        "lls.");
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.Black;
            this.Button6.Location = new System.Drawing.Point(534, 576);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(107, 26);
            this.Button6.TabIndex = 17;
            this.Button6.Text = "Show Details";
            this.ToolTip1.SetToolTip(this.Button6, "SHOW DETAILS\r\n     Let\'s you to view the current detail of the specefic \r\nstudent" +
        " you selected in the datagridview.");
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // FRST
            // 
            this.FRST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRST.ForeColor = System.Drawing.Color.Black;
            this.FRST.Location = new System.Drawing.Point(534, 545);
            this.FRST.Name = "FRST";
            this.FRST.Size = new System.Drawing.Size(107, 26);
            this.FRST.TabIndex = 18;
            this.FRST.Text = "First";
            this.ToolTip1.SetToolTip(this.FRST, "FIRST RECORD");
            this.FRST.UseVisualStyleBackColor = true;
            this.FRST.Click += new System.EventHandler(this.FRST_Click);
            // 
            // NXT
            // 
            this.NXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NXT.ForeColor = System.Drawing.Color.Black;
            this.NXT.Location = new System.Drawing.Point(658, 577);
            this.NXT.Name = "NXT";
            this.NXT.Size = new System.Drawing.Size(107, 26);
            this.NXT.TabIndex = 19;
            this.NXT.Text = "Next";
            this.ToolTip1.SetToolTip(this.NXT, "NEXT");
            this.NXT.UseVisualStyleBackColor = true;
            this.NXT.Click += new System.EventHandler(this.NXT_Click);
            // 
            // LAST
            // 
            this.LAST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAST.ForeColor = System.Drawing.Color.Black;
            this.LAST.Location = new System.Drawing.Point(658, 545);
            this.LAST.Name = "LAST";
            this.LAST.Size = new System.Drawing.Size(107, 26);
            this.LAST.TabIndex = 20;
            this.LAST.Text = "Last";
            this.ToolTip1.SetToolTip(this.LAST, "LAST RECORD");
            this.LAST.UseVisualStyleBackColor = true;
            this.LAST.Click += new System.EventHandler(this.LAST_Click);
            // 
            // PREV
            // 
            this.PREV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PREV.ForeColor = System.Drawing.Color.Black;
            this.PREV.Location = new System.Drawing.Point(409, 576);
            this.PREV.Name = "PREV";
            this.PREV.Size = new System.Drawing.Size(107, 26);
            this.PREV.TabIndex = 21;
            this.PREV.Text = "Previous";
            this.ToolTip1.SetToolTip(this.PREV, "PREVIOUS");
            this.PREV.UseVisualStyleBackColor = true;
            this.PREV.Click += new System.EventHandler(this.PREV_Click);
            // 
            // Button11
            // 
            this.Button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button11.ForeColor = System.Drawing.Color.Black;
            this.Button11.Location = new System.Drawing.Point(29, 543);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(92, 27);
            this.Button11.TabIndex = 22;
            this.Button11.Text = "Delete";
            this.ToolTip1.SetToolTip(this.Button11, "DELETE RECORD\r\n     It delete the any unnecessary record.");
            this.Button11.UseVisualStyleBackColor = true;
            this.Button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.Black;
            this.Button7.Location = new System.Drawing.Point(127, 541);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(97, 28);
            this.Button7.TabIndex = 23;
            this.Button7.Text = "Update";
            this.ToolTip1.SetToolTip(this.Button7, "UPDATE RECORD\r\n     It allows you to upadate any changes\r\nyou made to the current" +
        " record.");
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // STUDID
            // 
            this.STUDID.Location = new System.Drawing.Point(124, 67);
            this.STUDID.Name = "STUDID";
            this.STUDID.Size = new System.Drawing.Size(203, 20);
            this.STUDID.TabIndex = 25;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(43, 71);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(77, 16);
            this.Label12.TabIndex = 24;
            this.Label12.Text = "STUDENT ID:";
            // 
            // PRNT
            // 
            this.PRNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRNT.Location = new System.Drawing.Point(783, 543);
            this.PRNT.Name = "PRNT";
            this.PRNT.Size = new System.Drawing.Size(107, 26);
            this.PRNT.TabIndex = 26;
            this.PRNT.Text = "Print";
            this.PRNT.UseVisualStyleBackColor = true;
            this.PRNT.Click += new System.EventHandler(this.PRNT_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(16, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Project";
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox7.Location = new System.Drawing.Point(169, 21);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.ReadOnly = true;
            this.TextBox7.Size = new System.Drawing.Size(46, 21);
            this.TextBox7.TabIndex = 15;
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(98, 21);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(46, 21);
            this.TextBox6.TabIndex = 4;
            this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox8
            // 
            this.TextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox8.Location = new System.Drawing.Point(236, 22);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.ReadOnly = true;
            this.TextBox8.Size = new System.Drawing.Size(46, 21);
            this.TextBox8.TabIndex = 13;
            this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(45, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 15);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Score:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Quiz";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox2.Controls.Add(this.label13);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.TextBox8);
            this.GroupBox2.Controls.Add(this.TextBox6);
            this.GroupBox2.Controls.Add(this.TextBox7);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(29, 223);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(298, 57);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "                                   50                   EG                 10%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Performance Task";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "SEMISTER COMPUTED";
            this.label10.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 613);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PRNT);
            this.Controls.Add(this.STUDID);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.PREV);
            this.Controls.Add(this.LAST);
            this.Controls.Add(this.NXT);
            this.Controls.Add(this.FRST);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grading System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.TextBox TextBox11;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.TextBox TextBox13;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox TextBox15;
		internal System.Windows.Forms.TextBox TextBox17;
		internal System.Windows.Forms.TextBox TextBox16;
		internal System.Windows.Forms.TextBox TextBox18;
		internal System.Windows.Forms.TextBox TextBox19;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Button FRST;
		internal System.Windows.Forms.Button NXT;
		internal System.Windows.Forms.Button LAST;
		internal System.Windows.Forms.Button PREV;
		internal System.Windows.Forms.Button Button11;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.TextBox STUDID;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.ToolTip ToolTip1;
        private System.ComponentModel.IContainer components;
        private Button PRNT;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        internal Label label16;
        internal Label label15;
        internal Label label14;
        internal TextBox TextBox7;
        internal TextBox TextBox6;
        internal TextBox TextBox8;
        internal Label Label4;
        internal Label label13;
        internal GroupBox GroupBox2;
        internal Label label9;
        internal Label label10;
    }
	
}
