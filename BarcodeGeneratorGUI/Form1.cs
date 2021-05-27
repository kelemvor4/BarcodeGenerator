using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeGenerator.GUI
{
    public partial class BarcodeGenerator : Form
    {
        public BarcodeGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0) {
                global::BarcodeGenerator.Code128GS1.Encoder c128 = new global::BarcodeGenerator.Code128GS1.Encoder();
                global::BarcodeGenerator.Code128GS1.BarcodeImage barcodeImage = new global::BarcodeGenerator.Code128GS1.BarcodeImage();

                if (OmitText.Checked)
                {
                    picBarcode.Image = barcodeImage.CreateImage(c128.Encode(txtInput.Text),Int32.Parse(BarcodeSize.GetItemText(BarcodeSize.SelectedItem)),true);
                }
                else
                {
                    picBarcode.Image = barcodeImage.CreateImage(txtInput.Text, c128.Encode(txtInput.Text), Int32.Parse(BarcodeSize.GetItemText(BarcodeSize.SelectedItem)), true, BarcodeFont.GetItemText(BarcodeFont.SelectedItem));
                    // 098X1234567Y23
                    // [Start B] 16 25 24 56 17 [Code C] 23 45 67 [Code B] 57 18 19 [checksum] [Stop]
                }
                if (ClipboardCopy.Checked)
                {
                    System.Windows.Forms.Clipboard.SetImage(picBarcode.Image);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BarcodeSize.SelectedIndex = 1;


            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    BarcodeFont.Items.Add(fa.Name);
                }
            }
            BarcodeFont.SelectedIndex = BarcodeFont.FindStringExact("Arial");



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (OmitText.Checked)
            {
                BarcodeFont.Enabled = false;
            } else
            {
                BarcodeFont.Enabled = true;
            }
        }
    }
}
