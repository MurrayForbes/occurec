﻿namespace OccuRec.Config.Panels
{
	partial class ucAAV
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
			this.cbDebugIntegration = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbForceIntegrationRateRestrictions = new System.Windows.Forms.CheckBox();
			this.label15 = new System.Windows.Forms.Label();
			this.nudCalibrIntegrRate = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.nudGammaDiff = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.nudSignDiffRatio = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nudMinSignDiff = new System.Windows.Forms.NumericUpDown();
			this.cbxFrameProcessingMode = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cbxRecordSecondaryTimeStamps = new System.Windows.Forms.CheckBox();
			this.cbxRecordNTPTimeStamps = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCalibrIntegrRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudGammaDiff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSignDiffRatio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinSignDiff)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbDebugIntegration
			// 
			this.cbDebugIntegration.AutoSize = true;
			this.cbDebugIntegration.Location = new System.Drawing.Point(202, 185);
			this.cbDebugIntegration.Name = "cbDebugIntegration";
			this.cbDebugIntegration.Size = new System.Drawing.Size(161, 17);
			this.cbDebugIntegration.TabIndex = 24;
			this.cbDebugIntegration.Text = "Integration Detection Tuning";
			this.cbDebugIntegration.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbForceIntegrationRateRestrictions);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.nudCalibrIntegrRate);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.nudGammaDiff);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.nudSignDiffRatio);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.nudMinSignDiff);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(362, 152);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Integration Detection";
			// 
			// cbForceIntegrationRateRestrictions
			// 
			this.cbForceIntegrationRateRestrictions.AutoSize = true;
			this.cbForceIntegrationRateRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbForceIntegrationRateRestrictions.Location = new System.Drawing.Point(15, 125);
			this.cbForceIntegrationRateRestrictions.Name = "cbForceIntegrationRateRestrictions";
			this.cbForceIntegrationRateRestrictions.Size = new System.Drawing.Size(190, 17);
			this.cbForceIntegrationRateRestrictions.TabIndex = 16;
			this.cbForceIntegrationRateRestrictions.Text = "Force Integration Rate Restrictions";
			this.cbForceIntegrationRateRestrictions.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(12, 94);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(138, 13);
			this.label15.TabIndex = 14;
			this.label15.Text = "Calibration Integration Rate:";
			// 
			// nudCalibrIntegrRate
			// 
			this.nudCalibrIntegrRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudCalibrIntegrRate.Location = new System.Drawing.Point(192, 91);
			this.nudCalibrIntegrRate.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.nudCalibrIntegrRate.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.nudCalibrIntegrRate.Name = "nudCalibrIntegrRate";
			this.nudCalibrIntegrRate.Size = new System.Drawing.Size(49, 20);
			this.nudCalibrIntegrRate.TabIndex = 15;
			this.nudCalibrIntegrRate.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(212, 32);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(79, 13);
			this.label14.TabIndex = 12;
			this.label14.Text = "Gamma Factor:";
			// 
			// nudGammaDiff
			// 
			this.nudGammaDiff.DecimalPlaces = 2;
			this.nudGammaDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudGammaDiff.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.nudGammaDiff.Location = new System.Drawing.Point(296, 28);
			this.nudGammaDiff.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudGammaDiff.Name = "nudGammaDiff";
			this.nudGammaDiff.Size = new System.Drawing.Size(49, 20);
			this.nudGammaDiff.TabIndex = 13;
			this.nudGammaDiff.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Minimal Signature Ratio";
			// 
			// nudSignDiffRatio
			// 
			this.nudSignDiffRatio.DecimalPlaces = 1;
			this.nudSignDiffRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudSignDiffRatio.Location = new System.Drawing.Point(136, 28);
			this.nudSignDiffRatio.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudSignDiffRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSignDiffRatio.Name = "nudSignDiffRatio";
			this.nudSignDiffRatio.Size = new System.Drawing.Size(49, 20);
			this.nudSignDiffRatio.TabIndex = 5;
			this.nudSignDiffRatio.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Minimal Signature Difference:";
			// 
			// nudMinSignDiff
			// 
			this.nudMinSignDiff.DecimalPlaces = 2;
			this.nudMinSignDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudMinSignDiff.Location = new System.Drawing.Point(191, 60);
			this.nudMinSignDiff.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMinSignDiff.Name = "nudMinSignDiff";
			this.nudMinSignDiff.Size = new System.Drawing.Size(49, 20);
			this.nudMinSignDiff.TabIndex = 7;
			this.nudMinSignDiff.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			// 
			// cbxFrameProcessingMode
			// 
			this.cbxFrameProcessingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFrameProcessingMode.FormattingEnabled = true;
			this.cbxFrameProcessingMode.Items.AddRange(new object[] {
            "Buffered",
            "Synchronous"});
			this.cbxFrameProcessingMode.Location = new System.Drawing.Point(3, 183);
			this.cbxFrameProcessingMode.Name = "cbxFrameProcessingMode";
			this.cbxFrameProcessingMode.Size = new System.Drawing.Size(144, 21);
			this.cbxFrameProcessingMode.TabIndex = 22;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(0, 167);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 13);
			this.label12.TabIndex = 23;
			this.label12.Text = "Frame Processing";
			// 
			// cbxRecordSecondaryTimeStamps
			// 
			this.cbxRecordSecondaryTimeStamps.AutoSize = true;
			this.cbxRecordSecondaryTimeStamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbxRecordSecondaryTimeStamps.Location = new System.Drawing.Point(15, 54);
			this.cbxRecordSecondaryTimeStamps.Name = "cbxRecordSecondaryTimeStamps";
			this.cbxRecordSecondaryTimeStamps.Size = new System.Drawing.Size(197, 17);
			this.cbxRecordSecondaryTimeStamps.TabIndex = 49;
			this.cbxRecordSecondaryTimeStamps.Text = "Record Windows Clock Timestamps";
			this.cbxRecordSecondaryTimeStamps.UseVisualStyleBackColor = true;
			// 
			// cbxRecordNTPTimeStamps
			// 
			this.cbxRecordNTPTimeStamps.AutoSize = true;
			this.cbxRecordNTPTimeStamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbxRecordNTPTimeStamps.Location = new System.Drawing.Point(15, 28);
			this.cbxRecordNTPTimeStamps.Name = "cbxRecordNTPTimeStamps";
			this.cbxRecordNTPTimeStamps.Size = new System.Drawing.Size(145, 17);
			this.cbxRecordNTPTimeStamps.TabIndex = 48;
			this.cbxRecordNTPTimeStamps.Text = "Record NTP Timestamps";
			this.cbxRecordNTPTimeStamps.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbxRecordNTPTimeStamps);
			this.groupBox2.Controls.Add(this.cbxRecordSecondaryTimeStamps);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(3, 222);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(362, 91);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Computer Timestamp";
			// 
			// ucAAV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cbDebugIntegration);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbxFrameProcessingMode);
			this.Controls.Add(this.label12);
			this.Name = "ucAAV";
			this.Size = new System.Drawing.Size(401, 327);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCalibrIntegrRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudGammaDiff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSignDiffRatio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinSignDiff)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbDebugIntegration;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbForceIntegrationRateRestrictions;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown nudCalibrIntegrRate;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown nudGammaDiff;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudSignDiffRatio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudMinSignDiff;
		private System.Windows.Forms.ComboBox cbxFrameProcessingMode;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox cbxRecordSecondaryTimeStamps;
		private System.Windows.Forms.CheckBox cbxRecordNTPTimeStamps;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
