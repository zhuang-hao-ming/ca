﻿namespace Ca.CaDialog
{
    partial class LgCaSetUpForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonSetProperties = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNumOfSample = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTimeOfSimulate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxSizeOfNeighbour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpenEnd = new System.Windows.Forms.Button();
            this.buttonOpenStart = new System.Windows.Forms.Button();
            this.textBoxEndPath = new System.Windows.Forms.TextBox();
            this.textBoxStartPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveDrive = new System.Windows.Forms.Button();
            this.buttonAddDrive = new System.Windows.Forms.Button();
            this.listBoxDriveLayerNames = new System.Windows.Forms.ListBox();
            this.textBoxEndCityCnt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSet);
            this.groupBox4.Location = new System.Drawing.Point(26, 442);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 47);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "土地利用类型对应关系";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(21, 18);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 0;
            this.buttonSet.Text = "土地利用类型设置";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonSetProperties
            // 
            this.buttonSetProperties.Location = new System.Drawing.Point(333, 495);
            this.buttonSetProperties.Name = "buttonSetProperties";
            this.buttonSetProperties.Size = new System.Drawing.Size(75, 23);
            this.buttonSetProperties.TabIndex = 13;
            this.buttonSetProperties.Text = "确定";
            this.buttonSetProperties.UseVisualStyleBackColor = true;
            this.buttonSetProperties.Click += new System.EventHandler(this.buttonSetProperties_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxEndCityCnt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxNumOfSample);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxThreshold);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxTimeOfSimulate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxAlpha);
            this.groupBox3.Controls.Add(this.textBoxSizeOfNeighbour);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(26, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 133);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数";
            // 
            // textBoxNumOfSample
            // 
            this.textBoxNumOfSample.Location = new System.Drawing.Point(280, 65);
            this.textBoxNumOfSample.Name = "textBoxNumOfSample";
            this.textBoxNumOfSample.Size = new System.Drawing.Size(81, 21);
            this.textBoxNumOfSample.TabIndex = 7;
            this.textBoxNumOfSample.Text = "3000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "采样数目";
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(104, 59);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(77, 21);
            this.textBoxThreshold.TabIndex = 5;
            this.textBoxThreshold.Text = "0.8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "转换阈值";
            // 
            // textBoxTimeOfSimulate
            // 
            this.textBoxTimeOfSimulate.Location = new System.Drawing.Point(280, 23);
            this.textBoxTimeOfSimulate.Name = "textBoxTimeOfSimulate";
            this.textBoxTimeOfSimulate.Size = new System.Drawing.Size(81, 21);
            this.textBoxTimeOfSimulate.TabIndex = 3;
            this.textBoxTimeOfSimulate.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "模拟次数";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(104, 100);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(77, 21);
            this.textBoxAlpha.TabIndex = 1;
            this.textBoxAlpha.Text = "1";
            // 
            // textBoxSizeOfNeighbour
            // 
            this.textBoxSizeOfNeighbour.Location = new System.Drawing.Point(104, 23);
            this.textBoxSizeOfNeighbour.Name = "textBoxSizeOfNeighbour";
            this.textBoxSizeOfNeighbour.Size = new System.Drawing.Size(77, 21);
            this.textBoxSizeOfNeighbour.TabIndex = 1;
            this.textBoxSizeOfNeighbour.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "随机因子";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "训练次数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "邻域大小";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpenEnd);
            this.groupBox2.Controls.Add(this.buttonOpenStart);
            this.groupBox2.Controls.Add(this.textBoxEndPath);
            this.groupBox2.Controls.Add(this.textBoxStartPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 114);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "起始和终止年份数据";
            // 
            // buttonOpenEnd
            // 
            this.buttonOpenEnd.Location = new System.Drawing.Point(306, 62);
            this.buttonOpenEnd.Name = "buttonOpenEnd";
            this.buttonOpenEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenEnd.TabIndex = 2;
            this.buttonOpenEnd.Text = "打开";
            this.buttonOpenEnd.UseVisualStyleBackColor = true;
            this.buttonOpenEnd.Click += new System.EventHandler(this.buttonOpenEnd_Click);
            // 
            // buttonOpenStart
            // 
            this.buttonOpenStart.Location = new System.Drawing.Point(306, 29);
            this.buttonOpenStart.Name = "buttonOpenStart";
            this.buttonOpenStart.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenStart.TabIndex = 2;
            this.buttonOpenStart.Text = "打开";
            this.buttonOpenStart.UseVisualStyleBackColor = true;
            this.buttonOpenStart.Click += new System.EventHandler(this.buttonOpenStart_Click);
            // 
            // textBoxEndPath
            // 
            this.textBoxEndPath.Location = new System.Drawing.Point(126, 62);
            this.textBoxEndPath.Name = "textBoxEndPath";
            this.textBoxEndPath.Size = new System.Drawing.Size(174, 21);
            this.textBoxEndPath.TabIndex = 1;
            // 
            // textBoxStartPath
            // 
            this.textBoxStartPath.Location = new System.Drawing.Point(126, 29);
            this.textBoxStartPath.Name = "textBoxStartPath";
            this.textBoxStartPath.Size = new System.Drawing.Size(174, 21);
            this.textBoxStartPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "起始年份影像";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "终止年份影像";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRemoveDrive);
            this.groupBox1.Controls.Add(this.buttonAddDrive);
            this.groupBox1.Controls.Add(this.listBoxDriveLayerNames);
            this.groupBox1.Location = new System.Drawing.Point(26, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "驱动数据";
            // 
            // buttonRemoveDrive
            // 
            this.buttonRemoveDrive.Location = new System.Drawing.Point(22, 97);
            this.buttonRemoveDrive.Name = "buttonRemoveDrive";
            this.buttonRemoveDrive.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDrive.TabIndex = 2;
            this.buttonRemoveDrive.Text = "移除";
            this.buttonRemoveDrive.UseVisualStyleBackColor = true;
            this.buttonRemoveDrive.Click += new System.EventHandler(this.buttonRemoveDrive_Click);
            // 
            // buttonAddDrive
            // 
            this.buttonAddDrive.Location = new System.Drawing.Point(22, 46);
            this.buttonAddDrive.Name = "buttonAddDrive";
            this.buttonAddDrive.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDrive.TabIndex = 1;
            this.buttonAddDrive.Text = "添加";
            this.buttonAddDrive.UseVisualStyleBackColor = true;
            this.buttonAddDrive.Click += new System.EventHandler(this.buttonAddDrive_Click);
            // 
            // listBoxDriveLayerNames
            // 
            this.listBoxDriveLayerNames.FormattingEnabled = true;
            this.listBoxDriveLayerNames.ItemHeight = 12;
            this.listBoxDriveLayerNames.Location = new System.Drawing.Point(225, 20);
            this.listBoxDriveLayerNames.Name = "listBoxDriveLayerNames";
            this.listBoxDriveLayerNames.Size = new System.Drawing.Size(136, 124);
            this.listBoxDriveLayerNames.TabIndex = 0;
            // 
            // textBoxEndCityCnt
            // 
            this.textBoxEndCityCnt.Location = new System.Drawing.Point(279, 100);
            this.textBoxEndCityCnt.Name = "textBoxEndCityCnt";
            this.textBoxEndCityCnt.Size = new System.Drawing.Size(82, 21);
            this.textBoxEndCityCnt.TabIndex = 9;
            this.textBoxEndCityCnt.Text = "10000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "目标城市数目";
            // 
            // LgCaSetUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 546);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonSetProperties);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LgCaSetUpForm";
            this.Text = "LgCaSetUpForm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonSetProperties;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxTimeOfSimulate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.TextBox textBoxSizeOfNeighbour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOpenEnd;
        private System.Windows.Forms.Button buttonOpenStart;
        private System.Windows.Forms.TextBox textBoxEndPath;
        private System.Windows.Forms.TextBox textBoxStartPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemoveDrive;
        private System.Windows.Forms.Button buttonAddDrive;
        private System.Windows.Forms.ListBox listBoxDriveLayerNames;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumOfSample;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEndCityCnt;
        private System.Windows.Forms.Label label9;
    }
}