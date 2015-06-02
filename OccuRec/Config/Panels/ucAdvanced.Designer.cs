﻿namespace OccuRec.Config.Panels
{
	partial class ucAdvanced
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlPreserveOSDArea = new System.Windows.Forms.Panel();
            this.nudPreserveVTIBottomRow = new System.Windows.Forms.NumericUpDown();
            this.nudPreserveVTITopRow = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLiveOCR = new System.Windows.Forms.CheckBox();
            this.nudNTPDebugValue2 = new System.Windows.Forms.NumericUpDown();
            this.nudNTPDebugValue1 = new System.Windows.Forms.NumericUpDown();
            this.cbDebugIntegration = new System.Windows.Forms.CheckBox();
            this.cbxStatusSectionOnly = new System.Windows.Forms.CheckBox();
            this.cbxUserPreserveOSDLines = new System.Windows.Forms.CheckBox();
            this.pnlNTPDebug = new System.Windows.Forms.Panel();
            this.cbxGraphDebugMode = new System.Windows.Forms.CheckBox();
            this.cbxImageLayoutMode = new System.Windows.Forms.ComboBox();
            this.cbxCustomAdvImageLayout = new System.Windows.Forms.CheckBox();
            this.cbxSaveVtiOsdReport = new System.Windows.Forms.CheckBox();
            this.cbxCustomAdvCompression = new System.Windows.Forms.CheckBox();
            this.cbxAdvCompression = new System.Windows.Forms.ComboBox();
            this.cbxMustConfirmVTI = new System.Windows.Forms.CheckBox();
            this.pnlLocationCorss = new System.Windows.Forms.Panel();
            this.nudCrossY = new System.Windows.Forms.NumericUpDown();
            this.nudCrossX = new System.Windows.Forms.NumericUpDown();
            this.cbxLocationCross = new System.Windows.Forms.CheckBox();
            this.nudCorssTransparency = new System.Windows.Forms.NumericUpDown();
            this.pnlPreserveOSDArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreserveVTIBottomRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreserveVTITopRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNTPDebugValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNTPDebugValue1)).BeginInit();
            this.pnlNTPDebug.SuspendLayout();
            this.pnlLocationCorss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorssTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPreserveOSDArea
            // 
            this.pnlPreserveOSDArea.Controls.Add(this.nudPreserveVTIBottomRow);
            this.pnlPreserveOSDArea.Controls.Add(this.nudPreserveVTITopRow);
            this.pnlPreserveOSDArea.Controls.Add(this.label3);
            this.pnlPreserveOSDArea.Enabled = false;
            this.pnlPreserveOSDArea.Location = new System.Drawing.Point(162, 11);
            this.pnlPreserveOSDArea.Name = "pnlPreserveOSDArea";
            this.pnlPreserveOSDArea.Size = new System.Drawing.Size(141, 25);
            this.pnlPreserveOSDArea.TabIndex = 32;
            // 
            // nudPreserveVTIBottomRow
            // 
            this.nudPreserveVTIBottomRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPreserveVTIBottomRow.Location = new System.Drawing.Point(85, 3);
            this.nudPreserveVTIBottomRow.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudPreserveVTIBottomRow.Name = "nudPreserveVTIBottomRow";
            this.nudPreserveVTIBottomRow.Size = new System.Drawing.Size(49, 20);
            this.nudPreserveVTIBottomRow.TabIndex = 25;
            this.nudPreserveVTIBottomRow.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // nudPreserveVTITopRow
            // 
            this.nudPreserveVTITopRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPreserveVTITopRow.Location = new System.Drawing.Point(9, 3);
            this.nudPreserveVTITopRow.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudPreserveVTITopRow.Name = "nudPreserveVTITopRow";
            this.nudPreserveVTITopRow.Size = new System.Drawing.Size(50, 20);
            this.nudPreserveVTITopRow.TabIndex = 24;
            this.nudPreserveVTITopRow.Value = new decimal(new int[] {
            542,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "to";
            // 
            // cbxLiveOCR
            // 
            this.cbxLiveOCR.AutoSize = true;
            this.cbxLiveOCR.Location = new System.Drawing.Point(12, 238);
            this.cbxLiveOCR.Name = "cbxLiveOCR";
            this.cbxLiveOCR.Size = new System.Drawing.Size(118, 17);
            this.cbxLiveOCR.TabIndex = 29;
            this.cbxLiveOCR.Text = "PAL VTI-OSD OCR";
            this.cbxLiveOCR.UseVisualStyleBackColor = true;
            // 
            // nudNTPDebugValue2
            // 
            this.nudNTPDebugValue2.DecimalPlaces = 1;
            this.nudNTPDebugValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNTPDebugValue2.Location = new System.Drawing.Point(58, 3);
            this.nudNTPDebugValue2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNTPDebugValue2.Name = "nudNTPDebugValue2";
            this.nudNTPDebugValue2.Size = new System.Drawing.Size(49, 20);
            this.nudNTPDebugValue2.TabIndex = 28;
            this.nudNTPDebugValue2.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            // 
            // nudNTPDebugValue1
            // 
            this.nudNTPDebugValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNTPDebugValue1.Location = new System.Drawing.Point(9, 3);
            this.nudNTPDebugValue1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNTPDebugValue1.Name = "nudNTPDebugValue1";
            this.nudNTPDebugValue1.Size = new System.Drawing.Size(43, 20);
            this.nudNTPDebugValue1.TabIndex = 27;
            this.nudNTPDebugValue1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbDebugIntegration
            // 
            this.cbDebugIntegration.AutoSize = true;
            this.cbDebugIntegration.Location = new System.Drawing.Point(12, 173);
            this.cbDebugIntegration.Name = "cbDebugIntegration";
            this.cbDebugIntegration.Size = new System.Drawing.Size(161, 17);
            this.cbDebugIntegration.TabIndex = 24;
            this.cbDebugIntegration.Text = "Integration Detection Tuning";
            this.cbDebugIntegration.UseVisualStyleBackColor = true;
            // 
            // cbxStatusSectionOnly
            // 
            this.cbxStatusSectionOnly.AutoSize = true;
            this.cbxStatusSectionOnly.Location = new System.Drawing.Point(12, 205);
            this.cbxStatusSectionOnly.Name = "cbxStatusSectionOnly";
            this.cbxStatusSectionOnly.Size = new System.Drawing.Size(179, 17);
            this.cbxStatusSectionOnly.TabIndex = 26;
            this.cbxStatusSectionOnly.Text = "Status Section Only NTP Debug";
            this.cbxStatusSectionOnly.UseVisualStyleBackColor = true;
            this.cbxStatusSectionOnly.CheckedChanged += new System.EventHandler(this.cbxStatusSectionOnly_CheckedChanged);
            // 
            // cbxUserPreserveOSDLines
            // 
            this.cbxUserPreserveOSDLines.AutoSize = true;
            this.cbxUserPreserveOSDLines.Location = new System.Drawing.Point(12, 17);
            this.cbxUserPreserveOSDLines.Name = "cbxUserPreserveOSDLines";
            this.cbxUserPreserveOSDLines.Size = new System.Drawing.Size(147, 17);
            this.cbxUserPreserveOSDLines.TabIndex = 33;
            this.cbxUserPreserveOSDLines.Text = "VTI Preserve Lines (User)";
            this.cbxUserPreserveOSDLines.UseVisualStyleBackColor = true;
            this.cbxUserPreserveOSDLines.CheckedChanged += new System.EventHandler(this.cbxUserPreserveOSDLines_CheckedChanged);
            // 
            // pnlNTPDebug
            // 
            this.pnlNTPDebug.Controls.Add(this.nudNTPDebugValue2);
            this.pnlNTPDebug.Controls.Add(this.nudNTPDebugValue1);
            this.pnlNTPDebug.Enabled = false;
            this.pnlNTPDebug.Location = new System.Drawing.Point(194, 201);
            this.pnlNTPDebug.Name = "pnlNTPDebug";
            this.pnlNTPDebug.Size = new System.Drawing.Size(141, 27);
            this.pnlNTPDebug.TabIndex = 34;
            // 
            // cbxGraphDebugMode
            // 
            this.cbxGraphDebugMode.AutoSize = true;
            this.cbxGraphDebugMode.Location = new System.Drawing.Point(12, 76);
            this.cbxGraphDebugMode.Name = "cbxGraphDebugMode";
            this.cbxGraphDebugMode.Size = new System.Drawing.Size(148, 17);
            this.cbxGraphDebugMode.TabIndex = 37;
            this.cbxGraphDebugMode.Text = "DirectShow Graph Debug";
            this.cbxGraphDebugMode.UseVisualStyleBackColor = true;
            // 
            // cbxImageLayoutMode
            // 
            this.cbxImageLayoutMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxImageLayoutMode.FormattingEnabled = true;
            this.cbxImageLayoutMode.Location = new System.Drawing.Point(164, 105);
            this.cbxImageLayoutMode.Name = "cbxImageLayoutMode";
            this.cbxImageLayoutMode.Size = new System.Drawing.Size(170, 21);
            this.cbxImageLayoutMode.TabIndex = 36;
            this.cbxImageLayoutMode.Visible = false;
            // 
            // cbxCustomAdvImageLayout
            // 
            this.cbxCustomAdvImageLayout.AutoSize = true;
            this.cbxCustomAdvImageLayout.Location = new System.Drawing.Point(12, 109);
            this.cbxCustomAdvImageLayout.Name = "cbxCustomAdvImageLayout";
            this.cbxCustomAdvImageLayout.Size = new System.Drawing.Size(146, 17);
            this.cbxCustomAdvImageLayout.TabIndex = 38;
            this.cbxCustomAdvImageLayout.Text = "ADV Image Layout (User)";
            this.cbxCustomAdvImageLayout.UseVisualStyleBackColor = true;
            this.cbxCustomAdvImageLayout.CheckedChanged += new System.EventHandler(this.cbxCustomAdvImageLayout_CheckedChanged);
            // 
            // cbxSaveVtiOsdReport
            // 
            this.cbxSaveVtiOsdReport.AutoSize = true;
            this.cbxSaveVtiOsdReport.Location = new System.Drawing.Point(12, 45);
            this.cbxSaveVtiOsdReport.Name = "cbxSaveVtiOsdReport";
            this.cbxSaveVtiOsdReport.Size = new System.Drawing.Size(277, 17);
            this.cbxSaveVtiOsdReport.TabIndex = 39;
            this.cbxSaveVtiOsdReport.Text = "Save Report on Unsuccessful VTI-OSD Identification";
            this.cbxSaveVtiOsdReport.UseVisualStyleBackColor = true;
            // 
            // cbxCustomAdvCompression
            // 
            this.cbxCustomAdvCompression.AutoSize = true;
            this.cbxCustomAdvCompression.Location = new System.Drawing.Point(12, 142);
            this.cbxCustomAdvCompression.Name = "cbxCustomAdvCompression";
            this.cbxCustomAdvCompression.Size = new System.Drawing.Size(142, 17);
            this.cbxCustomAdvCompression.TabIndex = 41;
            this.cbxCustomAdvCompression.Text = "ADV Compression (User)";
            this.cbxCustomAdvCompression.UseVisualStyleBackColor = true;
            this.cbxCustomAdvCompression.CheckedChanged += new System.EventHandler(this.cbxCustomAdvCompression_CheckedChanged);
            // 
            // cbxAdvCompression
            // 
            this.cbxAdvCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAdvCompression.FormattingEnabled = true;
            this.cbxAdvCompression.Items.AddRange(new object[] {
            "QuickLZ",
            "Lagarith16"});
            this.cbxAdvCompression.Location = new System.Drawing.Point(164, 138);
            this.cbxAdvCompression.Name = "cbxAdvCompression";
            this.cbxAdvCompression.Size = new System.Drawing.Size(170, 21);
            this.cbxAdvCompression.TabIndex = 40;
            this.cbxAdvCompression.Visible = false;
            // 
            // cbxMustConfirmVTI
            // 
            this.cbxMustConfirmVTI.AutoSize = true;
            this.cbxMustConfirmVTI.Location = new System.Drawing.Point(316, 17);
            this.cbxMustConfirmVTI.Name = "cbxMustConfirmVTI";
            this.cbxMustConfirmVTI.Size = new System.Drawing.Size(99, 17);
            this.cbxMustConfirmVTI.TabIndex = 42;
            this.cbxMustConfirmVTI.Text = "Manual Confirm";
            this.cbxMustConfirmVTI.UseVisualStyleBackColor = true;
            // 
            // pnlLocationCorss
            // 
            this.pnlLocationCorss.Controls.Add(this.nudCorssTransparency);
            this.pnlLocationCorss.Controls.Add(this.nudCrossY);
            this.pnlLocationCorss.Controls.Add(this.nudCrossX);
            this.pnlLocationCorss.Enabled = false;
            this.pnlLocationCorss.Location = new System.Drawing.Point(194, 267);
            this.pnlLocationCorss.Name = "pnlLocationCorss";
            this.pnlLocationCorss.Size = new System.Drawing.Size(232, 27);
            this.pnlLocationCorss.TabIndex = 44;
            // 
            // nudCrossY
            // 
            this.nudCrossY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCrossY.Location = new System.Drawing.Point(58, 3);
            this.nudCrossY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCrossY.Name = "nudCrossY";
            this.nudCrossY.Size = new System.Drawing.Size(49, 20);
            this.nudCrossY.TabIndex = 28;
            this.nudCrossY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudCrossX
            // 
            this.nudCrossX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCrossX.Location = new System.Drawing.Point(3, 3);
            this.nudCrossX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCrossX.Name = "nudCrossX";
            this.nudCrossX.Size = new System.Drawing.Size(49, 20);
            this.nudCrossX.TabIndex = 27;
            this.nudCrossX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbxLocationCross
            // 
            this.cbxLocationCross.AutoSize = true;
            this.cbxLocationCross.Location = new System.Drawing.Point(12, 271);
            this.cbxLocationCross.Name = "cbxLocationCross";
            this.cbxLocationCross.Size = new System.Drawing.Size(133, 17);
            this.cbxLocationCross.TabIndex = 43;
            this.cbxLocationCross.Text = "Display Location Cross";
            this.cbxLocationCross.UseVisualStyleBackColor = true;
            this.cbxLocationCross.CheckedChanged += new System.EventHandler(this.cbxLocationCross_CheckedChanged);
            // 
            // nudCorssTransparency
            // 
            this.nudCorssTransparency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCorssTransparency.Location = new System.Drawing.Point(141, 3);
            this.nudCorssTransparency.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCorssTransparency.Name = "nudCorssTransparency";
            this.nudCorssTransparency.Size = new System.Drawing.Size(49, 20);
            this.nudCorssTransparency.TabIndex = 29;
            this.nudCorssTransparency.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ucAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLocationCorss);
            this.Controls.Add(this.cbxLocationCross);
            this.Controls.Add(this.cbxMustConfirmVTI);
            this.Controls.Add(this.cbxCustomAdvCompression);
            this.Controls.Add(this.cbxAdvCompression);
            this.Controls.Add(this.cbxSaveVtiOsdReport);
            this.Controls.Add(this.cbxCustomAdvImageLayout);
            this.Controls.Add(this.cbxGraphDebugMode);
            this.Controls.Add(this.cbxImageLayoutMode);
            this.Controls.Add(this.pnlNTPDebug);
            this.Controls.Add(this.cbxUserPreserveOSDLines);
            this.Controls.Add(this.pnlPreserveOSDArea);
            this.Controls.Add(this.cbxLiveOCR);
            this.Controls.Add(this.cbDebugIntegration);
            this.Controls.Add(this.cbxStatusSectionOnly);
            this.Name = "ucAdvanced";
            this.Size = new System.Drawing.Size(532, 303);
            this.pnlPreserveOSDArea.ResumeLayout(false);
            this.pnlPreserveOSDArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreserveVTIBottomRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreserveVTITopRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNTPDebugValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNTPDebugValue1)).EndInit();
            this.pnlNTPDebug.ResumeLayout(false);
            this.pnlLocationCorss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorssTransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudNTPDebugValue2;
		private System.Windows.Forms.NumericUpDown nudNTPDebugValue1;
		private System.Windows.Forms.CheckBox cbDebugIntegration;
		private System.Windows.Forms.CheckBox cbxStatusSectionOnly;
		private System.Windows.Forms.CheckBox cbxLiveOCR;
		private System.Windows.Forms.Panel pnlPreserveOSDArea;
		private System.Windows.Forms.NumericUpDown nudPreserveVTIBottomRow;
		private System.Windows.Forms.NumericUpDown nudPreserveVTITopRow;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cbxUserPreserveOSDLines;
		private System.Windows.Forms.Panel pnlNTPDebug;
		private System.Windows.Forms.CheckBox cbxGraphDebugMode;
		private System.Windows.Forms.ComboBox cbxImageLayoutMode;
		private System.Windows.Forms.CheckBox cbxCustomAdvImageLayout;
		private System.Windows.Forms.CheckBox cbxSaveVtiOsdReport;
		private System.Windows.Forms.CheckBox cbxCustomAdvCompression;
		private System.Windows.Forms.ComboBox cbxAdvCompression;
        private System.Windows.Forms.CheckBox cbxMustConfirmVTI;
        private System.Windows.Forms.Panel pnlLocationCorss;
        private System.Windows.Forms.NumericUpDown nudCrossY;
        private System.Windows.Forms.NumericUpDown nudCrossX;
        private System.Windows.Forms.CheckBox cbxLocationCross;
        private System.Windows.Forms.NumericUpDown nudCorssTransparency;
	}
}
