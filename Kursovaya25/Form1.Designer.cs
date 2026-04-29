namespace Kursovaya25
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.flpRow3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.flpRow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSpacer1 = new System.Windows.Forms.Label();
            this.chkStopWords = new System.Windows.Forms.CheckBox();
            this.lblSpacer2 = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.flpRow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTop = new System.Windows.Forms.TabPage();
            this.dgvTop = new System.Windows.Forms.DataGridView();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCloud = new System.Windows.Forms.TabPage();
            this.pnlCloud = new System.Windows.Forms.Panel();
            this.tabHist = new System.Windows.Forms.TabPage();
            this.pnlHist = new System.Windows.Forms.Panel();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.txtStats = new System.Windows.Forms.RichTextBox();
            this.pnlTop.SuspendLayout();
            this.flpRow3.SuspendLayout();
            this.flpRow2.SuspendLayout();
            this.flpRow1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).BeginInit();
            this.tabCloud.SuspendLayout();
            this.tabHist.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.flpRow3);
            this.pnlTop.Controls.Add(this.flpRow2);
            this.pnlTop.Controls.Add(this.flpRow1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 98;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(4);
            this.pnlTop.TabIndex = 0;
            // 
            // flpRow1
            // 
            this.flpRow1.Controls.Add(this.btnOpen);
            this.flpRow1.Controls.Add(this.lblFile);
            this.flpRow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpRow1.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpRow1.Height = 36;
            this.flpRow1.Name = "flpRow1";
            this.flpRow1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.flpRow1.TabIndex = 0;
            this.flpRow1.WrapContents = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(130, 28);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть файл";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = false;
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(500, 28);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Файл не выбран";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpRow2
            // 
            this.flpRow2.Controls.Add(this.btnAnalyze);
            this.flpRow2.Controls.Add(this.btnSave);
            this.flpRow2.Controls.Add(this.lblSpacer1);
            this.flpRow2.Controls.Add(this.chkStopWords);
            this.flpRow2.Controls.Add(this.lblSpacer2);
            this.flpRow2.Controls.Add(this.lblSort);
            this.flpRow2.Controls.Add(this.cmbSort);
            this.flpRow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpRow2.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpRow2.Height = 36;
            this.flpRow2.Name = "flpRow2";
            this.flpRow2.Padding = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.flpRow2.TabIndex = 1;
            this.flpRow2.WrapContents = false;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(130, 28);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Анализировать";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить отчёт";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblSpacer1
            // 
            this.lblSpacer1.Name = "lblSpacer1";
            this.lblSpacer1.Size = new System.Drawing.Size(12, 28);
            this.lblSpacer1.TabIndex = 2;
            this.lblSpacer1.Text = "";
            // 
            // chkStopWords
            // 
            this.chkStopWords.AutoSize = true;
            this.chkStopWords.Checked = true;
            this.chkStopWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStopWords.Name = "chkStopWords";
            this.chkStopWords.TabIndex = 3;
            this.chkStopWords.Text = "Фильтровать стоп-слова";
            this.chkStopWords.UseVisualStyleBackColor = true;
            // 
            // lblSpacer2
            // 
            this.lblSpacer2.Name = "lblSpacer2";
            this.lblSpacer2.Size = new System.Drawing.Size(12, 28);
            this.lblSpacer2.TabIndex = 4;
            this.lblSpacer2.Text = "";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Name = "lblSort";
            this.lblSort.TabIndex = 5;
            this.lblSort.Text = "Сортировка:";
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Items.AddRange(new object[] { "QuickSort", "MergeSort" });
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(120, 23);
            this.cmbSort.TabIndex = 6;
            this.cmbSort.SelectedIndex = 0;
            // 
            // flpRow3
            // 
            this.flpRow3.Controls.Add(this.lblStatus);
            this.flpRow3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpRow3.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpRow3.Height = 24;
            this.flpRow3.Name = "flpRow3";
            this.flpRow3.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.flpRow3.TabIndex = 2;
            this.flpRow3.WrapContents = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(700, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTop);
            this.tabControl.Controls.Add(this.tabCloud);
            this.tabControl.Controls.Add(this.tabHist);
            this.tabControl.Controls.Add(this.tabStats);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabTop
            // 
            this.tabTop.Controls.Add(this.dgvTop);
            this.tabTop.Name = "tabTop";
            this.tabTop.Padding = new System.Windows.Forms.Padding(3);
            this.tabTop.TabIndex = 0;
            this.tabTop.Text = "Топ-50 слов";
            this.tabTop.UseVisualStyleBackColor = true;
            // 
            // dgvTop
            // 
            this.dgvTop.AllowUserToAddRows = false;
            this.dgvTop.AllowUserToDeleteRows = false;
            this.dgvTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop.BackgroundColor = System.Drawing.Color.White;
            this.dgvTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRank,
                this.colWord,
                this.colCount,
                this.colTF,
                this.colBar
            });
            this.dgvTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTop.Name = "dgvTop";
            this.dgvTop.ReadOnly = true;
            this.dgvTop.RowHeadersVisible = false;
            this.dgvTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTop.TabIndex = 0;
            // 
            // colRank
            // 
            this.colRank.FillWeight = 5F;
            this.colRank.HeaderText = "№";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            // 
            // colWord
            // 
            this.colWord.FillWeight = 22F;
            this.colWord.HeaderText = "Слово";
            this.colWord.Name = "colWord";
            this.colWord.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.FillWeight = 10F;
            this.colCount.HeaderText = "Частота";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // colTF
            // 
            this.colTF.FillWeight = 12F;
            this.colTF.HeaderText = "TF (доля)";
            this.colTF.Name = "colTF";
            this.colTF.ReadOnly = true;
            // 
            // colBar
            // 
            this.colBar.FillWeight = 51F;
            this.colBar.HeaderText = "Визуализация";
            this.colBar.Name = "colBar";
            this.colBar.ReadOnly = true;
            // 
            // tabCloud
            // 
            this.tabCloud.Controls.Add(this.pnlCloud);
            this.tabCloud.Name = "tabCloud";
            this.tabCloud.Padding = new System.Windows.Forms.Padding(3);
            this.tabCloud.TabIndex = 1;
            this.tabCloud.Text = "Облако слов";
            this.tabCloud.UseVisualStyleBackColor = true;
            // 
            // pnlCloud
            // 
            this.pnlCloud.AutoScroll = true;
            this.pnlCloud.BackColor = System.Drawing.Color.White;
            this.pnlCloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCloud.Name = "pnlCloud";
            this.pnlCloud.TabIndex = 0;
            this.pnlCloud.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCloud_Paint);
            // 
            // tabHist
            // 
            this.tabHist.Controls.Add(this.pnlHist);
            this.tabHist.Name = "tabHist";
            this.tabHist.Padding = new System.Windows.Forms.Padding(3);
            this.tabHist.TabIndex = 2;
            this.tabHist.Text = "Гистограмма длин";
            this.tabHist.UseVisualStyleBackColor = true;
            // 
            // pnlHist
            // 
            this.pnlHist.BackColor = System.Drawing.Color.White;
            this.pnlHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHist.Name = "pnlHist";
            this.pnlHist.TabIndex = 0;
            this.pnlHist.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHist_Paint);
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.txtStats);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabStats.TabIndex = 3;
            this.tabStats.Text = "Статистика";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // txtStats
            // 
            this.txtStats.BackColor = System.Drawing.Color.White;
            this.txtStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStats.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtStats.Name = "txtStats";
            this.txtStats.ReadOnly = true;
            this.txtStats.TabIndex = 0;
            this.txtStats.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Анализатор частотности слов";
            this.pnlTop.ResumeLayout(false);
            this.flpRow3.ResumeLayout(false);
            this.flpRow2.ResumeLayout(false);
            this.flpRow2.PerformLayout();
            this.flpRow1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).EndInit();
            this.tabCloud.ResumeLayout(false);
            this.tabHist.ResumeLayout(false);
            this.tabStats.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel flpRow1;
        private System.Windows.Forms.FlowLayoutPanel flpRow2;
        private System.Windows.Forms.FlowLayoutPanel flpRow3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSpacer1;
        private System.Windows.Forms.Label lblSpacer2;
        private System.Windows.Forms.CheckBox chkStopWords;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTop;
        private System.Windows.Forms.TabPage tabCloud;
        private System.Windows.Forms.TabPage tabHist;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.DataGridView dgvTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBar;
        private System.Windows.Forms.Panel pnlCloud;
        private System.Windows.Forms.Panel pnlHist;
        private System.Windows.Forms.RichTextBox txtStats;
    }
}
