namespace Overpass.NikePlusAPI.ClientDemo
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.userDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iRunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runSummaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRunsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadedAvatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublicDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.powerSongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostRecentRunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(83, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 63);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(94, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // userDetailsBindingSource
            // 
            this.userDetailsBindingSource.DataSource = typeof(Overpass.NikePlusAPI.Model.UserDetails);
            // 
            // iRunBindingSource
            // 
            this.iRunBindingSource.DataSource = typeof(Overpass.NikePlusAPI.Model.IRun);
            this.iRunBindingSource.CurrentChanged += new System.EventHandler(this.iRunBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.runSummaryDataGridViewTextBoxColumn,
            this.totalRunsDataGridViewTextBoxColumn,
            this.screenNameDataGridViewTextBoxColumn,
            this.distanceUnitDataGridViewTextBoxColumn,
            this.dateFormatDataGridViewTextBoxColumn,
            this.startOfWeekDataGridViewTextBoxColumn,
            this.avatarDataGridViewTextBoxColumn,
            this.uploadedAvatarDataGridViewTextBoxColumn,
            this.isPublicDataGridViewCheckBoxColumn,
            this.powerSongDataGridViewTextBoxColumn,
            this.mostRecentRunDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 87);
            this.dataGridView1.TabIndex = 5;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // runSummaryDataGridViewTextBoxColumn
            // 
            this.runSummaryDataGridViewTextBoxColumn.DataPropertyName = "RunSummary";
            this.runSummaryDataGridViewTextBoxColumn.HeaderText = "RunSummary";
            this.runSummaryDataGridViewTextBoxColumn.Name = "runSummaryDataGridViewTextBoxColumn";
            // 
            // totalRunsDataGridViewTextBoxColumn
            // 
            this.totalRunsDataGridViewTextBoxColumn.DataPropertyName = "TotalRuns";
            this.totalRunsDataGridViewTextBoxColumn.HeaderText = "TotalRuns";
            this.totalRunsDataGridViewTextBoxColumn.Name = "totalRunsDataGridViewTextBoxColumn";
            // 
            // screenNameDataGridViewTextBoxColumn
            // 
            this.screenNameDataGridViewTextBoxColumn.DataPropertyName = "ScreenName";
            this.screenNameDataGridViewTextBoxColumn.HeaderText = "ScreenName";
            this.screenNameDataGridViewTextBoxColumn.Name = "screenNameDataGridViewTextBoxColumn";
            // 
            // distanceUnitDataGridViewTextBoxColumn
            // 
            this.distanceUnitDataGridViewTextBoxColumn.DataPropertyName = "distanceUnit";
            this.distanceUnitDataGridViewTextBoxColumn.HeaderText = "distanceUnit";
            this.distanceUnitDataGridViewTextBoxColumn.Name = "distanceUnitDataGridViewTextBoxColumn";
            // 
            // dateFormatDataGridViewTextBoxColumn
            // 
            this.dateFormatDataGridViewTextBoxColumn.DataPropertyName = "DateFormat";
            this.dateFormatDataGridViewTextBoxColumn.HeaderText = "DateFormat";
            this.dateFormatDataGridViewTextBoxColumn.Name = "dateFormatDataGridViewTextBoxColumn";
            // 
            // startOfWeekDataGridViewTextBoxColumn
            // 
            this.startOfWeekDataGridViewTextBoxColumn.DataPropertyName = "StartOfWeek";
            this.startOfWeekDataGridViewTextBoxColumn.HeaderText = "StartOfWeek";
            this.startOfWeekDataGridViewTextBoxColumn.Name = "startOfWeekDataGridViewTextBoxColumn";
            // 
            // avatarDataGridViewTextBoxColumn
            // 
            this.avatarDataGridViewTextBoxColumn.DataPropertyName = "Avatar";
            this.avatarDataGridViewTextBoxColumn.HeaderText = "Avatar";
            this.avatarDataGridViewTextBoxColumn.Name = "avatarDataGridViewTextBoxColumn";
            // 
            // uploadedAvatarDataGridViewTextBoxColumn
            // 
            this.uploadedAvatarDataGridViewTextBoxColumn.DataPropertyName = "UploadedAvatar";
            this.uploadedAvatarDataGridViewTextBoxColumn.HeaderText = "UploadedAvatar";
            this.uploadedAvatarDataGridViewTextBoxColumn.Name = "uploadedAvatarDataGridViewTextBoxColumn";
            // 
            // isPublicDataGridViewCheckBoxColumn
            // 
            this.isPublicDataGridViewCheckBoxColumn.DataPropertyName = "IsPublic";
            this.isPublicDataGridViewCheckBoxColumn.HeaderText = "IsPublic";
            this.isPublicDataGridViewCheckBoxColumn.Name = "isPublicDataGridViewCheckBoxColumn";
            // 
            // powerSongDataGridViewTextBoxColumn
            // 
            this.powerSongDataGridViewTextBoxColumn.DataPropertyName = "PowerSong";
            this.powerSongDataGridViewTextBoxColumn.HeaderText = "PowerSong";
            this.powerSongDataGridViewTextBoxColumn.Name = "powerSongDataGridViewTextBoxColumn";
            // 
            // mostRecentRunDataGridViewTextBoxColumn
            // 
            this.mostRecentRunDataGridViewTextBoxColumn.DataPropertyName = "MostRecentRun";
            this.mostRecentRunDataGridViewTextBoxColumn.HeaderText = "MostRecentRun";
            this.mostRecentRunDataGridViewTextBoxColumn.Name = "mostRecentRunDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView2.DataSource = this.iRunBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(30, 227);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(598, 265);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RunSummary";
            this.dataGridViewTextBoxColumn7.HeaderText = "RunSummary";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PowerSong";
            this.dataGridViewTextBoxColumn15.HeaderText = "PowerSong";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 582);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.BindingSource userDetailsBindingSource;
        private System.Windows.Forms.BindingSource iRunBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runSummaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRunsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFormatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startOfWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadedAvatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPublicDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerSongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mostRecentRunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

