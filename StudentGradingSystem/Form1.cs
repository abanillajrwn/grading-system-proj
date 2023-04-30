
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
	public partial class Form1
	{
		public Form1()
		{
			InitializeComponent();
			
		
		}
		
#region Default Instance
		
		private static Form1 defaultInstance;
		

		public static Form1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Form1();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
		DataSet dsgrade;
		DataSet newgrade = new DataSet();
		int inc;
		
		int MaxRows;
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			int a = default(int);
			decimal b = new decimal();
			
			if (Information.IsNumeric(TextBox3.Text))
			{
				if (int.Parse(TextBox3.Text) <= 20 )
				{
					a = (int) ((double.Parse(TextBox3.Text) * 100) / 20);
					TextBox4.Text = a.ToString();
					b = (decimal) (a * 0.1);
					TextBox5.Text = b.ToString();
				}
				else
				{
					MessageBox.Show("Please Enter value equal to 20 and below!");
				}
			}
			if (Information.IsNumeric(TextBox6.Text))
			{
				
				if (int.Parse(TextBox6.Text) <= 50 )
				{
					int c = default(int);
					decimal d = new decimal();
					c = (int) ((double.Parse(TextBox6.Text) * 100) / 50);
					TextBox7.Text = c.ToString();
					d = (decimal) (c * 0.1);
					TextBox8.Text = d.ToString();
					
				}
				else
				{
					MessageBox.Show("Please Enter value equal to 50 and below!");
					
					
				}
			}
			
			if (Information.IsNumeric(TextBox9.Text))
			{
				if (int.Parse(TextBox9.Text) <= 50 )
				{
					int g = default(int);
					decimal f = new decimal();
					g = (int) ((double.Parse(TextBox9.Text) * 100) / 50);
					TextBox10.Text = g.ToString();
					f = (decimal) (g * 0.2);
					TextBox11.Text = f.ToString();
					
				}
				else
				{
					MessageBox.Show("Please Enter value equal to 50 and below!");
					
					
				}
			}
			if (Information.IsNumeric(TextBox12.Text))
			{
				if (int.Parse(TextBox12.Text) <= 100 )
				{
					int g = default(int);
					decimal f = new decimal();
					g = (int) ((double.Parse(TextBox12.Text) * 100) / 100);
					TextBox13.Text = g.ToString();
					f = (decimal) (g * 0.3);
					TextBox14.Text = f.ToString();
					
				}
				else
				{
					MessageBox.Show("Please Enter value equal to 100 and below!");
					
					
				}
			}
			
			if (Information.IsNumeric(TextBox15.Text))
			{
				if (int.Parse(TextBox15.Text) <= 100 )
				{
					int j = default(int);
					decimal f1 = new decimal();
					j = (int) ((double.Parse(TextBox15.Text) * 100) / 100);
					TextBox16.Text = j.ToString();
					f1 = (decimal) (j * 0.3);
					TextBox17.Text = f1.ToString();
					
				}
				else
				{
					MessageBox.Show("Please Enter value equal to 100 and below!");
					
					
				}
			}
			
			decimal adal = new decimal();
			adal = (decimal) (Conversion.Val(TextBox5.Text) + Conversion.Val(TextBox8.Text) + Conversion.Val(TextBox11.Text) + Conversion.Val(TextBox14.Text) + Conversion.Val(TextBox17.Text));
			
			TextBox18.Text = adal.ToString();
			
			if (Conversion.Val(TextBox18.Text) <= 74)
			{
				
				TextBox19.Text = "Failed";
				TextBox19.ForeColor = Color.Red;
			}
			else
			{
				TextBox19.Text = "Passed";
				TextBox19.ForeColor = Color.Green;
				
				
			}
			
			
		}
		
		public void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			
		}
		
		public void Button3_Click(System.Object sender, System.EventArgs e)
		{
			
			TextBox1.Text = "";
			TextBox12.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox5.Text = "";
			TextBox6.Text = "";
			TextBox7.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			TextBox10.Text = "";
			TextBox11.Text = "";
			TextBox12.Text = "";
			TextBox13.Text = "";
			TextBox14.Text = "";
			TextBox15.Text = "";
			TextBox16.Text = "";
			TextBox17.Text = "";
			TextBox18.Text = "";
			TextBox19.Text = "";
			
			
		}
		
#region my data
		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);
			string sPath = Application.ExecutablePath;
			sPath = System.IO.Path.GetDirectoryName(sPath);
			
			if (sPath.EndsWith("\\bin"))
			{
				sPath = sPath.Substring(0, sPath.Length - 4);
			}
			
			gradeclass.DataModule = new gradeclass(sPath);
			
		}
