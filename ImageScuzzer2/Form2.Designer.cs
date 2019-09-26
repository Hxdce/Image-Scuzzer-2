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
            this.PixelOffsetMagnitudeLabel = new System.Windows.Forms.Label();
            this.PixelOffsetMagnitude = new System.Windows.Forms.NumericUpDown();
            this.Divider1 = new System.Windows.Forms.Label();
            this.Divider0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MagnitudeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetMagnitude)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveColorChannelsLabel
            // 
            this.ActiveColorChannelsLabel.AutoSize = true;
            this.ActiveColorChannelsLabel.Location = new System.Drawing.Point(12, 22);
            this.ActiveColorChannelsLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ActiveColorChannelsLabel.Name = "ActiveColorChannelsLabel";
            this.ActiveColorChannelsLabel.Size = new System.Drawing.Size(114, 13);
            this.ActiveColorChannelsLabel.TabIndex = 0;
            this.ActiveColorChannelsLabel.Text = "Active Color Channels:";
            // 
            // RChannelCheckbox
            // 
            this.RChannelCheckbox.Location = new System.Drawing.Point(134, 20);
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
            this.GChannelCheckbox.Location = new System.Drawing.Point(176, 20);
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
            this.BChannelCheckbox.Location = new System.Drawing.Point(218, 20);
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
            this.MagnitudeLabel.AutoSize = true;
            this.MagnitudeLabel.Location = new System.Drawing.Point(12, 45);
            this.MagnitudeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MagnitudeLabel.Name = "MagnitudeLabel";
            this.MagnitudeLabel.Size = new System.Drawing.Size(134, 13);
            this.MagnitudeLabel.TabIndex = 0;
            this.MagnitudeLabel.Text = "Color Alteration Magnitude:";
            // 
            // MagnitudeValue
            // 
            this.MagnitudeValue.DecimalPlaces = 8;
            this.MagnitudeValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MagnitudeValue.Location = new System.Drawing.Point(179, 43);
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
            this.OffsetChanceLabel.AutoSize = true;
            this.OffsetChanceLabel.Location = new System.Drawing.Point(12, 81);
            this.OffsetChanceLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OffsetChanceLabel.Name = "OffsetChanceLabel";
            this.OffsetChanceLabel.Size = new System.Drawing.Size(103, 13);
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
            this.PixelOffsetChance.Location = new System.Drawing.Point(179, 79);
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
            this.AlphaChannelCheckbox.Location = new System.Drawing.Point(259, 20);
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
            this.PixelOffsetDirLabel.Location = new System.Drawing.Point(12, 104);
            this.PixelOffsetDirLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetDirLabel.Name = "PixelOffsetDirLabel";
            this.PixelOffsetDirLabel.Size = new System.Drawing.Size(83, 13);
            this.PixelOffsetDirLabel.TabIndex = 7;
            this.PixelOffsetDirLabel.Text = "Offset Direction:";
            // 
            // VerticalPixelOffsetButton
            // 
            this.VerticalPixelOffsetButton.AutoSize = true;
            this.VerticalPixelOffsetButton.Location = new System.Drawing.Point(154, 102);
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
            this.HorizontalPixelOffsetButton.Location = new System.Drawing.Point(220, 102);
            this.HorizontalPixelOffsetButton.Name = "HorizontalPixelOffsetButton";
            this.HorizontalPixelOffsetButton.Size = new System.Drawing.Size(72, 17);
            this.HorizontalPixelOffsetButton.TabIndex = 9;
            this.HorizontalPixelOffsetButton.TabStop = true;
            this.HorizontalPixelOffsetButton.Text = "Horizontal";
            this.HorizontalPixelOffsetButton.UseVisualStyleBackColor = true;
            // 
            // PixelOffsetMagnitudeLabel
            // 
            this.PixelOffsetMagnitudeLabel.AutoSize = true;
            this.PixelOffsetMagnitudeLabel.Location = new System.Drawing.Point(12, 127);
            this.PixelOffsetMagnitudeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetMagnitudeLabel.Name = "PixelOffsetMagnitudeLabel";
            this.PixelOffsetMagnitudeLabel.Size = new System.Drawing.Size(88, 13);
            this.PixelOffsetMagnitudeLabel.TabIndex = 10;
            this.PixelOffsetMagnitudeLabel.Text = "Offset Magnitude";
            // 
            // PixelOffsetMagnitude
            // 
            this.PixelOffsetMagnitude.DecimalPlaces = 2;
            this.PixelOffsetMagnitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PixelOffsetMagnitude.Location = new System.Drawing.Point(179, 125);
            this.PixelOffsetMagnitude.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetMagnitude.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelOffsetMagnitude.Name = "PixelOffsetMagnitude";
            this.PixelOffsetMagnitude.Size = new System.Drawing.Size(113, 20);
            this.PixelOffsetMagnitude.TabIndex = 11;
            this.PixelOffsetMagnitude.Tag = "";
            this.PixelOffsetMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PixelOffsetMagnitude.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.PixelOffsetMagnitude.ValueChanged += new System.EventHandler(this.PixelOffsetMagnitude_ValueChanged);
            // 
            // Divider1
            // 
            this.Divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider1.Location = new System.Drawing.Point(12, 71);
            this.Divider1.Margin = new System.Windows.Forms.Padding(3);
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(280, 2);
            this.Divider1.TabIndex = 12;
            // 
            // Divider0
            // 
            this.Divider0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider0.Location = new System.Drawing.Point(12, 12);
            this.Divider0.Margin = new System.Windows.Forms.Padding(3);
            this.Divider0.Name = "Divider0";
            this.Divider0.Size = new System.Drawing.Size(280, 2);
            this.Divider0.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 403);
            this.Controls.Add(this.Divider0);
            this.Controls.Add(this.Divider1);
            this.Controls.Add(this.PixelOffsetMagnitude);
            this.Controls.Add(this.PixelOffsetMagnitudeLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetMagnitude)).EndInit();
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
        private System.Windows.Forms.Label PixelOffsetMagnitudeLabel;
        private System.Windows.Forms.NumericUpDown PixelOffsetMagnitude;
        private System.Windows.Forms.Label Divider1;
        private System.Windows.Forms.Label Divider0;
    }
}