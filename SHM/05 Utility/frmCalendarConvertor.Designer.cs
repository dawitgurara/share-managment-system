namespace SHM
{
    partial class frmCalendarConvertor
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
            this.GregDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EthioDateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GregDateTimePicker
            // 
            this.GregDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.GregDateTimePicker.Location = new System.Drawing.Point(22, 37);
            this.GregDateTimePicker.Name = "GregDateTimePicker";
            this.GregDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.GregDateTimePicker.TabIndex = 158;
            this.GregDateTimePicker.Value = new System.DateTime(2018, 4, 18, 0, 0, 0, 0);
            // 
            // EthioDateTextBox
            // 
            this.EthioDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EthioDateTextBox.Location = new System.Drawing.Point(191, 37);
            this.EthioDateTextBox.Name = "EthioDateTextBox";
            this.EthioDateTextBox.Size = new System.Drawing.Size(137, 20);
            this.EthioDateTextBox.TabIndex = 159;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 160;
            this.button1.Text = "Convert to Eth Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 161;
            this.button2.Text = "Convert to Grig Date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCalendarConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 120);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EthioDateTextBox);
            this.Controls.Add(this.GregDateTimePicker);
            this.Name = "frmCalendarConvertor";
            this.Text = "Calendar Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker GregDateTimePicker;
        private System.Windows.Forms.TextBox EthioDateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}