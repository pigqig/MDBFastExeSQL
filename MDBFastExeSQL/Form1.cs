using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBFastExeSQL
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			txtMdbSource.Enabled = false;
			txtSqlPath.Enabled = false;

			btnOpendATA.Click += BtnOpendATA_Click;
			btnOpenSql.Click += BtnOpenSql_Click;
			btnExecute.Click += BtnExecute_Click;
			txtMessage.TextChanged += TxtMessage_TextChanged;
	
		}

		private void TxtMessage_TextChanged(object sender, EventArgs e)
		{
			txtMessage.SelectionStart = txtMessage.TextLength;

			// Scrolls the contents of the control to the current caret position.
			txtMessage.ScrollToCaret();


		}

		private void BtnExecute_Click(object sender, EventArgs e)
		{
			
			Task.Run(() => {
				if (string.IsNullOrEmpty(txtMdbSource.Text))
				{
					MessageBox.Show("沒選擇資料庫來源，我不幹事");
					return;
				}

				if (string.IsNullOrEmpty(txtSqlPath.Text))
				{
					MessageBox.Show("沒選要執行的SQL檔，要幹個屁事");
					return;
				}


				try
				{
					using (OleDbConnection oleDb = new OleDbConnection($@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {txtMdbSource.Text}"))
					{
						oleDb.Open();
						WriteToConsole("連線資料庫成功拉");

						using (FileStream fsFile = new FileStream($@"{txtSqlPath.Text}", FileMode.Open))
						{
							WriteToConsole("檔案開啟成功");
							Thread.Sleep(2000);
							var icmd = oleDb.CreateCommand();
							StreamReader srReader = new StreamReader(fsFile);
							string line;
							this.Invoke((Action)(() =>
							{
								while ((line = srReader.ReadLine()) != null)
								{

									try
									{
										string SQL = line;
										WriteToConsole($"執行指令： {SQL}");
										icmd.CommandText = SQL;
										icmd.ExecuteNonQuery();
									}
									catch (Exception ex)
									{

										WriteToConsole($@"執行{line}失敗{ex.Message}");

									}




								}
								srReader.Close();
							}
								));


						}

						oleDb.Close();
						oleDb.Dispose();
						WriteToConsole($@"執行結束");

					}


				}
				catch (Exception ex)
				{
					WriteToConsole(ex.Message + "");

				}
				finally
				{

				}
			});
			
			
			



		}


		internal void WriteToConsole(String message)
		{
			if (txtMessage.InvokeRequired)
			{
				this.Invoke((Action)(() =>
					WriteToConsole(message)
				));
				return;
			}
			txtMessage.AppendText(message + Environment.NewLine);
		}

		private void BtnOpenSql_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "(*.txt)|*.txt|(*.sql)|*.sql";
			file.FilterIndex = 2;

			file.ShowDialog();

			this.txtSqlPath.Text = file.FileName;
		}

		private void BtnOpendATA_Click(object sender, EventArgs e)
		{

			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "(*.mdb)|*.mdb";
			file.ShowDialog();
			
			this.txtMdbSource.Text = file.FileName;


		}
	}
}