#endregion
		
		public void Button5_Click(System.Object sender, System.EventArgs e)
		{
			newgrade = gradeclass.DataModule.GetLoad();
			DataGridView1.DataSource = newgrade;
			DataGridView1.DataMember = "grade1";
			
		}
		
		public void Button4_Click(System.Object sender, System.EventArgs e)
		{
			
			string strmessage = default(string);
			DialogResult dgrResult;
			
			strmessage = "Are you sure you want to save data?";
			dgrResult = MessageBox.Show(strmessage, "Save data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			
			
			if (dgrResult == System.Windows.Forms.DialogResult.Yes)
			{
				
				newgrade = gradeclass.DataModule.SaveItem();
			}
			
		}
		
		public void NavRecords()
		{
			
			STUDID.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][1]);
			TextBox1.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][2]);
			TextBox2.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][3]);
			TextBox3.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][4]);
			TextBox4.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][5]);
			TextBox5.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][6]);
			TextBox6.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][7]);
			TextBox7.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][8]);
			TextBox8.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][9]);
			TextBox9.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][10]);
			TextBox10.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][11]);
			TextBox11.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][12]);
			TextBox12.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][13]);
			TextBox13.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][14]);
			TextBox14.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][15]);
			TextBox15.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][16]);
			TextBox16.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][17]);
			TextBox17.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][18]);
			TextBox18.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][19]);
			TextBox19.Text = (string) (dsgrade.Tables["grade1"].Rows[inc][20]);
			
		}
		
		
		
		public void FRST_Click(System.Object sender, System.EventArgs e)
		{
			dsgrade = gradeclass.DataModule.navigate();
			if (inc != 0)
			{
				inc = 0;
				NavRecords();
				MessageBox.Show("First Record");
			}
		}
		
		public void PREV_Click(System.Object sender, System.EventArgs e)
		{
			
			dsgrade = gradeclass.DataModule.navigate();
			if (inc > 0)
			{
				inc--;
				NavRecords();
			}
			else if (inc == -1)
			{
				MessageBox.Show("No Records Yet");
			}
			else if (inc == 0)
			{
				MessageBox.Show("First Record");
			}
			
			
		}
		
		public void LAST_Click(System.Object sender, System.EventArgs e)
		{
			dsgrade = gradeclass.DataModule.navigate();
			MaxRows = dsgrade.Tables["grade1"].Rows.Count;
			if (inc != MaxRows)
			{
				inc = MaxRows - 1;
				NavRecords();
			}
			else
			{
				MessageBox.Show("Last Record");
			}
		}
		
		public void NXT_Click(System.Object sender, System.EventArgs e)
		{
			dsgrade = gradeclass.DataModule.navigate();
			try
			{
				if (inc != MaxRows - 1)
				{
					inc++;
					NavRecords();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("No More Rows");
			}
		}
		DataSet dsupdate;
		
		public void Button6_Click(System.Object sender, System.EventArgs e)
		{
			
			TextBox1.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
			TextBox2.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
			TextBox3.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
			TextBox4.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
			TextBox5.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
			TextBox6.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
			TextBox7.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
			TextBox8.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
			TextBox9.Text = DataGridView1.CurrentRow.Cells[9].Value.ToString();
			TextBox10.Text = DataGridView1.CurrentRow.Cells[10].Value.ToString();
			TextBox11.Text = DataGridView1.CurrentRow.Cells[11].Value.ToString();
			TextBox12.Text = DataGridView1.CurrentRow.Cells[12].Value.ToString();
			TextBox13.Text = DataGridView1.CurrentRow.Cells[13].Value.ToString();
			TextBox14.Text = DataGridView1.CurrentRow.Cells[14].Value.ToString();
			TextBox15.Text = DataGridView1.CurrentRow.Cells[15].Value.ToString();
			TextBox16.Text = DataGridView1.CurrentRow.Cells[16].Value.ToString();
			TextBox17.Text = DataGridView1.CurrentRow.Cells[17].Value.ToString();
			TextBox18.Text = DataGridView1.CurrentRow.Cells[18].Value.ToString();
			TextBox19.Text = DataGridView1.CurrentRow.Cells[19].Value.ToString();
			STUDID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
			
		}
		
		public void Button11_Click(System.Object sender, System.EventArgs e)
		{
			string strmessage = default(string);
			DialogResult dgrResult;
			
			strmessage = "Are you sure you want to Delete this record?";
			dgrResult = MessageBox.Show(strmessage, "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			
			
			if (dgrResult == System.Windows.Forms.DialogResult.Yes)
			{
				
				dsgrade = gradeclass.DataModule.deldata();
				
			}
			
			
			
		}
		
		public void Button7_Click(System.Object sender, System.EventArgs e)
		{
			dsgrade = gradeclass.DataModule.updtedata();
		}
		public void DataGridView1_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			TextBox1.Text = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			TextBox2.Text = DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			TextBox3.Text = DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			TextBox4.Text = DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			TextBox5.Text = DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			TextBox6.Text = DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			TextBox7.Text = DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			TextBox8.Text = DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			TextBox9.Text = DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
			TextBox10.Text = DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
			TextBox11.Text = DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
			TextBox12.Text = DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
			TextBox13.Text = DataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
			TextBox14.Text = DataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
			TextBox15.Text = DataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
			TextBox16.Text = DataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
			TextBox17.Text = DataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
			TextBox18.Text = DataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
			TextBox19.Text = DataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
			STUDID.Text = DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			
			
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bitmap, 0, 0);
		}	

		Bitmap bitmap;
			private void PRNT_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
			this.Controls.Add(panel);

			Graphics graphics = panel.CreateGraphics();
			Size size = this.ClientSize;
			bitmap = new Bitmap(size.Width, size.Height, graphics);
			graphics = Graphics.FromImage(bitmap);

			Point point = PointToScreen(panel.Location);
			graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();

		}

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
	
}
