namespace ServerUDPWinForms
{
	partial class ServerForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxLauncher = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxServerPort = new System.Windows.Forms.TextBox();
			this.textBoxClientsLimit = new System.Windows.Forms.TextBox();
			this.textBoxRequestLimit = new System.Windows.Forms.TextBox();
			this.textBoxClientTimeOut = new System.Windows.Forms.TextBox();
			this.buttonStartStopServer = new System.Windows.Forms.Button();
			this.labelServerStatus = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBoxLoadedDocs = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.richTextBoxServerMesseges = new System.Windows.Forms.RichTextBox();
			this.serverFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBoxLauncher.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.serverFormBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.groupBoxLauncher, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBoxLauncher
			// 
			this.groupBoxLauncher.Controls.Add(this.tableLayoutPanel2);
			this.groupBoxLauncher.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxLauncher.Location = new System.Drawing.Point(3, 3);
			this.groupBoxLauncher.Name = "groupBoxLauncher";
			this.groupBoxLauncher.Size = new System.Drawing.Size(794, 144);
			this.groupBoxLauncher.TabIndex = 0;
			this.groupBoxLauncher.TabStop = false;
			this.groupBoxLauncher.Text = "Запуск Сервера";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBoxServerPort, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxClientsLimit, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBoxRequestLimit, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBoxClientTimeOut, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.buttonStartStopServer, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.labelServerStatus, 2, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 125);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Порт сервера";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Максимальное количество клиентов";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "Макс. кол-во запросов от клиента";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(256, 32);
			this.label4.TabIndex = 3;
			this.label4.Text = "Время ожидания клиента, с";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxServerPort
			// 
			this.textBoxServerPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxServerPort.Location = new System.Drawing.Point(265, 3);
			this.textBoxServerPort.Name = "textBoxServerPort";
			this.textBoxServerPort.Size = new System.Drawing.Size(256, 20);
			this.textBoxServerPort.TabIndex = 4;
			this.textBoxServerPort.Text = "2222";
			// 
			// textBoxClientsLimit
			// 
			this.textBoxClientsLimit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxClientsLimit.Location = new System.Drawing.Point(265, 34);
			this.textBoxClientsLimit.Name = "textBoxClientsLimit";
			this.textBoxClientsLimit.Size = new System.Drawing.Size(256, 20);
			this.textBoxClientsLimit.TabIndex = 5;
			this.textBoxClientsLimit.Text = "10";
			// 
			// textBoxRequestLimit
			// 
			this.textBoxRequestLimit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxRequestLimit.Location = new System.Drawing.Point(265, 65);
			this.textBoxRequestLimit.Name = "textBoxRequestLimit";
			this.textBoxRequestLimit.Size = new System.Drawing.Size(256, 20);
			this.textBoxRequestLimit.TabIndex = 6;
			this.textBoxRequestLimit.Text = "10";
			// 
			// textBoxClientTimeOut
			// 
			this.textBoxClientTimeOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxClientTimeOut.Location = new System.Drawing.Point(265, 96);
			this.textBoxClientTimeOut.Name = "textBoxClientTimeOut";
			this.textBoxClientTimeOut.Size = new System.Drawing.Size(256, 20);
			this.textBoxClientTimeOut.TabIndex = 7;
			this.textBoxClientTimeOut.Text = "600";
			// 
			// buttonStartStopServer
			// 
			this.buttonStartStopServer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonStartStopServer.Location = new System.Drawing.Point(527, 3);
			this.buttonStartStopServer.Name = "buttonStartStopServer";
			this.tableLayoutPanel2.SetRowSpan(this.buttonStartStopServer, 2);
			this.buttonStartStopServer.Size = new System.Drawing.Size(258, 56);
			this.buttonStartStopServer.TabIndex = 8;
			this.buttonStartStopServer.Text = "Запуск сервера";
			this.buttonStartStopServer.UseVisualStyleBackColor = true;
			this.buttonStartStopServer.Click += new System.EventHandler(this.buttonStartStopServer_Click);
			// 
			// labelServerStatus
			// 
			this.labelServerStatus.AutoSize = true;
			this.labelServerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelServerStatus.ForeColor = System.Drawing.Color.Red;
			this.labelServerStatus.Location = new System.Drawing.Point(527, 62);
			this.labelServerStatus.Name = "labelServerStatus";
			this.tableLayoutPanel2.SetRowSpan(this.labelServerStatus, 2);
			this.labelServerStatus.Size = new System.Drawing.Size(258, 63);
			this.labelServerStatus.TabIndex = 9;
			this.labelServerStatus.Text = "Статус сервера: НЕ ЗАПУЩЕН";
			this.labelServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.splitContainer1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 153);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 294);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Рецепты доступные для передачи";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 16);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBoxLoadedDocs);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(788, 275);
			this.splitContainer1.SplitterDistance = 331;
			this.splitContainer1.TabIndex = 1;
			// 
			// listBoxLoadedDocs
			// 
			this.listBoxLoadedDocs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxLoadedDocs.FormattingEnabled = true;
			this.listBoxLoadedDocs.Location = new System.Drawing.Point(0, 0);
			this.listBoxLoadedDocs.Name = "listBoxLoadedDocs";
			this.listBoxLoadedDocs.Size = new System.Drawing.Size(331, 275);
			this.listBoxLoadedDocs.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBoxServerMesseges);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(453, 275);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Собщения сервера";
			// 
			// richTextBoxServerMesseges
			// 
			this.richTextBoxServerMesseges.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxServerMesseges.Location = new System.Drawing.Point(3, 16);
			this.richTextBoxServerMesseges.Name = "richTextBoxServerMesseges";
			this.richTextBoxServerMesseges.ReadOnly = true;
			this.richTextBoxServerMesseges.Size = new System.Drawing.Size(447, 256);
			this.richTextBoxServerMesseges.TabIndex = 0;
			this.richTextBoxServerMesseges.Text = "";
			// 
			// serverFormBindingSource
			// 
			this.serverFormBindingSource.DataSource = typeof(ServerUDPWinForms.ServerForm);
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ServerForm";
			this.Text = "Сервер";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBoxLauncher.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.serverFormBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBoxLauncher;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxServerPort;
		private System.Windows.Forms.TextBox textBoxClientsLimit;
		private System.Windows.Forms.TextBox textBoxRequestLimit;
		private System.Windows.Forms.TextBox textBoxClientTimeOut;
		private System.Windows.Forms.Button buttonStartStopServer;
		private System.Windows.Forms.Label labelServerStatus;
		private System.Windows.Forms.BindingSource serverFormBindingSource;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBoxLoadedDocs;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox richTextBoxServerMesseges;
	}
}

