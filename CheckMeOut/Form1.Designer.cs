namespace CheckMeOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.FilenameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckMatchCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FilePathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md5Box = new System.Windows.Forms.RichTextBox();
            this.sha1Box = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearSHA1 = new System.Windows.Forms.Button();
            this.clearMD5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dragLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.allRdo = new System.Windows.Forms.RadioButton();
            this.validRdo = new System.Windows.Forms.RadioButton();
            this.invalidRdo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilenameCol,
            this.CheckMatchCol,
            this.FilePathCol,
            this.MD5Col,
            this.SHA1Col});
            this.dGrid.Location = new System.Drawing.Point(5, 63);
            this.dGrid.Name = "dGrid";
            this.dGrid.RowTemplate.Height = 28;
            this.dGrid.Size = new System.Drawing.Size(1339, 320);
            this.dGrid.TabIndex = 0;
            // 
            // FilenameCol
            // 
            this.FilenameCol.HeaderText = "Filename";
            this.FilenameCol.Name = "FilenameCol";
            this.FilenameCol.ReadOnly = true;
            this.FilenameCol.Width = 110;
            // 
            // CheckMatchCol
            // 
            this.CheckMatchCol.HeaderText = "Found Checksum";
            this.CheckMatchCol.Name = "CheckMatchCol";
            this.CheckMatchCol.ReadOnly = true;
            this.CheckMatchCol.Width = 126;
            // 
            // FilePathCol
            // 
            this.FilePathCol.HeaderText = "File Path";
            this.FilePathCol.Name = "FilePathCol";
            this.FilePathCol.ReadOnly = true;
            this.FilePathCol.Width = 99;
            // 
            // MD5Col
            // 
            this.MD5Col.HeaderText = "MD5 Hash";
            this.MD5Col.Name = "MD5Col";
            this.MD5Col.ReadOnly = true;
            this.MD5Col.Width = 112;
            // 
            // SHA1Col
            // 
            this.SHA1Col.HeaderText = "SHA1 Hash";
            this.SHA1Col.Name = "SHA1Col";
            this.SHA1Col.ReadOnly = true;
            this.SHA1Col.Width = 120;
            // 
            // md5Box
            // 
            this.md5Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.md5Box.Location = new System.Drawing.Point(35, 68);
            this.md5Box.Name = "md5Box";
            this.md5Box.Size = new System.Drawing.Size(322, 371);
            this.md5Box.TabIndex = 1;
            this.md5Box.Text = "";
            this.toolTip1.SetToolTip(this.md5Box, "Add checksums line by line.");
            this.md5Box.TextChanged += new System.EventHandler(this.md5Box_TextChanged);
            // 
            // sha1Box
            // 
            this.sha1Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sha1Box.Location = new System.Drawing.Point(457, 68);
            this.sha1Box.Name = "sha1Box";
            this.sha1Box.Size = new System.Drawing.Size(408, 371);
            this.sha1Box.TabIndex = 2;
            this.sha1Box.Text = "";
            this.toolTip1.SetToolTip(this.sha1Box, "Add checksums line by line.");
            this.sha1Box.TextChanged += new System.EventHandler(this.sha1Box_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.clearSHA1);
            this.groupBox1.Controls.Add(this.clearMD5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.md5Box);
            this.groupBox1.Controls.Add(this.sha1Box);
            this.groupBox1.Location = new System.Drawing.Point(405, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 476);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verification Checksums";
            // 
            // clearSHA1
            // 
            this.clearSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSHA1.Location = new System.Drawing.Point(871, 68);
            this.clearSHA1.Name = "clearSHA1";
            this.clearSHA1.Size = new System.Drawing.Size(64, 34);
            this.clearSHA1.TabIndex = 7;
            this.clearSHA1.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearSHA1, "Clear all records.");
            this.clearSHA1.UseVisualStyleBackColor = true;
            this.clearSHA1.Click += new System.EventHandler(this.clearSHA1_Click);
            // 
            // clearMD5
            // 
            this.clearMD5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearMD5.Location = new System.Drawing.Point(363, 68);
            this.clearMD5.Name = "clearMD5";
            this.clearMD5.Size = new System.Drawing.Size(66, 34);
            this.clearMD5.TabIndex = 6;
            this.clearMD5.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearMD5, "Clear all records.");
            this.clearMD5.UseVisualStyleBackColor = true;
            this.clearMD5.Click += new System.EventHandler(this.clearMD5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SHA1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MD5";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dragLbl);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 455);
            this.panel1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.panel1, "Drag files to check here to start.");
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragLeave += new System.EventHandler(this.panel1_DragLeave);
            // 
            // dragLbl
            // 
            this.dragLbl.AutoSize = true;
            this.dragLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLbl.Location = new System.Drawing.Point(44, 146);
            this.dragLbl.Name = "dragLbl";
            this.dragLbl.Size = new System.Drawing.Size(298, 46);
            this.dragLbl.TabIndex = 0;
            this.dragLbl.Text = "Drag Files Here";
            this.dragLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(1249, 23);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(88, 34);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearBtn, "Clear all records.");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // allRdo
            // 
            this.allRdo.AutoSize = true;
            this.allRdo.Checked = true;
            this.allRdo.Location = new System.Drawing.Point(42, 27);
            this.allRdo.Name = "allRdo";
            this.allRdo.Size = new System.Drawing.Size(51, 24);
            this.allRdo.TabIndex = 6;
            this.allRdo.TabStop = true;
            this.allRdo.Text = "All";
            this.allRdo.UseVisualStyleBackColor = true;
            this.allRdo.CheckedChanged += new System.EventHandler(this.allRdo_CheckedChanged);
            // 
            // validRdo
            // 
            this.validRdo.AutoSize = true;
            this.validRdo.Location = new System.Drawing.Point(116, 27);
            this.validRdo.Name = "validRdo";
            this.validRdo.Size = new System.Drawing.Size(96, 24);
            this.validRdo.TabIndex = 7;
            this.validRdo.Text = "Matched";
            this.validRdo.UseVisualStyleBackColor = true;
            this.validRdo.CheckedChanged += new System.EventHandler(this.validRdo_CheckedChanged);
            // 
            // invalidRdo
            // 
            this.invalidRdo.AutoSize = true;
            this.invalidRdo.Location = new System.Drawing.Point(221, 27);
            this.invalidRdo.Name = "invalidRdo";
            this.invalidRdo.Size = new System.Drawing.Size(117, 24);
            this.invalidRdo.TabIndex = 8;
            this.invalidRdo.Text = "Unmatched";
            this.invalidRdo.UseVisualStyleBackColor = true;
            this.invalidRdo.CheckedChanged += new System.EventHandler(this.invalidRdo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.invalidRdo);
            this.groupBox2.Controls.Add(this.dGrid);
            this.groupBox2.Controls.Add(this.validRdo);
            this.groupBox2.Controls.Add(this.clearBtn);
            this.groupBox2.Controls.Add(this.allRdo);
            this.groupBox2.Location = new System.Drawing.Point(3, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 383);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(1247, 10);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 892);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1385, 947);
            this.Name = "Form1";
            this.Text = "ChkMeOut Checksum Validator";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.RichTextBox md5Box;
        private System.Windows.Forms.RichTextBox sha1Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilenameCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckMatchCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHA1Col;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dragLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button clearSHA1;
        private System.Windows.Forms.Button clearMD5;
        private System.Windows.Forms.RadioButton allRdo;
        private System.Windows.Forms.RadioButton validRdo;
        private System.Windows.Forms.RadioButton invalidRdo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

