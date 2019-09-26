using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScuzzer2
{
    public partial class Form2 : Form
    {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            RChannelCheckbox.Checked = Form1.Options.RChannelActive;
            GChannelCheckbox.Checked = Form1.Options.GChannelActive;
            BChannelCheckbox.Checked = Form1.Options.BChannelActive;
            AlphaChannelCheckbox.Checked = Form1.Options.AChannelActive;
            MagnitudeValue.Value = Convert.ToDecimal(Form1.Options.Magnitude);
            PixelOffsetChance.Value = Convert.ToDecimal(Form1.Options.PixelOffsetChance);
            VerticalPixelOffsetButton.Checked = Form1.Options.OffsetHorizontal;
            PixelOffsetMagnitude.Value = Convert.ToDecimal(Form1.Options.PixelOffsetMagnitude);
        }

        private void RChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.RChannelActive = RChannelCheckbox.Checked;
        }

        private void GChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.GChannelActive = GChannelCheckbox.Checked;
        }

        private void BChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.BChannelActive = BChannelCheckbox.Checked;
        }

        private void AlphaChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.AChannelActive = AlphaChannelCheckbox.Checked;
        }

        private void MagnitudeValue_ValueChanged(object sender, EventArgs e) {
            Form1.Options.Magnitude = Convert.ToDouble(MagnitudeValue.Value);
        }

        private void PixelOffsetChance_ValueChanged(object sender, EventArgs e) {
            Form1.Options.PixelOffsetChance = Convert.ToDouble(PixelOffsetChance.Value);
        }

        private void VerticalPixelOffsetButton_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.OffsetHorizontal = !VerticalPixelOffsetButton.Checked;
        }

        private void PixelOffsetMagnitude_ValueChanged(object sender, EventArgs e) {
            Form1.Options.PixelOffsetMagnitude = Convert.ToDouble(PixelOffsetMagnitude.Value);
        }
    }
}
