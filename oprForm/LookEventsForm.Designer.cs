﻿namespace oprForm
{
	partial class LookEventsForm
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
            this.eventListGrid = new System.Windows.Forms.DataGridView();
            this.Resource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expertsLB = new System.Windows.Forms.ListBox();
            this.docsLB = new System.Windows.Forms.ListBox();
            this.issuesLB = new System.Windows.Forms.ListBox();
            this.disaproveBtn = new System.Windows.Forms.Button();
            this.approveBtn = new System.Windows.Forms.Button();
            this.onlyDisCB = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.approveGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.issueLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.issueCostTB = new System.Windows.Forms.TextBox();
            this.issueTB = new System.Windows.Forms.TextBox();
            this.issueDescTB = new System.Windows.Forms.TextBox();
            this.issueListBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nextIssueBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsLB = new System.Windows.Forms.ListBox();
            this.dmCheck = new System.Windows.Forms.CheckBox();
            this.lawyerCheck = new System.Windows.Forms.CheckBox();
            this.findIssueCondTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.eventListGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.approveGB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventListGrid
            // 
            this.eventListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.eventListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resource,
            this.Description,
            this.Value,
            this.unitsCol,
            this.priceCol,
            this.totalPriceCol});
            this.eventListGrid.Location = new System.Drawing.Point(13, 169);
            this.eventListGrid.Margin = new System.Windows.Forms.Padding(4);
            this.eventListGrid.Name = "eventListGrid";
            this.eventListGrid.Size = new System.Drawing.Size(853, 225);
            this.eventListGrid.TabIndex = 10;
            // 
            // Resource
            // 
            this.Resource.HeaderText = "Назва";
            this.Resource.Name = "Resource";
            this.Resource.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Опис";
            this.Description.Name = "Description";
            // 
            // Value
            // 
            this.Value.HeaderText = "Кількість";
            this.Value.Name = "Value";
            // 
            // unitsCol
            // 
            this.unitsCol.HeaderText = "Одиниці Виміру";
            this.unitsCol.Name = "unitsCol";
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Ціна";
            this.priceCol.Name = "priceCol";
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.HeaderText = "Повна Ціна";
            this.totalPriceCol.Name = "totalPriceCol";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 700);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.eventListGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1180, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ресурси";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(130, 85);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(297, 21);
            this.textBox6.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Вартість задачі";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ресурси";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 125);
            this.panel1.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(91, 18);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(752, 21);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 50);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(751, 21);
            this.textBox4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Опис";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Задача";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Документи";
            // 
            // expertsLB
            // 
            this.expertsLB.FormattingEnabled = true;
            this.expertsLB.ItemHeight = 15;
            this.expertsLB.Location = new System.Drawing.Point(18, 281);
            this.expertsLB.Margin = new System.Windows.Forms.Padding(4);
            this.expertsLB.Name = "expertsLB";
            this.expertsLB.Size = new System.Drawing.Size(289, 229);
            this.expertsLB.TabIndex = 25;
            this.expertsLB.SelectedIndexChanged += new System.EventHandler(this.expertsLB_SelectedIndexChanged);
            // 
            // docsLB
            // 
            this.docsLB.FormattingEnabled = true;
            this.docsLB.ItemHeight = 15;
            this.docsLB.Location = new System.Drawing.Point(577, 281);
            this.docsLB.Margin = new System.Windows.Forms.Padding(4);
            this.docsLB.Name = "docsLB";
            this.docsLB.Size = new System.Drawing.Size(239, 229);
            this.docsLB.TabIndex = 23;
            this.docsLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.docsLB_MouseDoubleClick);
            // 
            // issuesLB
            // 
            this.issuesLB.FormattingEnabled = true;
            this.issuesLB.ItemHeight = 15;
            this.issuesLB.Location = new System.Drawing.Point(826, 75);
            this.issuesLB.Margin = new System.Windows.Forms.Padding(4);
            this.issuesLB.Name = "issuesLB";
            this.issuesLB.Size = new System.Drawing.Size(207, 184);
            this.issuesLB.TabIndex = 26;
            this.issuesLB.SelectedIndexChanged += new System.EventHandler(this.issuesLB_SelectedIndexChanged);
            // 
            // disaproveBtn
            // 
            this.disaproveBtn.Location = new System.Drawing.Point(698, 220);
            this.disaproveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disaproveBtn.Name = "disaproveBtn";
            this.disaproveBtn.Size = new System.Drawing.Size(108, 30);
            this.disaproveBtn.TabIndex = 15;
            this.disaproveBtn.Text = "Відхилити";
            this.disaproveBtn.UseVisualStyleBackColor = true;
            this.disaproveBtn.Click += new System.EventHandler(this.disaproveBtn_Click);
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(698, 186);
            this.approveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(108, 30);
            this.approveBtn.TabIndex = 14;
            this.approveBtn.Text = "Підтвердити";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // onlyDisCB
            // 
            this.onlyDisCB.AutoSize = true;
            this.onlyDisCB.Location = new System.Drawing.Point(23, 220);
            this.onlyDisCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.onlyDisCB.Name = "onlyDisCB";
            this.onlyDisCB.Size = new System.Drawing.Size(157, 19);
            this.onlyDisCB.TabIndex = 22;
            this.onlyDisCB.Text = "Тільки не затверждені";
            this.onlyDisCB.UseVisualStyleBackColor = true;
            this.onlyDisCB.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Список експертів";
            // 
            // approveGB
            // 
            this.approveGB.Controls.Add(this.previousBtn);
            this.approveGB.Controls.Add(this.nextIssueBtn);
            this.approveGB.Controls.Add(this.textBox2);
            this.approveGB.Controls.Add(this.label12);
            this.approveGB.Controls.Add(this.issueListBtn);
            this.approveGB.Controls.Add(this.issueDescTB);
            this.approveGB.Controls.Add(this.issueTB);
            this.approveGB.Controls.Add(this.issueCostTB);
            this.approveGB.Controls.Add(this.label9);
            this.approveGB.Controls.Add(this.issueLbl);
            this.approveGB.Controls.Add(this.label6);
            this.approveGB.Controls.Add(this.label3);
            this.approveGB.Location = new System.Drawing.Point(6, 4);
            this.approveGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approveGB.Name = "approveGB";
            this.approveGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approveGB.Size = new System.Drawing.Size(777, 140);
            this.approveGB.TabIndex = 20;
            this.approveGB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Опис";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Задача";
            // 
            // issueLbl
            // 
            this.issueLbl.AutoSize = true;
            this.issueLbl.Location = new System.Drawing.Point(173, 46);
            this.issueLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.issueLbl.Name = "issueLbl";
            this.issueLbl.Size = new System.Drawing.Size(0, 15);
            this.issueLbl.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Необхідно грошей";
            // 
            // issueCostTB
            // 
            this.issueCostTB.Location = new System.Drawing.Point(140, 78);
            this.issueCostTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issueCostTB.Name = "issueCostTB";
            this.issueCostTB.ReadOnly = true;
            this.issueCostTB.Size = new System.Drawing.Size(175, 21);
            this.issueCostTB.TabIndex = 24;
            // 
            // issueTB
            // 
            this.issueTB.Location = new System.Drawing.Point(138, 15);
            this.issueTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issueTB.Name = "issueTB";
            this.issueTB.ReadOnly = true;
            this.issueTB.Size = new System.Drawing.Size(625, 21);
            this.issueTB.TabIndex = 25;
            // 
            // issueDescTB
            // 
            this.issueDescTB.Location = new System.Drawing.Point(138, 45);
            this.issueDescTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issueDescTB.Name = "issueDescTB";
            this.issueDescTB.ReadOnly = true;
            this.issueDescTB.Size = new System.Drawing.Size(625, 21);
            this.issueDescTB.TabIndex = 26;
            // 
            // issueListBtn
            // 
            this.issueListBtn.Location = new System.Drawing.Point(606, 99);
            this.issueListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.issueListBtn.Name = "issueListBtn";
            this.issueListBtn.Size = new System.Drawing.Size(157, 28);
            this.issueListBtn.TabIndex = 32;
            this.issueListBtn.Text = "Список задач";
            this.issueListBtn.UseVisualStyleBackColor = true;
            this.issueListBtn.Click += new System.EventHandler(this.IssueListClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Тематика";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(175, 21);
            this.textBox2.TabIndex = 34;
            // 
            // nextIssueBtn
            // 
            this.nextIssueBtn.Enabled = false;
            this.nextIssueBtn.Location = new System.Drawing.Point(465, 102);
            this.nextIssueBtn.Name = "nextIssueBtn";
            this.nextIssueBtn.Size = new System.Drawing.Size(90, 28);
            this.nextIssueBtn.TabIndex = 35;
            this.nextIssueBtn.Text = "Наступна";
            this.nextIssueBtn.UseVisualStyleBackColor = true;
            this.nextIssueBtn.Click += new System.EventHandler(this.NextIssueClick);
            // 
            // previousBtn
            // 
            this.previousBtn.Enabled = false;
            this.previousBtn.Location = new System.Drawing.Point(368, 102);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(90, 28);
            this.previousBtn.TabIndex = 36;
            this.previousBtn.Text = "Попередня";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.PreviousIssueClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(874, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Знайдені задачі";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Список заходiв";
            // 
            // eventsLB
            // 
            this.eventsLB.FormattingEnabled = true;
            this.eventsLB.ItemHeight = 15;
            this.eventsLB.Location = new System.Drawing.Point(315, 281);
            this.eventsLB.Margin = new System.Windows.Forms.Padding(4);
            this.eventsLB.Name = "eventsLB";
            this.eventsLB.Size = new System.Drawing.Size(254, 229);
            this.eventsLB.TabIndex = 8;
            this.eventsLB.SelectedIndexChanged += new System.EventHandler(this.eventsLB_SelectedIndexChanged);
            // 
            // dmCheck
            // 
            this.dmCheck.AutoSize = true;
            this.dmCheck.Enabled = false;
            this.dmCheck.Location = new System.Drawing.Point(422, 220);
            this.dmCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dmCheck.Name = "dmCheck";
            this.dmCheck.Size = new System.Drawing.Size(178, 19);
            this.dmCheck.TabIndex = 31;
            this.dmCheck.Text = "Підтвердження аналітика";
            this.dmCheck.UseVisualStyleBackColor = true;
            // 
            // lawyerCheck
            // 
            this.lawyerCheck.AutoSize = true;
            this.lawyerCheck.Enabled = false;
            this.lawyerCheck.Location = new System.Drawing.Point(215, 220);
            this.lawyerCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lawyerCheck.Name = "lawyerCheck";
            this.lawyerCheck.Size = new System.Drawing.Size(163, 19);
            this.lawyerCheck.TabIndex = 32;
            this.lawyerCheck.Text = "Підтвердження юриста";
            this.lawyerCheck.UseVisualStyleBackColor = true;
            // 
            // findIssueCondTB
            // 
            this.findIssueCondTB.Location = new System.Drawing.Point(15, 182);
            this.findIssueCondTB.Margin = new System.Windows.Forms.Padding(4);
            this.findIssueCondTB.Name = "findIssueCondTB";
            this.findIssueCondTB.Size = new System.Drawing.Size(401, 21);
            this.findIssueCondTB.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 26);
            this.button2.TabIndex = 34;
            this.button2.Text = "Пошук";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 250);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 27);
            this.button5.TabIndex = 38;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.findIssueCondTB);
            this.tabPage1.Controls.Add(this.lawyerCheck);
            this.tabPage1.Controls.Add(this.dmCheck);
            this.tabPage1.Controls.Add(this.eventsLB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.approveGB);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.onlyDisCB);
            this.tabPage1.Controls.Add(this.approveBtn);
            this.tabPage1.Controls.Add(this.disaproveBtn);
            this.tabPage1.Controls.Add(this.issuesLB);
            this.tabPage1.Controls.Add(this.docsLB);
            this.tabPage1.Controls.Add(this.expertsLB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1180, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Головна";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LookEventsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1025, 749);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LookEventsForm";
            this.Text = "Перегляд задач";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.eventListGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.approveGB.ResumeLayout(false);
            this.approveGB.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView eventListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceCol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox findIssueCondTB;
        private System.Windows.Forms.CheckBox lawyerCheck;
        private System.Windows.Forms.CheckBox dmCheck;
        private System.Windows.Forms.ListBox eventsLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox approveGB;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextIssueBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button issueListBtn;
        private System.Windows.Forms.TextBox issueDescTB;
        private System.Windows.Forms.TextBox issueTB;
        private System.Windows.Forms.TextBox issueCostTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label issueLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox onlyDisCB;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button disaproveBtn;
        private System.Windows.Forms.ListBox issuesLB;
        private System.Windows.Forms.ListBox docsLB;
        private System.Windows.Forms.ListBox expertsLB;
        private System.Windows.Forms.Label label7;
    }
}