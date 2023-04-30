
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
	public class gradeclass
	{
		string mDataPath;
		public static gradeclass DataModule;
		
		private System.Data.OleDb.OleDbConnection GetConnection()
		{
			return new System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mDataPath + "\\grade1.accdb");
		}
		
		public gradeclass(string sDatapath)
		{
			this.mDataPath = sDatapath;
			gradeclass.DataModule = this;
			
		}
		
		public DataSet GetLoad()
		{
			return this.GetLoad("data1");
		}
		
		public DataSet GetLoad(string sortfield)
		{
			
			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();
			
			try
			{
				
				// Dim sql As String = "SELECT ID data1 as [Firstname],data2 as [Lastname],data3 as [20],data4 as [EG],data5 as [1st-10%],data6 as [50pt],data7 as [EG1],data8 as [2nd-10%],data9 as [50pts],data10 as [EG2],data11 as [20%],data12 as [100pt],data13 as [EG3],data14 as [30%],data15 as [100],data16 as [EG4],data17 as [2nd-30%],data18 as [PrelimGrade],data19 as [Remarks]FROM Table1 order by " + sortfield
				string sql = "SELECT STUDENTID,data1 AS Firstname, data2 AS Lastname," + "data3 AS 20, data4 AS EG, data5 AS [1st-10%], data6 AS 50pt," + "data7 AS EG1, data8 AS [2nd-10%], data9 AS 50pts, data10 AS EG2," + "data11 AS [20%], data12 AS 100pt, data13 AS EG3, data14 AS [30%]," + "data15 AS 100, data16 AS EG4, data17 AS [2nd-30%], data18 AS PrelimGrade," + "data19 AS Remarks FROM Table1 ORDER BY ID";
				
				System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
				try
				{
					da.Fill(ds, "grade1");
				}
				finally
				{
					da.Dispose();
				}
				return ds;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}
		public void RefreshDGV()
		{
			
			System.Data.OleDb.OleDbConnection conn = GetConnection();
			string sql = default(string);
			sql = "SELECT STUDENTID,data1 AS Firstname, data2 AS Lastname," + "data3 AS 20, data4 AS EG, data5 AS [1st-10%], data6 AS 50pt," + "data7 AS EG1, data8 AS [2nd-10%], data9 AS 50pts, data10 AS EG2," + "data11 AS [20%], data12 AS 100pt, data13 AS EG3, data14 AS [30%]," + "data15 AS 100, data16 AS EG4, data17 AS [2nd-30%], data18 AS PrelimGrade," + "data19 AS Remarks FROM Table1 ORDER BY ID";
			
			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable("grade1");
			da.Fill(dt);
			Form1.Default.DataGridView1.DataSource = dt;
		}
		public void clearall()
		{
			Form1.Default.TextBox1.Text = "";
			Form1.Default.TextBox2.Text = "";
			Form1.Default.TextBox3.Text = "";
			Form1.Default.TextBox4.Text = "";
			Form1.Default.TextBox5.Text = "";
			Form1.Default.TextBox6.Text = "";
			Form1.Default.TextBox7.Text = "";
			Form1.Default.TextBox8.Text = "";
			Form1.Default.TextBox9.Text = "";
			Form1.Default.TextBox10.Text = "";
			Form1.Default.TextBox11.Text = "";
			Form1.Default.TextBox12.Text = "";
			Form1.Default.TextBox13.Text = "";
			Form1.Default.TextBox14.Text = "";
			Form1.Default.TextBox15.Text = "";
			Form1.Default.TextBox16.Text = "";
			Form1.Default.TextBox17.Text = "";
			Form1.Default.TextBox18.Text = "";
			Form1.Default.TextBox19.Text = "";
			Form1.Default.STUDID.Text = "";
			
			
		}
		
		public DataSet SaveItem()
		{
			return this.SaveItem("data1");
		}
		public DataSet SaveItem(string sortfield)
		{
			
			System.Data.OleDb.OleDbConnection conn = GetConnection();
			
			try
			{
				
				string SQL = default(string);
				
				SQL = "INSERT INTO TABLE1 (STUDENTID, DATA1, DATA2, DATA3, DATA4, DATA5,DATA6, DATA7," + "DATA8, DATA9, DATA10, DATA11, DATA12, DATA13, DATA14, DATA15, DATA16, DATA17, DATA18," + "DATA19) VALUES(@STUDENTID, @DATA1, @DATA2, @DATA3, @DATA4, @DATA5,@DATA6, @DATA7,DATA8, @DATA9," + "@DATA10, @DATA11, @DATA12, @DATA13, @DATA14, @DATA15, @DATA16, @DATA17, @DATA18, @DATA19)";
				System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(SQL, conn);
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@STUDENTID", Form1.Default.STUDID.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA1", Form1.Default.TextBox1.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA2", Form1.Default.TextBox2.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA3", Form1.Default.TextBox3.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA4", Form1.Default.TextBox4.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA5", Form1.Default.TextBox5.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA6", Form1.Default.TextBox6.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA7", Form1.Default.TextBox7.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA8", Form1.Default.TextBox8.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA9", Form1.Default.TextBox9.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA10", Form1.Default.TextBox10.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA11", Form1.Default.TextBox11.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA12", Form1.Default.TextBox12.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA13", Form1.Default.TextBox13.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA14", Form1.Default.TextBox14.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA15", Form1.Default.TextBox15.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA16", Form1.Default.TextBox16.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA17", Form1.Default.TextBox17.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA18", Form1.Default.TextBox18.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA19", Form1.Default.TextBox19.Text));
				
				conn.Open();
				cmd.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("New data is Added!");
				
				Form1.Default.TextBox1.Text = "";
				Form1.Default.TextBox2.Text = "";
				Form1.Default.TextBox3.Text = "";
				Form1.Default.TextBox4.Text = "";
				Form1.Default.TextBox5.Text = "";
				Form1.Default.TextBox6.Text = "";
				Form1.Default.TextBox7.Text = "";
				Form1.Default.TextBox8.Text = "";
				Form1.Default.TextBox9.Text = "";
				Form1.Default.TextBox10.Text = "";
				Form1.Default.TextBox11.Text = "";
				Form1.Default.TextBox12.Text = "";
				Form1.Default.TextBox13.Text = "";
				Form1.Default.TextBox14.Text = "";
				Form1.Default.TextBox15.Text = "";
				Form1.Default.TextBox16.Text = "";
				Form1.Default.TextBox17.Text = "";
				Form1.Default.TextBox18.Text = "";
				Form1.Default.TextBox19.Text = "";
				Form1.Default.STUDID.Text = "";
				
				RefreshDGV();
				
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			
			return default(DataSet);
		}
		
		public DataSet navigate()
		{
			return this.navigate("data2");
		}
		public DataSet navigate(string sortfield)
		{
			
			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();
			
			try
			{
				
				int inc;
				int MaxRows;
				
				string sql = "select * from table1";
				System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
				
				try
				{
					da.Fill(ds, "grade1");
					MaxRows = ds.Tables["grade1"].Rows.Count;
					inc = -1;
					
					
				}
				finally
				{
					da.Dispose();
				}
				
				return ds;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}
		public DataSet deldata()
		{
			return this.deldata("data2");
		}
		public DataSet deldata(string sortfield)
		{
			
			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();
			
			try
			{
				
				int inc;
				int MaxRows;
				
				//Dim sql As String = "select * from table1"
				//Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
				
				try
				{

					string sqldelete = default(string);
					sqldelete = "DELETE * FROM  table1 WHERE STUDENTID=\'" + Form1.Default.STUDID.Text + "\'";
					System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sqldelete, conn);
					
					// Gets the records from the table and fills our adapter with those.
					DataTable dt = new DataTable("grade1");
					da.Fill(dt);
					MessageBox.Show("Data has been deleted");
					clearall();
					
					Form1.Default.DataGridView1.DataSource = dt;
					
					RefreshDGV();
					
				}
				finally
				{
					//da.Dispose()
				}
				
				return ds;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}
		
		public DataSet updtedata()
		{
			return this.updtedata("data0");
		}
		public DataSet updtedata(string sortfield)
		{
			
			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();
			
			try
			{
				
				string sqlupdate = default(string);
				
				sqlupdate = "UPDATE Table1 set STUDENTID=@STUDENTID, data1=@data1, data2=@data2, data3=@data3, data4=@data4," + "data5=@data5, data6=@data6, data7=@data7, data8=@data8, data9=@data9, data10=@data10," + "data11=@data11, data12=@data12, data13=@data13, data14=@data14, data15=@data15, data16=@data16," + "data17=@data17, data18=@data18, data19=@data19 where STUDENTID=\'" + Form1.Default.STUDID.Text + "\'";
				System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(sqlupdate, conn);
				
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@STUDENTID", Form1.Default.STUDID.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA1", Form1.Default.TextBox1.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA2", Form1.Default.TextBox2.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA3", Form1.Default.TextBox3.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA4", Form1.Default.TextBox4.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA5", Form1.Default.TextBox5.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA6", Form1.Default.TextBox6.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA7", Form1.Default.TextBox7.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA8", Form1.Default.TextBox8.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA9", Form1.Default.TextBox9.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA10", Form1.Default.TextBox10.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA11", Form1.Default.TextBox11.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA12", Form1.Default.TextBox12.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA13", Form1.Default.TextBox13.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA14", Form1.Default.TextBox14.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA15", Form1.Default.TextBox15.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA16", Form1.Default.TextBox16.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA17", Form1.Default.TextBox17.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA18", Form1.Default.TextBox18.Text));
				cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DATA19", Form1.Default.TextBox19.Text));
				
				conn.Open();
				cmd.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("Data Updated in the Database");
				RefreshDGV();
				
			}
			finally
			{
			}
			return ds;
		}
		
		
	}
}
