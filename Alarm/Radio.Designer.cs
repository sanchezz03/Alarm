
namespace Alarm
{
    partial class Radio
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.American_PictureBox = new System.Windows.Forms.PictureBox();
            this.Ukraine_PictureBox = new System.Windows.Forms.PictureBox();
            this.German_PictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.American_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ukraine_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.German_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "--------------------------------------",
            "Germany Radio",
            "--------------------------------------",
            "American Radio",
            "--------------------------------------",
            "Ukraine Radio",
            "--------------------------------------"});
            this.listBox1.Location = new System.Drawing.Point(33, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 166);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose station:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 188);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 32);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Now play:";
            // 
            // American_PictureBox
            // 
            this.American_PictureBox.Image = global::Alarm.Properties.Resources.united_states;
            this.American_PictureBox.Location = new System.Drawing.Point(273, 56);
            this.American_PictureBox.Name = "American_PictureBox";
            this.American_PictureBox.Size = new System.Drawing.Size(140, 118);
            this.American_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.American_PictureBox.TabIndex = 6;
            this.American_PictureBox.TabStop = false;
            // 
            // Ukraine_PictureBox
            // 
            this.Ukraine_PictureBox.Image = global::Alarm.Properties.Resources.ukraine;
            this.Ukraine_PictureBox.Location = new System.Drawing.Point(273, 56);
            this.Ukraine_PictureBox.Name = "Ukraine_PictureBox";
            this.Ukraine_PictureBox.Size = new System.Drawing.Size(140, 118);
            this.Ukraine_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ukraine_PictureBox.TabIndex = 5;
            this.Ukraine_PictureBox.TabStop = false;
            // 
            // German_PictureBox
            // 
            this.German_PictureBox.Image = global::Alarm.Properties.Resources.germany;
            this.German_PictureBox.Location = new System.Drawing.Point(273, 56);
            this.German_PictureBox.Name = "German_PictureBox";
            this.German_PictureBox.Size = new System.Drawing.Size(140, 118);
            this.German_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.German_PictureBox.TabIndex = 4;
            this.German_PictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.American_PictureBox);
            this.Controls.Add(this.Ukraine_PictureBox);
            this.Controls.Add(this.German_PictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Radio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio";
            ((System.ComponentModel.ISupportInitialize)(this.American_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ukraine_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.German_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox German_PictureBox;
        private System.Windows.Forms.PictureBox Ukraine_PictureBox;
        private System.Windows.Forms.PictureBox American_PictureBox;
        private System.Windows.Forms.Button button1;
    }
}