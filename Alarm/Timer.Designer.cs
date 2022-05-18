
namespace Alarm
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            this.Second_label = new System.Windows.Forms.Label();
            this.Minute_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Minute_ComboBox = new System.Windows.Forms.ComboBox();
            this.Second_ComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Minutes_label = new System.Windows.Forms.Label();
            this.Seconds_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Second_timer = new System.Windows.Forms.Timer(this.components);
            this.Hour_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Second_label
            // 
            this.Second_label.AutoSize = true;
            this.Second_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second_label.Location = new System.Drawing.Point(340, 61);
            this.Second_label.Name = "Second_label";
            this.Second_label.Size = new System.Drawing.Size(81, 20);
            this.Second_label.TabIndex = 0;
            this.Second_label.Text = "Seconds";
            // 
            // Minute_label
            // 
            this.Minute_label.AutoSize = true;
            this.Minute_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minute_label.Location = new System.Drawing.Point(68, 61);
            this.Minute_label.Name = "Minute_label";
            this.Minute_label.Size = new System.Drawing.Size(75, 20);
            this.Minute_label.TabIndex = 1;
            this.Minute_label.Text = "Minutes";
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_button.ForeColor = System.Drawing.Color.White;
            this.Start_button.Location = new System.Drawing.Point(72, 288);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(132, 49);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.BackColor = System.Drawing.Color.LightCoral;
            this.Stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop_button.ForeColor = System.Drawing.Color.White;
            this.Stop_button.Location = new System.Drawing.Point(368, 288);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(132, 49);
            this.Stop_button.TabIndex = 3;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = false;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // Minute_ComboBox
            // 
            this.Minute_ComboBox.FormattingEnabled = true;
            this.Minute_ComboBox.Location = new System.Drawing.Point(72, 100);
            this.Minute_ComboBox.Name = "Minute_ComboBox";
            this.Minute_ComboBox.Size = new System.Drawing.Size(156, 24);
            this.Minute_ComboBox.TabIndex = 4;
            this.Minute_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Minute_ComboBox_SelectedIndexChanged);
            // 
            // Second_ComboBox
            // 
            this.Second_ComboBox.FormattingEnabled = true;
            this.Second_ComboBox.Location = new System.Drawing.Point(344, 100);
            this.Second_ComboBox.Name = "Second_ComboBox";
            this.Second_ComboBox.Size = new System.Drawing.Size(156, 24);
            this.Second_ComboBox.TabIndex = 5;
            this.Second_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Second_ComboBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Minutes_label
            // 
            this.Minutes_label.AutoSize = true;
            this.Minutes_label.BackColor = System.Drawing.Color.White;
            this.Minutes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minutes_label.ForeColor = System.Drawing.Color.Black;
            this.Minutes_label.Location = new System.Drawing.Point(71, 150);
            this.Minutes_label.Name = "Minutes_label";
            this.Minutes_label.Size = new System.Drawing.Size(127, 91);
            this.Minutes_label.TabIndex = 7;
            this.Minutes_label.Text = "00";
            // 
            // Seconds_label
            // 
            this.Seconds_label.AutoSize = true;
            this.Seconds_label.BackColor = System.Drawing.Color.White;
            this.Seconds_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seconds_label.ForeColor = System.Drawing.Color.Black;
            this.Seconds_label.Location = new System.Drawing.Point(373, 150);
            this.Seconds_label.Name = "Seconds_label";
            this.Seconds_label.Size = new System.Drawing.Size(127, 91);
            this.Seconds_label.TabIndex = 8;
            this.Seconds_label.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(251, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 91);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // Second_timer
            // 
            this.Second_timer.Interval = 1000;
            this.Second_timer.Tick += new System.EventHandler(this.Second_timer_Tick);
            // 
            // Hour_timer
            // 
            this.Hour_timer.Interval = 1000;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Seconds_label);
            this.Controls.Add(this.Minutes_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Second_ComboBox);
            this.Controls.Add(this.Minute_ComboBox);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Minute_label);
            this.Controls.Add(this.Second_label);
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Second_label;
        private System.Windows.Forms.Label Minute_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.ComboBox Minute_ComboBox;
        private System.Windows.Forms.ComboBox Second_ComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Minutes_label;
        private System.Windows.Forms.Label Seconds_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Second_timer;
        private System.Windows.Forms.Timer Hour_timer;
    }
}