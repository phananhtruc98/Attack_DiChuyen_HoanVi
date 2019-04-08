namespace Attack_ATMB
{
    partial class HoanVi
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbMaHoa = new System.Windows.Forms.RadioButton();
            this.rdbGiaiMa = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lbK = new System.Windows.Forms.Label();
            this.lbZ = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.btnPickFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbXuat = new System.Windows.Forms.RadioButton();
            this.clbTypeOutput = new System.Windows.Forms.CheckedListBox();
            this.btnFileExecute = new System.Windows.Forms.Button();
            this.rdbNhapChallenge = new System.Windows.Forms.RadioButton();
            this.rdbEnc = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rdbInput = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBefore, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAfter, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPickFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1307, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rdbMaHoa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdbGiaiMa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExecute, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbK, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbZ, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtK, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtZ, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(438, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 187);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // rdbMaHoa
            // 
            this.rdbMaHoa.AutoSize = true;
            this.rdbMaHoa.Checked = true;
            this.rdbMaHoa.Location = new System.Drawing.Point(3, 3);
            this.rdbMaHoa.Name = "rdbMaHoa";
            this.rdbMaHoa.Size = new System.Drawing.Size(103, 29);
            this.rdbMaHoa.TabIndex = 0;
            this.rdbMaHoa.TabStop = true;
            this.rdbMaHoa.Text = "Mã hóa";
            this.rdbMaHoa.UseVisualStyleBackColor = true;
            // 
            // rdbGiaiMa
            // 
            this.rdbGiaiMa.AutoSize = true;
            this.rdbGiaiMa.Location = new System.Drawing.Point(217, 3);
            this.rdbGiaiMa.Name = "rdbGiaiMa";
            this.rdbGiaiMa.Size = new System.Drawing.Size(103, 29);
            this.rdbGiaiMa.TabIndex = 1;
            this.rdbGiaiMa.Text = "Giải mã";
            this.rdbGiaiMa.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnExecute, 2);
            this.btnExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecute.Location = new System.Drawing.Point(3, 108);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(423, 76);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Thực thi";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Location = new System.Drawing.Point(3, 70);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(26, 25);
            this.lbK.TabIndex = 3;
            this.lbK.Text = "K";
            // 
            // lbZ
            // 
            this.lbZ.AutoSize = true;
            this.lbZ.Location = new System.Drawing.Point(3, 35);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(24, 25);
            this.lbZ.TabIndex = 2;
            this.lbZ.Text = "Z";
            // 
            // txtK
            // 
            this.txtK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtK.Location = new System.Drawing.Point(217, 73);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(209, 29);
            this.txtK.TabIndex = 4;
            // 
            // txtZ
            // 
            this.txtZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZ.Location = new System.Drawing.Point(217, 38);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(209, 29);
            this.txtZ.TabIndex = 5;
            // 
            // txtBefore
            // 
            this.txtBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBefore.Location = new System.Drawing.Point(3, 3);
            this.txtBefore.Multiline = true;
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBefore.Size = new System.Drawing.Size(429, 187);
            this.txtBefore.TabIndex = 0;
            // 
            // txtAfter
            // 
            this.txtAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAfter.Location = new System.Drawing.Point(873, 3);
            this.txtAfter.Multiline = true;
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAfter.Size = new System.Drawing.Size(431, 187);
            this.txtAfter.TabIndex = 1;
            // 
            // btnPickFile
            // 
            this.btnPickFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickFile.Location = new System.Drawing.Point(3, 196);
            this.btnPickFile.Name = "btnPickFile";
            this.btnPickFile.Size = new System.Drawing.Size(429, 187);
            this.btnPickFile.TabIndex = 2;
            this.btnPickFile.Text = "Chọn tệp";
            this.btnPickFile.UseVisualStyleBackColor = true;
            this.btnPickFile.Click += new System.EventHandler(this.btnPickFile_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rdbXuat, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.clbTypeOutput, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnFileExecute, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.rdbNhapChallenge, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rdbEnc, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.rdbInput, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(438, 196);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(429, 187);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // rdbXuat
            // 
            this.rdbXuat.AutoSize = true;
            this.rdbXuat.Location = new System.Drawing.Point(217, 3);
            this.rdbXuat.Name = "rdbXuat";
            this.rdbXuat.Size = new System.Drawing.Size(107, 29);
            this.rdbXuat.TabIndex = 1;
            this.rdbXuat.Text = "Xuất file";
            this.rdbXuat.UseVisualStyleBackColor = true;
            // 
            // clbTypeOutput
            // 
            this.clbTypeOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTypeOutput.FormattingEnabled = true;
            this.clbTypeOutput.Items.AddRange(new object[] {
            "Ouput",
            "Challenge"});
            this.clbTypeOutput.Location = new System.Drawing.Point(217, 73);
            this.clbTypeOutput.Name = "clbTypeOutput";
            this.clbTypeOutput.Size = new System.Drawing.Size(209, 60);
            this.clbTypeOutput.TabIndex = 2;
            // 
            // btnFileExecute
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.btnFileExecute, 2);
            this.btnFileExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFileExecute.Location = new System.Drawing.Point(3, 139);
            this.btnFileExecute.Name = "btnFileExecute";
            this.btnFileExecute.Size = new System.Drawing.Size(423, 45);
            this.btnFileExecute.TabIndex = 3;
            this.btnFileExecute.Text = "Thực thi";
            this.btnFileExecute.UseVisualStyleBackColor = true;
            this.btnFileExecute.Click += new System.EventHandler(this.btnFileExecute_Click);
            // 
            // rdbNhapChallenge
            // 
            this.rdbNhapChallenge.AutoSize = true;
            this.rdbNhapChallenge.Location = new System.Drawing.Point(3, 73);
            this.rdbNhapChallenge.Name = "rdbNhapChallenge";
            this.rdbNhapChallenge.Size = new System.Drawing.Size(202, 29);
            this.rdbNhapChallenge.TabIndex = 4;
            this.rdbNhapChallenge.Text = "Nhập file challenge";
            this.rdbNhapChallenge.UseVisualStyleBackColor = true;
            // 
            // rdbEnc
            // 
            this.rdbEnc.AutoSize = true;
            this.rdbEnc.Location = new System.Drawing.Point(3, 38);
            this.rdbEnc.Name = "rdbEnc";
            this.rdbEnc.Size = new System.Drawing.Size(203, 29);
            this.rdbEnc.TabIndex = 0;
            this.rdbEnc.Text = "Nhập file bị mã hóa";
            this.rdbEnc.UseVisualStyleBackColor = true;
            this.rdbEnc.CheckedChanged += new System.EventHandler(this.rdbNhap_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.InitialDirectory = ".";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Tìm kiếm tập tin";
            // 
            // rdbInput
            // 
            this.rdbInput.AutoSize = true;
            this.rdbInput.Checked = true;
            this.rdbInput.Location = new System.Drawing.Point(3, 3);
            this.rdbInput.Name = "rdbInput";
            this.rdbInput.Size = new System.Drawing.Size(160, 29);
            this.rdbInput.TabIndex = 5;
            this.rdbInput.TabStop = true;
            this.rdbInput.Text = "Nhập file input";
            this.rdbInput.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(873, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(431, 187);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // HoanVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HoanVi";
            this.Text = "HoanVi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Button btnPickFile;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rdbMaHoa;
        private System.Windows.Forms.RadioButton rdbGiaiMa;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.Label lbZ;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rdbEnc;
        private System.Windows.Forms.RadioButton rdbXuat;
        private System.Windows.Forms.CheckedListBox clbTypeOutput;
        private System.Windows.Forms.Button btnFileExecute;
        private System.Windows.Forms.RadioButton rdbNhapChallenge;
        private System.Windows.Forms.RadioButton rdbInput;
        private System.Windows.Forms.Button btnClear;
    }
}