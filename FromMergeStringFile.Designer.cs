namespace MergeFilesTool
{
    partial class FromMergeStringFile
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
            txtPath = new TextBox();
            txtNewFileName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnShowStringMerge = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            rtbPowerShellCommand = new RichTextBox();
            label5 = new Label();
            pbResult = new PictureBox();
            label6 = new Label();
            btnResult = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbResult).BeginInit();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 122);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(853, 26);
            txtPath.TabIndex = 0;
            // 
            // txtNewFileName
            // 
            txtNewFileName.Location = new Point(221, 190);
            txtNewFileName.Name = "txtNewFileName";
            txtNewFileName.Size = new Size(644, 26);
            txtNewFileName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(373, 13);
            label1.Name = "label1";
            label1.Size = new Size(381, 32);
            label1.TabIndex = 1;
            label1.Text = "MergeFilesStringSQL PowerShell";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 102);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 1;
            label2.Text = "Insert Path Folder SQL";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 168);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 1;
            label3.Text = "NewFileNameSQL";
            // 
            // btnShowStringMerge
            // 
            btnShowStringMerge.Location = new Point(574, 714);
            btnShowStringMerge.Name = "btnShowStringMerge";
            btnShowStringMerge.Size = new Size(291, 38);
            btnShowStringMerge.TabIndex = 2;
            btnShowStringMerge.Text = "Show String SQL Merge";
            btnShowStringMerge.UseVisualStyleBackColor = true;
            btnShowStringMerge.Click += btnShowStringMerge_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(790, 48);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 51);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.path;
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(772, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 26);
            label4.Name = "label4";
            label4.Size = new Size(288, 19);
            label4.TabIndex = 1;
            label4.Text = "CopyPathSQLFolder to Insert path folder SQL";
            label4.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.newFileName;
            pictureBox2.Location = new Point(15, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 169);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // rtbPowerShellCommand
            // 
            rtbPowerShellCommand.Location = new Point(221, 239);
            rtbPowerShellCommand.Name = "rtbPowerShellCommand";
            rtbPowerShellCommand.Size = new Size(644, 103);
            rtbPowerShellCommand.TabIndex = 5;
            rtbPowerShellCommand.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 219);
            label5.Name = "label5";
            label5.Size = new Size(268, 19);
            label5.TabIndex = 1;
            label5.Text = "Copy To PowerShell Right Click Press Enter";
            // 
            // pbResult
            // 
            pbResult.Image = Properties.Resources.result;
            pbResult.Location = new Point(12, 379);
            pbResult.Name = "pbResult";
            pbResult.Size = new Size(853, 329);
            pbResult.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResult.TabIndex = 6;
            pbResult.TabStop = false;
            pbResult.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 357);
            label6.Name = "label6";
            label6.Size = new Size(195, 19);
            label6.TabIndex = 1;
            label6.Text = "Excecute PowerShell command";
            label6.Click += label2_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(14, 714);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(289, 35);
            btnResult.TabIndex = 7;
            btnResult.Text = "HideResult";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Visible = false;
            btnResult.Click += btnResult_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 151);
            label8.Name = "label8";
            label8.Size = new Size(119, 19);
            label8.TabIndex = 1;
            label8.Text = "FileName example";
            label8.Click += label2_Click;
            // 
            // FromMergeStringFile
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 761);
            ControlBox = false;
            Controls.Add(btnResult);
            Controls.Add(pbResult);
            Controls.Add(rtbPowerShellCommand);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnShowStringMerge);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewFileName);
            Controls.Add(txtPath);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FromMergeStringFile";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hỗ trợ chuỗi string powershell Gộp tất cả các file sql lại thành một file duy nhất";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPath;
        private TextBox txtNewFileName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnShowStringMerge;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private RichTextBox rtbPowerShellCommand;
        private Label label5;
        private PictureBox pbResult;
        private Label label6;
        private Button btnResult;
        private Label label8;
    }
}
