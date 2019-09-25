namespace ImageScuzzer2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ActiveColorChannelsLabel = new System.Windows.Forms.Label();
            this.RChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.GChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.BChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.MagnitudeLabel = new System.Windows.Forms.Label();
            this.MagnitudeValue = new System.Windows.Forms.NumericUpDown();
            this.OffsetChanceLabel = new System.Windows.Forms.Label();
            this.PixelOffsetChance = new System.Windows.Forms.NumericUpDown();
            this.AlphaChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.PixelOffsetDirLabel = new System.Windows.Forms.Label();
            this.VerticalPixelOffsetButton = new System.Windows.Forms.RadioButton();
            this.HorizontalPixelOffsetButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MagnitudeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetChance)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveColorChannelsLabel
            // 
            this.ActiveColorChannelsLabel.Location = new System.Drawing.Point(12, 14);
            this.ActiveColorChannelsLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ActiveColorChannelsLabel.Name = "ActiveColorChannelsLabel";
            this.ActiveColorChannelsLabel.Size = new System.Drawing.Size(116, 13);
            this.ActiveColorChannelsLabel.TabIndex = 0;
            this.ActiveColorChannelsLabel.Text = "Active Color Channels:";
            // 
            // RChannelCheckbox
            // 
            this.RChannelCheckbox.Location = new System.Drawing.Point(134, 12);
            this.RChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RChannelCheckbox.Name = "RChannelCheckbox";
            this.RChannelCheckbox.Size = new System.Drawing.Size(34, 17);
            this.RChannelCheckbox.TabIndex = 0;
            this.RChannelCheckbox.Text = "R";
            this.RChannelCheckbox.UseVisualStyleBackColor = true;
            this.RChannelCheckbox.CheckedChanged += new System.EventHandler(this.RChannelCheckbox_CheckedChanged);
            // 
            // GChannelCheckbox
            // 
            this.GChannelCheckbox.AutoSize = true;
            this.GChannelCheckbox.Location = new System.Drawing.Point(176, 12);
            this.GChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GChannelCheckbox.Name = "GChannelCheckbox";
            this.GChannelCheckbox.Size = new System.Drawing.Size(34, 17);
            this.GChannelCheckbox.TabIndex = 1;
            this.GChannelCheckbox.Text = "G";
            this.GChannelCheckbox.UseVisualStyleBackColor = true;
            this.GChannelCheckbox.CheckedChanged += new System.EventHandler(this.GChannelCheckbox_CheckedChanged);
            // 
            // BChannelCheckbox
            // 
            this.BChannelCheckbox.AutoSize = true;
            this.BChannelCheckbox.Location = new System.Drawing.Point(218, 12);
            this.BChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BChannelCheckbox.Name = "BChannelCheckbox";
            this.BChannelCheckbox.Size = new System.Drawing.Size(33, 17);
            this.BChannelCheckbox.TabIndex = 2;
            this.BChannelCheckbox.Text = "B";
            this.BChannelCheckbox.UseVisualStyleBackColor = true;
            this.BChannelCheckbox.CheckedChanged += new System.EventHandler(this.BChannelCheckbox_CheckedChanged);
            // 
            // MagnitudeLabel
            // 
            this.MagnitudeLabel.Location = new System.Drawing.Point(12, 37);
            this.MagnitudeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MagnitudeLabel.Name = "MagnitudeLabel";
            this.MagnitudeLabel.Size = new System.Drawing.Size(66, 13);
            this.MagnitudeLabel.TabIndex = 0;
            this.MagnitudeLabel.Text = "Magnitude:";
            // 
            // MagnitudeValue
            // 
            this.MagnitudeValue.DecimalPlaces = 8;
            this.MagnitudeValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MagnitudeValue.Location = new System.Drawing.Point(179, 35);
            this.MagnitudeValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MagnitudeValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MagnitudeValue.Name = "MagnitudeValue";
            this.MagnitudeValue.Size = new System.Drawing.Size(113, 20);
            this.MagnitudeValue.TabIndex = 3;
            this.MagnitudeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MagnitudeValue.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.MagnitudeValue.ValueChanged += new System.EventHandler(this.MagnitudeValue_ValueChanged);
            // 
            // OffsetChanceLabel
            // 
            this.OffsetChanceLabel.Location = new System.Drawing.Point(12, 60);
            this.OffsetChanceLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OffsetChanceLabel.Name = "OffsetChanceLabel";
            this.OffsetChanceLabel.Size = new System.Drawing.Size(116, 13);
            this.OffsetChanceLabel.TabIndex = 4;
            this.OffsetChanceLabel.Text = "Pixel Offset Chance:";
            // 
            // PixelOffsetChance
            // 
            this.PixelOffsetChance.DecimalPlaces = 2;
            this.PixelOffsetChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PixelOffsetChance.Location = new System.Drawing.Point(179, 58);
            this.PixelOffsetChance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetChance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelOffsetChance.Name = "PixelOffsetChance";
            this.PixelOffsetChance.Size = new System.Drawing.Size(113, 20);
            this.PixelOffsetChance.TabIndex = 5;
            this.PixelOffsetChance.Tag = "";
            this.PixelOffsetChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PixelOffsetChance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PixelOffsetChance.ValueChanged += new System.EventHandler(this.PixelOffsetChance_ValueChanged);
            // 
            // AlphaChannelCheckbox
            // 
            this.AlphaChannelCheckbox.AutoSize = true;
            this.AlphaChannelCheckbox.Location = new System.Drawing.Point(259, 12);
            this.AlphaChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AlphaChannelCheckbox.Name = "AlphaChannelCheckbox";
            this.AlphaChannelCheckbox.Size = new System.Drawing.Size(33, 17);
            this.AlphaChannelCheckbox.TabIndex = 6;
            this.AlphaChannelCheckbox.Text = "A";
            this.AlphaChannelCheckbox.UseVisualStyleBackColor = true;
            this.AlphaChannelCheckbox.CheckedChanged += new System.EventHandler(this.AlphaChannelCheckbox_CheckedChanged);
            // 
            // PixelOffsetDirLabel
            // 
            this.PixelOffsetDirLabel.AutoSize = true;
            this.PixelOffsetDirLabel.Location = new System.Drawing.Point(12, 83);
            this.PixelOffsetDirLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetDirLabel.Name = "PixelOffsetDirLabel";
            this.PixelOffsetDirLabel.Size = new System.Drawing.Size(83, 13);
            this.PixelOffsetDirLabel.TabIndex = 7;
            this.PixelOffsetDirLabel.Text = "Offset Direction:";
            // 
            // VerticalPixelOffsetButton
            // 
            this.VerticalPixelOffsetButton.AutoSize = true;
            this.VerticalPixelOffsetButton.Location = new System.Drawing.Point(152, 81);
            this.VerticalPixelOffsetButton.Name = "VerticalPixelOffsetButton";
            this.VerticalPixelOffsetButton.Size = new System.Drawing.Size(60, 17);
            this.VerticalPixelOffsetButton.TabIndex = 8;
            this.VerticalPixelOffsetButton.TabStop = true;
            this.VerticalPixelOffsetButton.Text = "Vertical";
            this.VerticalPixelOffsetButton.UseVisualStyleBackColor = true;
            this.VerticalPixelOffsetButton.CheckedChanged += new System.EventHandler(this.VerticalPixelOffsetButton_CheckedChanged);
            // 
            // HorizontalPixelOffsetButton
            // 
            this.HorizontalPixelOffsetButton.AutoSize = true;
            this.HorizontalPixelOffsetButton.Location = new System.Drawing.Point(218, 81);
            this.HorizontalPixelOffsetButton.Name = "HorizontalPixelOffsetButton";
            this.HorizontalPixelOffsetButton.Size = new System.Drawing.Size(72, 17);
            this.HorizontalPixelOffsetButton.TabIndex = 9;
            this.HorizontalPixelOffsetButton.TabStop = true;
            this.HorizontalPixelOffsetButton.Text = "Horizontal";
            this.HorizontalPixelOffsetButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 403);
            this.Controls.Add(this.HorizontalPixelOffsetButton);
            this.Controls.Add(this.VerticalPixelOffsetButton);
            this.Controls.Add(this.PixelOffsetDirLabel);
            this.Controls.Add(this.AlphaChannelCheckbox);
            this.Controls.Add(this.PixelOffsetChance);
            this.Controls.Add(this.OffsetChanceLabel);
            this.Controls.Add(this.MagnitudeValue);
            this.Controls.Add(this.MagnitudeLabel);
            this.Controls.Add(this.BChannelCheckbox);
            this.Controls.Add(this.GChannelCheckbox);
            this.Controls.Add(this.RChannelCheckbox);
            this.Controls.Add(this.ActiveColorChannelsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MagnitudeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetChance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActiveColorChannelsLabel;
        private System.Windows.Forms.CheckBox RChannelCheckbox;
        private System.Windows.Forms.CheckBox GChannelCheckbox;
        private System.Windows.Forms.CheckBox BChannelCheckbox;
        private System.Windows.Forms.Label MagnitudeLabel;
        private System.Windows.Forms.NumericUpDown MagnitudeValue;
        private System.Windows.Forms.Label OffsetChanceLabel;
        private System.Windows.Forms.NumericUpDown PixelOffsetChance;
        private System.Windows.Forms.CheckBox AlphaChannelCheckbox;
        private System.Windows.Forms.Label PixelOffsetDirLabel;
        private System.Windows.Forms.RadioButton VerticalPixelOffsetButton;
        private System.Windows.Forms.RadioButton HorizontalPixelOffsetButton;
    }
}