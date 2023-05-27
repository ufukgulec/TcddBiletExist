namespace TcddBiletExist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.PassengerCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindTicket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ToCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FromCity = new System.Windows.Forms.ComboBox();
            this.TicketTable = new System.Windows.Forms.DataGridView();
            this.trenAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagonTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanSayiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standartBiletFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expeditionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Logs = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditionViewBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartureDate
            // 
            this.DepartureDate.Location = new System.Drawing.Point(408, 44);
            this.DepartureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartureDate.MinDate = new System.DateTime(2023, 5, 17, 20, 7, 27, 0);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(393, 23);
            this.DepartureDate.TabIndex = 2;
            this.DepartureDate.Value = new System.DateTime(2023, 5, 17, 20, 7, 27, 0);
            // 
            // PassengerCount
            // 
            this.PassengerCount.Location = new System.Drawing.Point(408, 93);
            this.PassengerCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassengerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PassengerCount.Name = "PassengerCount";
            this.PassengerCount.Size = new System.Drawing.Size(393, 23);
            this.PassengerCount.TabIndex = 3;
            this.PassengerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gidiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yolcu Sayısı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepartureDate);
            this.groupBox1.Controls.Add(this.FindTicket);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ToCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PassengerCount);
            this.groupBox1.Controls.Add(this.FromCity);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1084, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstasyonlar";
            // 
            // FindTicket
            // 
            this.FindTicket.Location = new System.Drawing.Point(807, 43);
            this.FindTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindTicket.Name = "FindTicket";
            this.FindTicket.Size = new System.Drawing.Size(265, 73);
            this.FindTicket.TabIndex = 4;
            this.FindTicket.Text = "Bilet Bul";
            this.FindTicket.UseVisualStyleBackColor = true;
            this.FindTicket.Click += new System.EventHandler(this.FindTicket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nereye :";
            // 
            // ToCity
            // 
            this.ToCity.FormattingEnabled = true;
            this.ToCity.Location = new System.Drawing.Point(9, 92);
            this.ToCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToCity.Name = "ToCity";
            this.ToCity.Size = new System.Drawing.Size(393, 23);
            this.ToCity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nereden :";
            // 
            // FromCity
            // 
            this.FromCity.FormattingEnabled = true;
            this.FromCity.Location = new System.Drawing.Point(9, 43);
            this.FromCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromCity.Name = "FromCity";
            this.FromCity.Size = new System.Drawing.Size(393, 23);
            this.FromCity.TabIndex = 0;
            // 
            // TicketTable
            // 
            this.TicketTable.AllowUserToAddRows = false;
            this.TicketTable.AllowUserToDeleteRows = false;
            this.TicketTable.AutoGenerateColumns = false;
            this.TicketTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TicketTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trenAdiDataGridViewTextBoxColumn,
            this.trenTipiDataGridViewTextBoxColumn,
            this.binisTarihDataGridViewTextBoxColumn,
            this.inisTarihDataGridViewTextBoxColumn,
            this.vagonTipDataGridViewTextBoxColumn,
            this.kalanSayiDataGridViewTextBoxColumn,
            this.standartBiletFiyatiDataGridViewTextBoxColumn});
            this.TicketTable.DataSource = this.expeditionViewBindingSource;
            this.TicketTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketTable.Location = new System.Drawing.Point(3, 19);
            this.TicketTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicketTable.Name = "TicketTable";
            this.TicketTable.ReadOnly = true;
            this.TicketTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TicketTable.RowTemplate.Height = 29;
            this.TicketTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TicketTable.Size = new System.Drawing.Size(1078, 227);
            this.TicketTable.TabIndex = 7;
            // 
            // trenAdiDataGridViewTextBoxColumn
            // 
            this.trenAdiDataGridViewTextBoxColumn.DataPropertyName = "trenAdi";
            this.trenAdiDataGridViewTextBoxColumn.HeaderText = "trenAdi";
            this.trenAdiDataGridViewTextBoxColumn.Name = "trenAdiDataGridViewTextBoxColumn";
            this.trenAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trenTipiDataGridViewTextBoxColumn
            // 
            this.trenTipiDataGridViewTextBoxColumn.DataPropertyName = "trenTipi";
            this.trenTipiDataGridViewTextBoxColumn.HeaderText = "trenTipi";
            this.trenTipiDataGridViewTextBoxColumn.Name = "trenTipiDataGridViewTextBoxColumn";
            this.trenTipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // binisTarihDataGridViewTextBoxColumn
            // 
            this.binisTarihDataGridViewTextBoxColumn.DataPropertyName = "binisTarih";
            this.binisTarihDataGridViewTextBoxColumn.HeaderText = "binisTarih";
            this.binisTarihDataGridViewTextBoxColumn.Name = "binisTarihDataGridViewTextBoxColumn";
            this.binisTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inisTarihDataGridViewTextBoxColumn
            // 
            this.inisTarihDataGridViewTextBoxColumn.DataPropertyName = "inisTarih";
            this.inisTarihDataGridViewTextBoxColumn.HeaderText = "inisTarih";
            this.inisTarihDataGridViewTextBoxColumn.Name = "inisTarihDataGridViewTextBoxColumn";
            this.inisTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vagonTipDataGridViewTextBoxColumn
            // 
            this.vagonTipDataGridViewTextBoxColumn.DataPropertyName = "vagonTip";
            this.vagonTipDataGridViewTextBoxColumn.HeaderText = "vagonTip";
            this.vagonTipDataGridViewTextBoxColumn.Name = "vagonTipDataGridViewTextBoxColumn";
            this.vagonTipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalanSayiDataGridViewTextBoxColumn
            // 
            this.kalanSayiDataGridViewTextBoxColumn.DataPropertyName = "kalanSayi";
            this.kalanSayiDataGridViewTextBoxColumn.HeaderText = "kalanSayi";
            this.kalanSayiDataGridViewTextBoxColumn.Name = "kalanSayiDataGridViewTextBoxColumn";
            this.kalanSayiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // standartBiletFiyatiDataGridViewTextBoxColumn
            // 
            this.standartBiletFiyatiDataGridViewTextBoxColumn.DataPropertyName = "standartBiletFiyati";
            this.standartBiletFiyatiDataGridViewTextBoxColumn.HeaderText = "standartBiletFiyati";
            this.standartBiletFiyatiDataGridViewTextBoxColumn.Name = "standartBiletFiyatiDataGridViewTextBoxColumn";
            this.standartBiletFiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expeditionViewBindingSource
            // 
            this.expeditionViewBindingSource.DataSource = typeof(TcddBiletExist.Models.TicketModels.ExpeditionView);
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.Color.Silver;
            this.Logs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logs.FormattingEnabled = true;
            this.Logs.ItemHeight = 15;
            this.Logs.Location = new System.Drawing.Point(0, 409);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(1084, 124);
            this.Logs.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TicketTable);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 249);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biletler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassengerCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expeditionViewBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker DepartureDate;
        private NumericUpDown PassengerCount;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox ToCity;
        private Label label3;
        private ComboBox FromCity;
        private Button FindTicket;
        private DataGridView TicketTable;
        private ListBox Logs;
        private DataGridViewTextBoxColumn trenAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trenTipiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn binisTarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inisTarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vagonTipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kalanSayiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn standartBiletFiyatiDataGridViewTextBoxColumn;
        private BindingSource expeditionViewBindingSource;
        private GroupBox groupBox3;
    }
}