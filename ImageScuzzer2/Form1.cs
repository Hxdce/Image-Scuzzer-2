using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScuzzer2
{
    public partial class Form1 : Form
    {

        public Image OriginalImageData { get; set; }  // Original image data, unmodified.
        public class OptionsClass  // Class for the options menu.
        {
            // Determines whether the given color channel can have its value altered:
            public bool RChannelActive { get; set; }
            public bool GChannelActive { get; set; }
            public bool BChannelActive { get; set; }

            // The magnitude of potential color shifting:
            public double Magnitude = 0.25;  // 1 = 255

            // Probability of a row having its pixels shifted by a random offset value:
            public double RowOffsetChance = 0.1;  // 1 = 100%
        }

        static public OptionsClass Options = new OptionsClass();

        public Form1() {
            InitializeComponent();
        }

        public void ResizeFormForNewImage(PictureBox thePB) {
            // Exactly what it says on the tin. When an image/new image is loaded,
            // this resizes the form and moves the control panel accordingly.
            int newWidth;
            int newHeight;
            Console.WriteLine(thePB.Size.Width);
            if (thePB.Image.Size.Width < 280 || thePB.Image.Size.Height < 280) {
                newWidth = 280;
                newHeight = 280;
                this.Size = new Size(newWidth + 40, newHeight + 162);
                thePB.Location = new Point(
                    this.ClientSize.Width / 2 - thePB.Size.Width / 2,
                    (288 - thePB.Image.Size.Height) / 2 + 30
                );
            }
            else {
                newWidth = thePB.Size.Width;
                newHeight = thePB.Size.Height;
                this.Size = new Size(newWidth + 40, newHeight + 162);
                thePB.Location = new Point(12, 30);
            }

            SelectionPanel.Location = new Point(
                this.ClientSize.Width / 2 - SelectionPanel.Size.Width / 2,
                this.ClientSize.Height - 34 - SelectionPanel.Height
            );
            SelectionPanel.Anchor = AnchorStyles.None;
        }

        public void GlitchImage(Image i) {
            using (Bitmap ImagePixelData = new Bitmap(i)) {
                int mag = Convert.ToInt32(Options.Magnitude * 255);
                bool[] ActiveChannels = {
                    Options.RChannelActive,
                    Options.GChannelActive,
                    Options.BChannelActive
                };
                Random rng = new Random();
                int ROC = Convert.ToInt32(Options.RowOffsetChance * 100);
                Console.WriteLine(ROC);
                for (int y = 0; y < ImagePixelData.Height; y++) {

                    int offset = (rng.Next(1, 101) <= ROC) ? rng.Next(0, ImagePixelData.Width) : 0;

                    for (int x = 0; x < ImagePixelData.Width; x++) {
                        Color curr = ImagePixelData.GetPixel((x + offset) % ImagePixelData.Width, y);
                        int[] newColors = { 0, 0, 0 };
                        int[] cC = { curr.R, curr.G, curr.B };                        
                        for (int j = 0; j < 3; j++) {
                            newColors[j] = (ActiveChannels[j]) ? (rng.Next(0, mag) + cC[j]) % 256 : cC[j];
                        }
                        Color newPixel = Color.FromArgb(curr.A, newColors[0], newColors[1], newColors[2]);
                        ImagePixelData.SetPixel(x, y, newPixel);
                        
                    }

                }

                AppPictureBox.Image = (Image)ImagePixelData.Clone();

            }
        }

        private void LoadImageToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd1 = new OpenFileDialog()) {

                ofd1.Title = "Select A Picture";
                ofd1.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";

                if (ofd1.ShowDialog() == DialogResult.OK) {

                    AppPictureBox.Image = Image.FromFile(ofd1.FileName);
                    AppPictureBox.Size = AppPictureBox.Image.Size;
                    OriginalImageData = AppPictureBox.Image;

                    ResizeFormForNewImage(AppPictureBox);

                    foreach (Button i in new Button[] {GlitchButton, SaveButton, ResetButton}) {
                        i.Enabled = true;
                    }

                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            AppPictureBox.Image = (Image)OriginalImageData.Clone();
        }

        private void OptionsButton_Click(object sender, EventArgs e) {
            Form2 OptionsMenu = new Form2();
            OptionsMenu.Show();
            //this.Close();
        }

        private void GlitchButton_Click(object sender, EventArgs e) {
            GlitchImage(AppPictureBox.Image);
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Directory.CreateDirectory("output");
            AppPictureBox.Image.Save("output/test.png");
        }
    }
}
