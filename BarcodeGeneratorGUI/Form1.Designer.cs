namespace BarcodeGenerator.GUI
{
    partial class BarcodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeGenerator));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.BarcodeSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BarcodeFont = new System.Windows.Forms.ComboBox();
            this.OmitText = new System.Windows.Forms.CheckBox();
            this.ClipboardCopy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(714, 40);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 35);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode value";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(20, 40);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(272, 26);
            this.txtInput.TabIndex = 1;
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(16, 121);
            this.picBarcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(810, 100);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBarcode.TabIndex = 3;
            this.picBarcode.TabStop = false;
            // 
            // BarcodeSize
            // 
            this.BarcodeSize.FormattingEnabled = true;
            this.BarcodeSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.BarcodeSize.Location = new System.Drawing.Point(299, 40);
            this.BarcodeSize.Name = "BarcodeSize";
            this.BarcodeSize.Size = new System.Drawing.Size(121, 28);
            this.BarcodeSize.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barcode Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text Font";
            // 
            // BarcodeFont
            // 
            this.BarcodeFont.FormattingEnabled = true;
            this.BarcodeFont.Location = new System.Drawing.Point(426, 40);
            this.BarcodeFont.Name = "BarcodeFont";
            this.BarcodeFont.Size = new System.Drawing.Size(282, 28);
            this.BarcodeFont.TabIndex = 3;
            // 
            // OmitText
            // 
            this.OmitText.AutoSize = true;
            this.OmitText.Location = new System.Drawing.Point(24, 75);
            this.OmitText.Name = "OmitText";
            this.OmitText.Size = new System.Drawing.Size(102, 24);
            this.OmitText.TabIndex = 4;
            this.OmitText.Text = "Omit Text";
            this.OmitText.UseVisualStyleBackColor = true;
            this.OmitText.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClipboardCopy
            // 
            this.ClipboardCopy.AutoSize = true;
            this.ClipboardCopy.Checked = true;
            this.ClipboardCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClipboardCopy.Location = new System.Drawing.Point(147, 75);
            this.ClipboardCopy.Name = "ClipboardCopy";
            this.ClipboardCopy.Size = new System.Drawing.Size(160, 24);
            this.ClipboardCopy.TabIndex = 5;
            this.ClipboardCopy.Text = "Copy to Clipboard";
            this.ClipboardCopy.UseVisualStyleBackColor = true;
            // 
            // BarcodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(848, 228);
            this.Controls.Add(this.ClipboardCopy);
            this.Controls.Add(this.OmitText);
            this.Controls.Add(this.BarcodeFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarcodeSize);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BarcodeGenerator";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Barcode128 Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.ComboBox BarcodeSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BarcodeFont;
        private System.Windows.Forms.CheckBox OmitText;
        private System.Windows.Forms.CheckBox ClipboardCopy;
    }
}

