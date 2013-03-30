﻿namespace AAVRec
{
    partial class frmChooseCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseCamera));
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOutputLocation = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCaptureDevices = new System.Windows.Forms.ComboBox();
            this.cbxMonochromeConversion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCameraModel = new System.Windows.Forms.ComboBox();
            this.gbxCodecs = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFileAAV = new System.Windows.Forms.RadioButton();
            this.rbFileAVI = new System.Windows.Forms.RadioButton();
            this.rbCodecUncompressed = new System.Windows.Forms.RadioButton();
            this.rbCodecXviD = new System.Windows.Forms.RadioButton();
            this.rbCodecHuffyuv = new System.Windows.Forms.RadioButton();
            this.rbCodecLagarith = new System.Windows.Forms.RadioButton();
            this.cbxIsIntegrating = new System.Windows.Forms.CheckBox();
            this.gbxAAVSettings = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxCodecs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxAAVSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(363, 208);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseOutputFolder.TabIndex = 10;
            this.btnBrowseOutputFolder.Text = "...";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output Video Location";
            // 
            // tbxOutputLocation
            // 
            this.tbxOutputLocation.Location = new System.Drawing.Point(12, 211);
            this.tbxOutputLocation.Name = "tbxOutputLocation";
            this.tbxOutputLocation.Size = new System.Drawing.Size(345, 20);
            this.tbxOutputLocation.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(237, 246);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Video Capture Device";
            // 
            // cbxCaptureDevices
            // 
            this.cbxCaptureDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaptureDevices.FormattingEnabled = true;
            this.cbxCaptureDevices.Location = new System.Drawing.Point(12, 27);
            this.cbxCaptureDevices.Name = "cbxCaptureDevices";
            this.cbxCaptureDevices.Size = new System.Drawing.Size(225, 21);
            this.cbxCaptureDevices.TabIndex = 14;
            // 
            // cbxMonochromeConversion
            // 
            this.cbxMonochromeConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonochromeConversion.FormattingEnabled = true;
            this.cbxMonochromeConversion.Items.AddRange(new object[] {
            "Use R value",
            "Use G value",
            "Use B value",
            "Compute GrayScale value"});
            this.cbxMonochromeConversion.Location = new System.Drawing.Point(16, 84);
            this.cbxMonochromeConversion.Name = "cbxMonochromeConversion";
            this.cbxMonochromeConversion.Size = new System.Drawing.Size(168, 21);
            this.cbxMonochromeConversion.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Monochrome Pixel Conversion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Camera Model";
            // 
            // cbxCameraModel
            // 
            this.cbxCameraModel.FormattingEnabled = true;
            this.cbxCameraModel.Items.AddRange(new object[] {
            "WAT-910HX",
            "WAT-120N"});
            this.cbxCameraModel.Location = new System.Drawing.Point(16, 34);
            this.cbxCameraModel.Name = "cbxCameraModel";
            this.cbxCameraModel.Size = new System.Drawing.Size(150, 21);
            this.cbxCameraModel.TabIndex = 20;
            // 
            // gbxCodecs
            // 
            this.gbxCodecs.Controls.Add(this.rbCodecLagarith);
            this.gbxCodecs.Controls.Add(this.rbCodecHuffyuv);
            this.gbxCodecs.Controls.Add(this.rbCodecXviD);
            this.gbxCodecs.Controls.Add(this.rbCodecUncompressed);
            this.gbxCodecs.Location = new System.Drawing.Point(131, 63);
            this.gbxCodecs.Name = "gbxCodecs";
            this.gbxCodecs.Size = new System.Drawing.Size(262, 115);
            this.gbxCodecs.TabIndex = 21;
            this.gbxCodecs.TabStop = false;
            this.gbxCodecs.Text = "Video codec";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFileAVI);
            this.groupBox2.Controls.Add(this.rbFileAAV);
            this.groupBox2.Location = new System.Drawing.Point(15, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 115);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format";
            // 
            // rbFileAAV
            // 
            this.rbFileAAV.AutoSize = true;
            this.rbFileAAV.Checked = true;
            this.rbFileAAV.Location = new System.Drawing.Point(23, 36);
            this.rbFileAAV.Name = "rbFileAAV";
            this.rbFileAAV.Size = new System.Drawing.Size(46, 17);
            this.rbFileAAV.TabIndex = 0;
            this.rbFileAAV.TabStop = true;
            this.rbFileAAV.Text = "AAV";
            this.rbFileAAV.UseVisualStyleBackColor = true;
            this.rbFileAAV.CheckedChanged += new System.EventHandler(this.rbFileAAV_CheckedChanged);
            // 
            // rbFileAVI
            // 
            this.rbFileAVI.AutoSize = true;
            this.rbFileAVI.Location = new System.Drawing.Point(23, 66);
            this.rbFileAVI.Name = "rbFileAVI";
            this.rbFileAVI.Size = new System.Drawing.Size(42, 17);
            this.rbFileAVI.TabIndex = 1;
            this.rbFileAVI.Text = "AVI";
            this.rbFileAVI.UseVisualStyleBackColor = true;
            this.rbFileAVI.CheckedChanged += new System.EventHandler(this.rbFileAVI_CheckedChanged);
            // 
            // rbCodecUncompressed
            // 
            this.rbCodecUncompressed.AutoSize = true;
            this.rbCodecUncompressed.Location = new System.Drawing.Point(22, 88);
            this.rbCodecUncompressed.Name = "rbCodecUncompressed";
            this.rbCodecUncompressed.Size = new System.Drawing.Size(96, 17);
            this.rbCodecUncompressed.TabIndex = 1;
            this.rbCodecUncompressed.Text = "Uncompressed";
            this.rbCodecUncompressed.UseVisualStyleBackColor = true;
            // 
            // rbCodecXviD
            // 
            this.rbCodecXviD.AutoSize = true;
            this.rbCodecXviD.Location = new System.Drawing.Point(23, 65);
            this.rbCodecXviD.Name = "rbCodecXviD";
            this.rbCodecXviD.Size = new System.Drawing.Size(123, 17);
            this.rbCodecXviD.TabIndex = 2;
            this.rbCodecXviD.Text = "Xvid MPEG-4 Codec";
            this.rbCodecXviD.UseVisualStyleBackColor = true;
            // 
            // rbCodecHuffyuv
            // 
            this.rbCodecHuffyuv.AutoSize = true;
            this.rbCodecHuffyuv.Checked = true;
            this.rbCodecHuffyuv.Location = new System.Drawing.Point(23, 19);
            this.rbCodecHuffyuv.Name = "rbCodecHuffyuv";
            this.rbCodecHuffyuv.Size = new System.Drawing.Size(95, 17);
            this.rbCodecHuffyuv.TabIndex = 3;
            this.rbCodecHuffyuv.Text = "Huffyuv v2.1.1";
            this.rbCodecHuffyuv.UseVisualStyleBackColor = true;
            // 
            // rbCodecLagarith
            // 
            this.rbCodecLagarith.AutoSize = true;
            this.rbCodecLagarith.Location = new System.Drawing.Point(23, 42);
            this.rbCodecLagarith.Name = "rbCodecLagarith";
            this.rbCodecLagarith.Size = new System.Drawing.Size(140, 17);
            this.rbCodecLagarith.TabIndex = 4;
            this.rbCodecLagarith.Text = "Lagarith Lossless Codec";
            this.rbCodecLagarith.UseVisualStyleBackColor = true;
            // 
            // cbxIsIntegrating
            // 
            this.cbxIsIntegrating.AutoSize = true;
            this.cbxIsIntegrating.Checked = true;
            this.cbxIsIntegrating.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIsIntegrating.Location = new System.Drawing.Point(176, 40);
            this.cbxIsIntegrating.Name = "cbxIsIntegrating";
            this.cbxIsIntegrating.Size = new System.Drawing.Size(76, 17);
            this.cbxIsIntegrating.TabIndex = 23;
            this.cbxIsIntegrating.Text = "Integrating";
            this.cbxIsIntegrating.UseVisualStyleBackColor = true;
            // 
            // gbxAAVSettings
            // 
            this.gbxAAVSettings.Controls.Add(this.label4);
            this.gbxAAVSettings.Controls.Add(this.cbxIsIntegrating);
            this.gbxAAVSettings.Controls.Add(this.cbxCameraModel);
            this.gbxAAVSettings.Controls.Add(this.label3);
            this.gbxAAVSettings.Controls.Add(this.cbxMonochromeConversion);
            this.gbxAAVSettings.Location = new System.Drawing.Point(131, 64);
            this.gbxAAVSettings.Name = "gbxAAVSettings";
            this.gbxAAVSettings.Size = new System.Drawing.Size(262, 115);
            this.gbxAAVSettings.TabIndex = 22;
            this.gbxAAVSettings.TabStop = false;
            this.gbxAAVSettings.Text = "AAV settings";
            // 
            // frmChooseCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 286);
            this.Controls.Add(this.gbxAAVSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbxCaptureDevices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseOutputFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOutputLocation);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxCodecs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChooseCamera";
            this.Text = "Connect to camera";
            this.gbxCodecs.ResumeLayout(false);
            this.gbxCodecs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxAAVSettings.ResumeLayout(false);
            this.gbxAAVSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseOutputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOutputLocation;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCaptureDevices;
        private System.Windows.Forms.ComboBox cbxMonochromeConversion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCameraModel;
        private System.Windows.Forms.GroupBox gbxCodecs;
        private System.Windows.Forms.RadioButton rbCodecLagarith;
        private System.Windows.Forms.RadioButton rbCodecHuffyuv;
        private System.Windows.Forms.RadioButton rbCodecXviD;
        private System.Windows.Forms.RadioButton rbCodecUncompressed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFileAVI;
        private System.Windows.Forms.RadioButton rbFileAAV;
        private System.Windows.Forms.CheckBox cbxIsIntegrating;
        private System.Windows.Forms.GroupBox gbxAAVSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}