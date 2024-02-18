
namespace File_Renamer
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
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.selectedFileInfoLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.renameFolderChildsBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.allFilesNameTxtBox = new System.Windows.Forms.TextBox();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.selectedFolderInfoLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.renameItBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameInputTxtBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fileFoundLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.replaceTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.containsFileFinderTxtBox = new System.Windows.Forms.TextBox();
            this.selectFolderForMultiReplaceBtn = new System.Windows.Forms.Button();
            this.selectedFolderInfoForMultiReplaceLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFileBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileBtn.Location = new System.Drawing.Point(9, 70);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(170, 32);
            this.selectFileBtn.TabIndex = 4;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // selectedFileInfoLbl
            // 
            this.selectedFileInfoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedFileInfoLbl.AutoSize = true;
            this.selectedFileInfoLbl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFileInfoLbl.Location = new System.Drawing.Point(9, 121);
            this.selectedFileInfoLbl.Name = "selectedFileInfoLbl";
            this.selectedFileInfoLbl.Size = new System.Drawing.Size(190, 24);
            this.selectedFileInfoLbl.TabIndex = 5;
            this.selectedFileInfoLbl.Text = "Selected File: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 347);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(642, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 341);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.renameFolderChildsBtn);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.allFilesNameTxtBox);
            this.panel5.Controls.Add(this.selectFolderBtn);
            this.panel5.Controls.Add(this.selectedFolderInfoLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(634, 341);
            this.panel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Multi File Renamer";
            // 
            // renameFolderChildsBtn
            // 
            this.renameFolderChildsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.renameFolderChildsBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameFolderChildsBtn.Location = new System.Drawing.Point(448, 204);
            this.renameFolderChildsBtn.Name = "renameFolderChildsBtn";
            this.renameFolderChildsBtn.Size = new System.Drawing.Size(170, 32);
            this.renameFolderChildsBtn.TabIndex = 8;
            this.renameFolderChildsBtn.Text = "Rename It";
            this.renameFolderChildsBtn.UseVisualStyleBackColor = true;
            this.renameFolderChildsBtn.Click += new System.EventHandler(this.renameFolderChildsBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Name:";
            // 
            // allFilesNameTxtBox
            // 
            this.allFilesNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allFilesNameTxtBox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.allFilesNameTxtBox.Location = new System.Drawing.Point(134, 166);
            this.allFilesNameTxtBox.Name = "allFilesNameTxtBox";
            this.allFilesNameTxtBox.Size = new System.Drawing.Size(484, 32);
            this.allFilesNameTxtBox.TabIndex = 6;
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFolderBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderBtn.Location = new System.Drawing.Point(10, 70);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(190, 32);
            this.selectFolderBtn.TabIndex = 4;
            this.selectFolderBtn.Text = "Select Folder";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // selectedFolderInfoLbl
            // 
            this.selectedFolderInfoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedFolderInfoLbl.AutoSize = true;
            this.selectedFolderInfoLbl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFolderInfoLbl.Location = new System.Drawing.Point(10, 121);
            this.selectedFolderInfoLbl.Name = "selectedFolderInfoLbl";
            this.selectedFolderInfoLbl.Size = new System.Drawing.Size(202, 24);
            this.selectedFolderInfoLbl.TabIndex = 5;
            this.selectedFolderInfoLbl.Text = "Selected Folder:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.renameItBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fileNameInputTxtBox);
            this.panel1.Controls.Add(this.selectFileBtn);
            this.panel1.Controls.Add(this.selectedFileInfoLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 341);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Single File Renamer";
            // 
            // renameItBtn
            // 
            this.renameItBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.renameItBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameItBtn.Location = new System.Drawing.Point(447, 204);
            this.renameItBtn.Name = "renameItBtn";
            this.renameItBtn.Size = new System.Drawing.Size(170, 32);
            this.renameItBtn.TabIndex = 8;
            this.renameItBtn.Text = "Rename It";
            this.renameItBtn.UseVisualStyleBackColor = true;
            this.renameItBtn.Click += new System.EventHandler(this.renameItBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Name:";
            // 
            // fileNameInputTxtBox
            // 
            this.fileNameInputTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileNameInputTxtBox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.fileNameInputTxtBox.Location = new System.Drawing.Point(133, 166);
            this.fileNameInputTxtBox.Name = "fileNameInputTxtBox";
            this.fileNameInputTxtBox.Size = new System.Drawing.Size(484, 32);
            this.fileNameInputTxtBox.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1279, 334);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.fileFoundLbl);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.replaceTxtBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.replaceBtn);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.containsFileFinderTxtBox);
            this.panel4.Controls.Add(this.selectFolderForMultiReplaceBtn);
            this.panel4.Controls.Add(this.selectedFolderInfoForMultiReplaceLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1279, 334);
            this.panel4.TabIndex = 2;
            // 
            // fileFoundLbl
            // 
            this.fileFoundLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileFoundLbl.AutoSize = true;
            this.fileFoundLbl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileFoundLbl.Location = new System.Drawing.Point(786, 171);
            this.fileFoundLbl.Name = "fileFoundLbl";
            this.fileFoundLbl.Size = new System.Drawing.Size(142, 24);
            this.fileFoundLbl.TabIndex = 12;
            this.fileFoundLbl.Text = "File Found:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Replace Text: ";
            // 
            // replaceTxtBox
            // 
            this.replaceTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.replaceTxtBox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.replaceTxtBox.Location = new System.Drawing.Point(296, 206);
            this.replaceTxtBox.Name = "replaceTxtBox";
            this.replaceTxtBox.Size = new System.Drawing.Size(484, 32);
            this.replaceTxtBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Multi File Renamer (Contains)";
            // 
            // replaceBtn
            // 
            this.replaceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.replaceBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceBtn.Location = new System.Drawing.Point(610, 244);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(170, 32);
            this.replaceBtn.TabIndex = 8;
            this.replaceBtn.Text = "Replace It";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Find File (Contains): ";
            // 
            // containsFileFinderTxtBox
            // 
            this.containsFileFinderTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containsFileFinderTxtBox.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.containsFileFinderTxtBox.Location = new System.Drawing.Point(296, 168);
            this.containsFileFinderTxtBox.Name = "containsFileFinderTxtBox";
            this.containsFileFinderTxtBox.Size = new System.Drawing.Size(484, 32);
            this.containsFileFinderTxtBox.TabIndex = 6;
            this.containsFileFinderTxtBox.TextChanged += new System.EventHandler(this.containsFileFinderTxtBox_TextChanged);
            // 
            // selectFolderForMultiReplaceBtn
            // 
            this.selectFolderForMultiReplaceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectFolderForMultiReplaceBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderForMultiReplaceBtn.Location = new System.Drawing.Point(16, 72);
            this.selectFolderForMultiReplaceBtn.Name = "selectFolderForMultiReplaceBtn";
            this.selectFolderForMultiReplaceBtn.Size = new System.Drawing.Size(190, 32);
            this.selectFolderForMultiReplaceBtn.TabIndex = 4;
            this.selectFolderForMultiReplaceBtn.Text = "Select Folder";
            this.selectFolderForMultiReplaceBtn.UseVisualStyleBackColor = true;
            this.selectFolderForMultiReplaceBtn.Click += new System.EventHandler(this.selectFolderForMultiReplaceBtn_Click);
            // 
            // selectedFolderInfoForMultiReplaceLbl
            // 
            this.selectedFolderInfoForMultiReplaceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedFolderInfoForMultiReplaceLbl.AutoSize = true;
            this.selectedFolderInfoForMultiReplaceLbl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFolderInfoForMultiReplaceLbl.Location = new System.Drawing.Point(16, 123);
            this.selectedFolderInfoForMultiReplaceLbl.Name = "selectedFolderInfoForMultiReplaceLbl";
            this.selectedFolderInfoForMultiReplaceLbl.Size = new System.Drawing.Size(202, 24);
            this.selectedFolderInfoForMultiReplaceLbl.TabIndex = 5;
            this.selectedFolderInfoForMultiReplaceLbl.Text = "Selected Folder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Renamer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label selectedFileInfoLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button renameItBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameInputTxtBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button renameFolderChildsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox allFilesNameTxtBox;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.Label selectedFolderInfoLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label fileFoundLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox replaceTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox containsFileFinderTxtBox;
        private System.Windows.Forms.Button selectFolderForMultiReplaceBtn;
        private System.Windows.Forms.Label selectedFolderInfoForMultiReplaceLbl;
    }
}

