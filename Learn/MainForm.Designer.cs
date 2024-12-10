namespace Learn
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EditButton = new System.Windows.Forms.Button();
            this.RecordButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.school_26ip213DataSet = new Learn.school_26ip213DataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Learn.school_26ip213DataSetTableAdapters.ServiceTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodBox = new System.Windows.Forms.TextBox();
            this.kodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_26ip213DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.EditButton.Location = new System.Drawing.Point(313, 12);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 30);
            this.EditButton.TabIndex = 0;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.RecordButton.FlatAppearance.BorderSize = 0;
            this.RecordButton.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.RecordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.RecordButton.Location = new System.Drawing.Point(421, 12);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(100, 30);
            this.RecordButton.TabIndex = 1;
            this.RecordButton.Text = "Запись клиента";
            this.RecordButton.UseVisualStyleBackColor = false;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.ViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ViewButton.Location = new System.Drawing.Point(529, 12);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(100, 30);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "Просмотр";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Learn.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridService
            // 
            this.dataGridService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridService.AutoGenerateColumns = false;
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.durationInSecondsDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn});
            this.dataGridService.DataSource = this.serviceBindingSource;
            this.dataGridService.Location = new System.Drawing.Point(313, 49);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.Size = new System.Drawing.Size(745, 429);
            this.dataGridService.TabIndex = 4;
            // 
            // school_26ip213DataSet
            // 
            this.school_26ip213DataSet.DataSetName = "school_26ip213DataSet";
            this.school_26ip213DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.school_26ip213DataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // durationInSecondsDataGridViewTextBoxColumn
            // 
            this.durationInSecondsDataGridViewTextBoxColumn.DataPropertyName = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.HeaderText = "DurationInSeconds";
            this.durationInSecondsDataGridViewTextBoxColumn.Name = "durationInSecondsDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // mainImagePathDataGridViewTextBoxColumn
            // 
            this.mainImagePathDataGridViewTextBoxColumn.DataPropertyName = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.HeaderText = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.Name = "mainImagePathDataGridViewTextBoxColumn";
            // 
            // kodBox
            // 
            this.kodBox.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.kodBox.Location = new System.Drawing.Point(819, 17);
            this.kodBox.Name = "kodBox";
            this.kodBox.Size = new System.Drawing.Size(131, 23);
            this.kodBox.TabIndex = 5;
            this.kodBox.TextChanged += new System.EventHandler(this.kodBox_TextChanged);
            // 
            // kodButton
            // 
            this.kodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.kodButton.FlatAppearance.BorderSize = 0;
            this.kodButton.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.kodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.kodButton.Location = new System.Drawing.Point(957, 12);
            this.kodButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kodButton.Name = "kodButton";
            this.kodButton.Size = new System.Drawing.Size(100, 30);
            this.kodButton.TabIndex = 6;
            this.kodButton.Text = "Ввод";
            this.kodButton.UseVisualStyleBackColor = false;
            this.kodButton.Click += new System.EventHandler(this.kodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.label1.Location = new System.Drawing.Point(636, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите код администратора";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.label2.Location = new System.Drawing.Point(871, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фильтр";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filterBox
            // 
            this.filterBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "от 0 до 5%",
            "от 5% до 15%",
            "от 15% до 30%",
            "от 30% до 70%",
            "от 70% до 100%"});
            this.filterBox.Location = new System.Drawing.Point(927, 484);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(131, 23);
            this.filterBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.label3.Location = new System.Drawing.Point(315, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBox.Font = new System.Drawing.Font("Comic Sans MS", 8.5F);
            this.searchBox.Location = new System.Drawing.Point(368, 484);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(300, 23);
            this.searchBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodButton);
            this.Controls.Add(this.kodBox);
            this.Controls.Add(this.dataGridService);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.EditButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1086, 558);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_26ip213DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridService;
        private school_26ip213DataSet school_26ip213DataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private school_26ip213DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox kodBox;
        private System.Windows.Forms.Button kodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
    }
}

