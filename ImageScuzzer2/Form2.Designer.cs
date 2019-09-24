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
            this.ShuffleRowChanceLabel = new System.Windows.Forms.Label();
            this.RowOffsetChance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MagnitudeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowOffsetChance)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveColorChannelsLabel
            // 
            this.ActiveColorChannelsLabel.Location = new System.Drawing.Point(33, 12);
            this.ActiveColorChannelsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ActiveColorChannelsLabel.Name = "ActiveColorChannelsLabel";
            this.ActiveColorChannelsLabel.Size = new System.Drawing.Size(116, 13);
            this.ActiveColorChannelsLabel.TabIndex = 0;
            this.ActiveColorChannelsLabel.Text = "Active Color Channels:";
            // 
            // RChannelCheckbox
            // 
            this.RChannelCheckbox.Location = new System.Drawing.Point(155, 11);
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
            this.GChannelCheckbox.Location = new System.Drawing.Point(195, 11);
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
            this.BChannelCheckbox.Location = new System.Drawing.Point(235, 11);
            this.BChannelCheckbox.Name = "BChannelCheckbox";
            this.BChannelCheckbox.Size = new System.Drawing.Size(33, 17);
            this.BChannelCheckbox.TabIndex = 2;
            this.BChannelCheckbox.Text = "B";
            this.BChannelCheckbox.UseVisualStyleBackColor = true;
            this.BChannelCheckbox.CheckedChanged += new System.EventHandler(this.BChannelCheckbox_CheckedChanged);
            // 
            // MagnitudeLabel
            // 
            this.MagnitudeLabel.Location = new System.Drawing.Point(33, 33);
            this.MagnitudeLabel.Margin = new System.Windows.Forms.Padding(3);
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
            this.MagnitudeValue.Location = new System.Drawing.Point(155, 31);
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
            // ShuffleRowChanceLabel
            // 
            this.ShuffleRowChanceLabel.Location = new System.Drawing.Point(33, 52);
            this.ShuffleRowChanceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ShuffleRowChanceLabel.Name = "ShuffleRowChanceLabel";
            this.ShuffleRowChanceLabel.Size = new System.Drawing.Size(116, 13);
            this.ShuffleRowChanceLabel.TabIndex = 4;
            this.ShuffleRowChanceLabel.Text = "Row Offset Chance:";
            // 
            // RowOffsetChance
            // 
            this.RowOffsetChance.DecimalPlaces = 2;
            this.RowOffsetChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.RowOffsetChance.Location = new System.Drawing.Point(155, 50);
            this.RowOffsetChance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowOffsetChance.Name = "RowOffsetChance";
            this.RowOffsetChance.Size = new System.Drawing.Size(113, 20);
            this.RowOffsetChance.TabIndex = 5;
            this.RowOffsetChance.Tag = "";
            this.RowOffsetChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RowOffsetChance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RowOffsetChance.ValueChanged += new System.EventHandler(this.RowOffsetChance_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 381);
            this.Controls.Add(this.RowOffsetChance);
            this.Controls.Add(this.ShuffleRowChanceLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.MagnitudeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowOffsetChance)).EndInit();
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
        private System.Windows.Forms.Label ShuffleRowChanceLabel;
        private System.Windows.Forms.NumericUpDown RowOffsetChance;
    }
}