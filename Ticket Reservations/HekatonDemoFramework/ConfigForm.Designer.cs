﻿namespace DemoWorkload
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.LabelReadsPerWrite = new System.Windows.Forms.Label();
            this.ReadsPerWrite = new System.Windows.Forms.NumericUpDown();
            this.LabelRowsPerTran = new System.Windows.Forms.Label();
            this.RowCount = new System.Windows.Forms.NumericUpDown();
            this.LabelRPT = new System.Windows.Forms.Label();
            this.RequestCount = new System.Windows.Forms.NumericUpDown();
            this.lblInstance = new System.Windows.Forms.Label();
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxTPS = new System.Windows.Forms.TextBox();
            this.lblRunningThread = new System.Windows.Forms.Label();
            this.txtMaxLatch = new System.Windows.Forms.TextBox();
            this.lblServerTran = new System.Windows.Forms.Label();
            this.TransactionCount = new System.Windows.Forms.NumericUpDown();
            this.lblThreadCnt = new System.Windows.Forms.Label();
            this.ThreadCount = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReadsPerWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadCount)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelReadsPerWrite
            // 
            this.LabelReadsPerWrite.AutoSize = true;
            this.LabelReadsPerWrite.BackColor = System.Drawing.Color.Transparent;
            this.LabelReadsPerWrite.Location = new System.Drawing.Point(19, 92);
            this.LabelReadsPerWrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelReadsPerWrite.Name = "LabelReadsPerWrite";
            this.LabelReadsPerWrite.Size = new System.Drawing.Size(111, 17);
            this.LabelReadsPerWrite.TabIndex = 48;
            this.LabelReadsPerWrite.Text = "Reads per Write";
            // 
            // ReadsPerWrite
            // 
            this.ReadsPerWrite.Location = new System.Drawing.Point(203, 90);
            this.ReadsPerWrite.Margin = new System.Windows.Forms.Padding(4);
            this.ReadsPerWrite.Name = "ReadsPerWrite";
            this.ReadsPerWrite.Size = new System.Drawing.Size(132, 22);
            this.ReadsPerWrite.TabIndex = 47;
            this.ReadsPerWrite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelRowsPerTran
            // 
            this.LabelRowsPerTran.AutoSize = true;
            this.LabelRowsPerTran.BackColor = System.Drawing.Color.Transparent;
            this.LabelRowsPerTran.Location = new System.Drawing.Point(19, 220);
            this.LabelRowsPerTran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRowsPerTran.Name = "LabelRowsPerTran";
            this.LabelRowsPerTran.Size = new System.Drawing.Size(146, 17);
            this.LabelRowsPerTran.TabIndex = 46;
            this.LabelRowsPerTran.Text = "Rows per Transaction";
            // 
            // RowCount
            // 
            this.RowCount.Location = new System.Drawing.Point(201, 218);
            this.RowCount.Margin = new System.Windows.Forms.Padding(4);
            this.RowCount.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.RowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowCount.Name = "RowCount";
            this.RowCount.Size = new System.Drawing.Size(133, 22);
            this.RowCount.TabIndex = 45;
            this.RowCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LabelRPT
            // 
            this.LabelRPT.AutoSize = true;
            this.LabelRPT.BackColor = System.Drawing.Color.Transparent;
            this.LabelRPT.Location = new System.Drawing.Point(19, 124);
            this.LabelRPT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRPT.Name = "LabelRPT";
            this.LabelRPT.Size = new System.Drawing.Size(143, 17);
            this.LabelRPT.TabIndex = 44;
            this.LabelRPT.Text = "Requests per Thread";
            // 
            // RequestCount
            // 
            this.RequestCount.Location = new System.Drawing.Point(203, 122);
            this.RequestCount.Margin = new System.Windows.Forms.Padding(4);
            this.RequestCount.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.RequestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RequestCount.Name = "RequestCount";
            this.RequestCount.Size = new System.Drawing.Size(132, 22);
            this.RequestCount.TabIndex = 43;
            this.RequestCount.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // lblInstance
            // 
            this.lblInstance.AutoSize = true;
            this.lblInstance.BackColor = System.Drawing.Color.Transparent;
            this.lblInstance.Location = new System.Drawing.Point(19, 267);
            this.lblInstance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(120, 17);
            this.lblInstance.TabIndex = 42;
            this.lblInstance.Text = "Connection String";
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(22, 299);
            this.tbConnectionString.Margin = new System.Windows.Forms.Padding(4);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(360, 22);
            this.tbConnectionString.TabIndex = 40;
            this.tbConnectionString.TextChanged += new System.EventHandler(this.tbInstance_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Max TPS (thousands)";
            // 
            // txtMaxTPS
            // 
            this.txtMaxTPS.Location = new System.Drawing.Point(203, 27);
            this.txtMaxTPS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxTPS.Name = "txtMaxTPS";
            this.txtMaxTPS.Size = new System.Drawing.Size(131, 22);
            this.txtMaxTPS.TabIndex = 37;
            this.txtMaxTPS.TabStop = false;
            this.txtMaxTPS.Text = "70";
            // 
            // lblRunningThread
            // 
            this.lblRunningThread.AutoSize = true;
            this.lblRunningThread.BackColor = System.Drawing.Color.Transparent;
            this.lblRunningThread.Location = new System.Drawing.Point(19, 62);
            this.lblRunningThread.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunningThread.Name = "lblRunningThread";
            this.lblRunningThread.Size = new System.Drawing.Size(107, 17);
            this.lblRunningThread.TabIndex = 36;
            this.lblRunningThread.Text = "Max Latch Time";
            // 
            // txtMaxLatch
            // 
            this.txtMaxLatch.Location = new System.Drawing.Point(203, 58);
            this.txtMaxLatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxLatch.Name = "txtMaxLatch";
            this.txtMaxLatch.Size = new System.Drawing.Size(131, 22);
            this.txtMaxLatch.TabIndex = 35;
            this.txtMaxLatch.TabStop = false;
            this.txtMaxLatch.Text = "10000";
            // 
            // lblServerTran
            // 
            this.lblServerTran.AutoSize = true;
            this.lblServerTran.BackColor = System.Drawing.Color.Transparent;
            this.lblServerTran.Location = new System.Drawing.Point(19, 188);
            this.lblServerTran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerTran.Name = "lblServerTran";
            this.lblServerTran.Size = new System.Drawing.Size(136, 17);
            this.lblServerTran.TabIndex = 34;
            this.lblServerTran.Text = "Server Transactions";
            // 
            // TransactionCount
            // 
            this.TransactionCount.Location = new System.Drawing.Point(203, 186);
            this.TransactionCount.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionCount.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.TransactionCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TransactionCount.Name = "TransactionCount";
            this.TransactionCount.Size = new System.Drawing.Size(132, 22);
            this.TransactionCount.TabIndex = 29;
            this.TransactionCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThreadCnt
            // 
            this.lblThreadCnt.AutoSize = true;
            this.lblThreadCnt.BackColor = System.Drawing.Color.Transparent;
            this.lblThreadCnt.Location = new System.Drawing.Point(19, 156);
            this.lblThreadCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThreadCnt.Name = "lblThreadCnt";
            this.lblThreadCnt.Size = new System.Drawing.Size(61, 17);
            this.lblThreadCnt.TabIndex = 31;
            this.lblThreadCnt.Text = "Threads";
            // 
            // ThreadCount
            // 
            this.ThreadCount.Location = new System.Drawing.Point(203, 154);
            this.ThreadCount.Margin = new System.Windows.Forms.Padding(4);
            this.ThreadCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadCount.Name = "ThreadCount";
            this.ThreadCount.Size = new System.Drawing.Size(132, 22);
            this.ThreadCount.TabIndex = 28;
            this.ThreadCount.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 361);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 28);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save Configuration Values";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 409);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.LabelReadsPerWrite);
            this.Controls.Add(this.ReadsPerWrite);
            this.Controls.Add(this.LabelRowsPerTran);
            this.Controls.Add(this.RowCount);
            this.Controls.Add(this.LabelRPT);
            this.Controls.Add(this.RequestCount);
            this.Controls.Add(this.lblInstance);
            this.Controls.Add(this.tbConnectionString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxTPS);
            this.Controls.Add(this.lblRunningThread);
            this.Controls.Add(this.txtMaxLatch);
            this.Controls.Add(this.lblServerTran);
            this.Controls.Add(this.TransactionCount);
            this.Controls.Add(this.lblThreadCnt);
            this.Controls.Add(this.ThreadCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReadsPerWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelReadsPerWrite;
        private System.Windows.Forms.NumericUpDown ReadsPerWrite;
        private System.Windows.Forms.Label LabelRowsPerTran;
        private System.Windows.Forms.NumericUpDown RowCount;
        private System.Windows.Forms.Label LabelRPT;
        private System.Windows.Forms.NumericUpDown RequestCount;
        private System.Windows.Forms.Label lblInstance;
        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxTPS;
        private System.Windows.Forms.Label lblRunningThread;
        private System.Windows.Forms.TextBox txtMaxLatch;
        private System.Windows.Forms.Label lblServerTran;
        private System.Windows.Forms.NumericUpDown TransactionCount;
        private System.Windows.Forms.Label lblThreadCnt;
        private System.Windows.Forms.NumericUpDown ThreadCount;
        private System.Windows.Forms.Button btnSave;
    }
}