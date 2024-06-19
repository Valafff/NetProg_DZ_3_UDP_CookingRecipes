namespace ClientWindowsForms
{
	partial class UDPClientForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxIPaddress = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxRequest = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.richTextBoxServerAnswer = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 70);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Подключение к серверу";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.textBoxIPaddress, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxPort, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 51);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP-адрес сервера";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Порт сервера";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxIPaddress
			// 
			this.textBoxIPaddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxIPaddress.Location = new System.Drawing.Point(265, 3);
			this.textBoxIPaddress.Name = "textBoxIPaddress";
			this.textBoxIPaddress.Size = new System.Drawing.Size(256, 20);
			this.textBoxIPaddress.TabIndex = 2;
			this.textBoxIPaddress.Text = "127.0.0.1";
			// 
			// textBoxPort
			// 
			this.textBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPort.Location = new System.Drawing.Point(265, 28);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(256, 20);
			this.textBoxPort.TabIndex = 3;
			this.textBoxPort.Text = "2222";
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(527, 3);
			this.button1.Name = "button1";
			this.tableLayoutPanel2.SetRowSpan(this.button1, 2);
			this.button1.Size = new System.Drawing.Size(258, 45);
			this.button1.TabIndex = 4;
			this.button1.Text = "Сохранить настройки и запустить клиент";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 79);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(794, 70);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Запрос";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.textBoxRequest, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.buttonSearch, 2, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 51);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 51);
			this.label3.TabIndex = 0;
			this.label3.Text = "Введите ключевое слово";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxRequest
			// 
			this.textBoxRequest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxRequest.Location = new System.Drawing.Point(265, 3);
			this.textBoxRequest.Multiline = true;
			this.textBoxRequest.Name = "textBoxRequest";
			this.textBoxRequest.Size = new System.Drawing.Size(256, 45);
			this.textBoxRequest.TabIndex = 1;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSearch.Location = new System.Drawing.Point(527, 3);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(258, 45);
			this.buttonSearch.TabIndex = 2;
			this.buttonSearch.Text = "Поиск";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.richTextBoxServerAnswer);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 155);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(794, 292);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ответ сервера";
			// 
			// richTextBoxServerAnswer
			// 
			this.richTextBoxServerAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxServerAnswer.Location = new System.Drawing.Point(3, 16);
			this.richTextBoxServerAnswer.Name = "richTextBoxServerAnswer";
			this.richTextBoxServerAnswer.Size = new System.Drawing.Size(788, 273);
			this.richTextBoxServerAnswer.TabIndex = 0;
			this.richTextBoxServerAnswer.Text = "";
			// 
			// UDPClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "UDPClientForm";
			this.Text = "UDP Клиент";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxIPaddress;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxRequest;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.RichTextBox richTextBoxServerAnswer;
	}
}

