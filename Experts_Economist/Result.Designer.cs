﻿namespace Experts_Economist
{
    partial class Result
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.number_of_calcL = new System.Windows.Forms.Label();
            this.calc_numbCB = new System.Windows.Forms.ComboBox();
            this.desc_of_seriesTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_desc = new System.Windows.Forms.Button();
            this.issueL = new System.Windows.Forms.Label();
            this.issueTB = new System.Windows.Forms.ComboBox();
            this.Panel_redakt = new System.Windows.Forms.Button();
            this.Delete_desc = new System.Windows.Forms.Button();
            this.Mass_delete = new System.Windows.Forms.Button();
            this.chartBox = new System.Windows.Forms.GroupBox();
            this.newChartButt = new System.Windows.Forms.Button();
            this.chartsLabel = new System.Windows.Forms.Label();
            this.chartsList = new System.Windows.Forms.ComboBox();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.chartButt = new System.Windows.Forms.Button();
            this.chartLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.experts_CB = new System.Windows.Forms.ComboBox();
            this.name_of_seriesCB = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.оновитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_of_formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.chartBox.SuspendLayout();
            this.chartPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.index,
            this.measure,
            this.id_of_formula});
            this.DGV.Location = new System.Drawing.Point(16, 64);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(598, 416);
            this.DGV.TabIndex = 1;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            this.DGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellEndEdit);
            this.DGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_CellFormatting);
            this.DGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_EditingControlShowing);
            this.DGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGV_KeyUp);
            // 
            // number_of_calcL
            // 
            this.number_of_calcL.AutoSize = true;
            this.number_of_calcL.Location = new System.Drawing.Point(856, 500);
            this.number_of_calcL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number_of_calcL.Name = "number_of_calcL";
            this.number_of_calcL.Size = new System.Drawing.Size(143, 17);
            this.number_of_calcL.TabIndex = 16;
            this.number_of_calcL.Text = "Серія розрахунків №";
            this.number_of_calcL.Visible = false;
            // 
            // calc_numbCB
            // 
            this.calc_numbCB.FormattingEnabled = true;
            this.calc_numbCB.Location = new System.Drawing.Point(856, 519);
            this.calc_numbCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calc_numbCB.Name = "calc_numbCB";
            this.calc_numbCB.Size = new System.Drawing.Size(160, 24);
            this.calc_numbCB.TabIndex = 17;
            this.calc_numbCB.Visible = false;
            this.calc_numbCB.SelectedIndexChanged += new System.EventHandler(this.calc_numbCB_SelectedIndexChanged);
            this.calc_numbCB.TextChanged += new System.EventHandler(this.calc_numbCB_TextChanged);
            this.calc_numbCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_numbCB_KeyPress);
            // 
            // desc_of_seriesTB
            // 
            this.desc_of_seriesTB.Location = new System.Drawing.Point(652, 88);
            this.desc_of_seriesTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.desc_of_seriesTB.Name = "desc_of_seriesTB";
            this.desc_of_seriesTB.ReadOnly = true;
            this.desc_of_seriesTB.Size = new System.Drawing.Size(392, 95);
            this.desc_of_seriesTB.TabIndex = 26;
            this.desc_of_seriesTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Опис серії";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Назва серії";
            // 
            // change_desc
            // 
            this.change_desc.Location = new System.Drawing.Point(646, 190);
            this.change_desc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.change_desc.Name = "change_desc";
            this.change_desc.Size = new System.Drawing.Size(140, 49);
            this.change_desc.TabIndex = 27;
            this.change_desc.Text = "Зберегти зміни";
            this.toolTip1.SetToolTip(this.change_desc, "Зберігає зміни - Назву серії, Проблему, Опис");
            this.change_desc.UseVisualStyleBackColor = true;
            this.change_desc.Click += new System.EventHandler(this.change_desc_Click);
            // 
            // issueL
            // 
            this.issueL.AutoSize = true;
            this.issueL.Location = new System.Drawing.Point(456, 11);
            this.issueL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.issueL.Name = "issueL";
            this.issueL.Size = new System.Drawing.Size(188, 17);
            this.issueL.TabIndex = 29;
            this.issueL.Text = "Задача, пов\'язана з серією";
            // 
            // issueTB
            // 
            this.issueTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issueTB.Enabled = false;
            this.issueTB.FormattingEnabled = true;
            this.issueTB.Location = new System.Drawing.Point(456, 31);
            this.issueTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.issueTB.Name = "issueTB";
            this.issueTB.Size = new System.Drawing.Size(493, 24);
            this.issueTB.TabIndex = 28;
            // 
            // Panel_redakt
            // 
            this.Panel_redakt.BackColor = System.Drawing.Color.Brown;
            this.Panel_redakt.Location = new System.Drawing.Point(652, 251);
            this.Panel_redakt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_redakt.Name = "Panel_redakt";
            this.Panel_redakt.Size = new System.Drawing.Size(140, 47);
            this.Panel_redakt.TabIndex = 30;
            this.Panel_redakt.Text = "Редагування серії";
            this.toolTip1.SetToolTip(this.Panel_redakt, "Вмикає/вимикає режим редагування. Стосується таких данних - Значення параметрів, " +
        "Назва серії, Проблема та Опис серії");
            this.Panel_redakt.UseVisualStyleBackColor = false;
            this.Panel_redakt.Click += new System.EventHandler(this.Panel_redakt_Click);
            // 
            // Delete_desc
            // 
            this.Delete_desc.Location = new System.Drawing.Point(794, 191);
            this.Delete_desc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_desc.Name = "Delete_desc";
            this.Delete_desc.Size = new System.Drawing.Size(119, 49);
            this.Delete_desc.TabIndex = 31;
            this.Delete_desc.Text = "Видалити всю серію";
            this.toolTip1.SetToolTip(this.Delete_desc, "Видаляє всі розрахунки та опис серії");
            this.Delete_desc.UseVisualStyleBackColor = true;
            this.Delete_desc.Click += new System.EventHandler(this.Delete_desc_Click);
            // 
            // Mass_delete
            // 
            this.Mass_delete.Location = new System.Drawing.Point(925, 191);
            this.Mass_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mass_delete.Name = "Mass_delete";
            this.Mass_delete.Size = new System.Drawing.Size(119, 49);
            this.Mass_delete.TabIndex = 32;
            this.Mass_delete.Text = "Видалити дані серії";
            this.toolTip1.SetToolTip(this.Mass_delete, "Видаляє всі розрахунки у даній серії");
            this.Mass_delete.UseVisualStyleBackColor = true;
            this.Mass_delete.Click += new System.EventHandler(this.Mass_delete_Click);
            // 
            // chartBox
            // 
            this.chartBox.Controls.Add(this.newChartButt);
            this.chartBox.Controls.Add(this.chartsLabel);
            this.chartBox.Controls.Add(this.chartsList);
            this.chartBox.Location = new System.Drawing.Point(636, 357);
            this.chartBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartBox.Name = "chartBox";
            this.chartBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartBox.Size = new System.Drawing.Size(396, 123);
            this.chartBox.TabIndex = 43;
            this.chartBox.TabStop = false;
            this.chartBox.Visible = false;
            // 
            // newChartButt
            // 
            this.newChartButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newChartButt.Location = new System.Drawing.Point(116, 63);
            this.newChartButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newChartButt.Name = "newChartButt";
            this.newChartButt.Size = new System.Drawing.Size(240, 28);
            this.newChartButt.TabIndex = 41;
            this.newChartButt.Text = "Відобразити графік";
            this.newChartButt.UseVisualStyleBackColor = true;
            this.newChartButt.Click += new System.EventHandler(this.newChartButt_Click);
            // 
            // chartsLabel
            // 
            this.chartsLabel.AutoSize = true;
            this.chartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartsLabel.Location = new System.Drawing.Point(12, 20);
            this.chartsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chartsLabel.Name = "chartsLabel";
            this.chartsLabel.Size = new System.Drawing.Size(78, 20);
            this.chartsLabel.TabIndex = 40;
            this.chartsLabel.Text = "Графіки";
            // 
            // chartsList
            // 
            this.chartsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartsList.FormattingEnabled = true;
            this.chartsList.Items.AddRange(new object[] {
            "Графік показника",
            "Графік проблеми"});
            this.chartsList.Location = new System.Drawing.Point(100, 14);
            this.chartsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartsList.Name = "chartsList";
            this.chartsList.Size = new System.Drawing.Size(281, 28);
            this.chartsList.TabIndex = 39;
            // 
            // chartPanel
            // 
            this.chartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPanel.Controls.Add(this.chartButt);
            this.chartPanel.Controls.Add(this.chartLabel);
            this.chartPanel.Location = new System.Drawing.Point(850, 247);
            this.chartPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(194, 87);
            this.chartPanel.TabIndex = 42;
            // 
            // chartButt
            // 
            this.chartButt.Location = new System.Drawing.Point(8, 38);
            this.chartButt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartButt.Name = "chartButt";
            this.chartButt.Size = new System.Drawing.Size(71, 32);
            this.chartButt.TabIndex = 1;
            this.chartButt.Text = "→";
            this.chartButt.UseVisualStyleBackColor = true;
            this.chartButt.Click += new System.EventHandler(this.chartButt_Click);
            // 
            // chartLabel
            // 
            this.chartLabel.AutoSize = true;
            this.chartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartLabel.Location = new System.Drawing.Point(4, 12);
            this.chartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chartLabel.Name = "chartLabel";
            this.chartLabel.Size = new System.Drawing.Size(99, 24);
            this.chartLabel.TabIndex = 0;
            this.chartLabel.Text = "Графіки  ";
            this.chartLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Вибір експерта";
            // 
            // experts_CB
            // 
            this.experts_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.experts_CB.FormattingEnabled = true;
            this.experts_CB.Location = new System.Drawing.Point(789, 1);
            this.experts_CB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.experts_CB.Name = "experts_CB";
            this.experts_CB.Size = new System.Drawing.Size(160, 24);
            this.experts_CB.TabIndex = 50;
            this.experts_CB.SelectedIndexChanged += new System.EventHandler(this.experts_CB_SelectedIndexChanged);
            // 
            // name_of_seriesCB
            // 
            this.name_of_seriesCB.FormattingEnabled = true;
            this.name_of_seriesCB.Location = new System.Drawing.Point(16, 31);
            this.name_of_seriesCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_of_seriesCB.Name = "name_of_seriesCB";
            this.name_of_seriesCB.Size = new System.Drawing.Size(431, 24);
            this.name_of_seriesCB.TabIndex = 52;
            this.name_of_seriesCB.SelectedIndexChanged += new System.EventHandler(this.name_of_seriesCB_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оновитиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 28);
            // 
            // оновитиToolStripMenuItem
            // 
            this.оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            this.оновитиToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.оновитиToolStripMenuItem.Text = "Оновити";
            this.оновитиToolStripMenuItem.Click += new System.EventHandler(this.оновитиToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 100.369F;
            this.Column1.HeaderText = "Формула";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.631F;
            this.Column2.HeaderText = "Значення";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "name";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.Visible = false;
            // 
            // measure
            // 
            this.measure.HeaderText = "Одиниці вимірювання";
            this.measure.Name = "measure";
            this.measure.ReadOnly = true;
            this.measure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id_of_formula
            // 
            this.id_of_formula.HeaderText = "idf";
            this.id_of_formula.Name = "id_of_formula";
            this.id_of_formula.Visible = false;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.name_of_seriesCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.experts_CB);
            this.Controls.Add(this.chartBox);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.Mass_delete);
            this.Controls.Add(this.Delete_desc);
            this.Controls.Add(this.Panel_redakt);
            this.Controls.Add(this.issueL);
            this.Controls.Add(this.issueTB);
            this.Controls.Add(this.change_desc);
            this.Controls.Add(this.desc_of_seriesTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calc_numbCB);
            this.Controls.Add(this.number_of_calcL);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Result";
            this.Text = "Перегляд результатів";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.chartBox.ResumeLayout(false);
            this.chartBox.PerformLayout();
            this.chartPanel.ResumeLayout(false);
            this.chartPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label number_of_calcL;
        private System.Windows.Forms.ComboBox calc_numbCB;
        private System.Windows.Forms.RichTextBox desc_of_seriesTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button change_desc;
        private System.Windows.Forms.Label issueL;
        private System.Windows.Forms.ComboBox issueTB;
        private System.Windows.Forms.Button Panel_redakt;
        private System.Windows.Forms.Button Delete_desc;
        private System.Windows.Forms.Button Mass_delete;
        private System.Windows.Forms.GroupBox chartBox;
        private System.Windows.Forms.Button newChartButt;
        private System.Windows.Forms.Label chartsLabel;
        private System.Windows.Forms.ComboBox chartsList;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Button chartButt;
        private System.Windows.Forms.Label chartLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox experts_CB;
        private System.Windows.Forms.ComboBox name_of_seriesCB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оновитиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_of_formula;
    }
}