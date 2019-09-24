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

        private void RChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.RChannelActive = RChannelCheckbox.Checked;
        }

        private void GChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.GChannelActive = GChannelCheckbox.Checked;
        }

        private void BChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.BChannelActive = BChannelCheckbox.Checked;
        }

        private void MagnitudeValue_ValueChanged(object sender, EventArgs e) {
            Form1.Options.Magnitude = Convert.ToDouble(MagnitudeValue.Value);
        }

        private void RowOffsetChance_ValueChanged(object sender, EventArgs e) {
            Form1.Options.RowOffsetChance = Convert.ToDouble(RowOffsetChance.Value);
        }
    }
}
