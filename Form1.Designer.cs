namespace PrimeNumbersCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartText = new System.Windows.Forms.TextBox();
            this.EndText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CheckPanel = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.CheckedLabel = new System.Windows.Forms.Label();
            this.FoundLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.CheckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(606, 377);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 30);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 395);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(668, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "End number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start number";
            // 
            // StartText
            // 
            this.StartText.Location = new System.Drawing.Point(3, 23);
            this.StartText.Name = "StartText";
            this.StartText.Size = new System.Drawing.Size(116, 22);
            this.StartText.TabIndex = 6;
            // 
            // EndText
            // 
            this.EndText.Location = new System.Drawing.Point(3, 68);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(116, 22);
            this.EndText.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 9;
            this.label3.Tag = "";
            this.label3.Text = "Created by DESU!!!";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(2, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Check number";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.TimeLabel);
            this.SearchPanel.Controls.Add(this.FoundLabel);
            this.SearchPanel.Controls.Add(this.CheckedLabel);
            this.SearchPanel.Controls.Add(this.Label6);
            this.SearchPanel.Controls.Add(this.label2);
            this.SearchPanel.Controls.Add(this.button1);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Controls.Add(this.StartText);
            this.SearchPanel.Controls.Add(this.EndText);
            this.SearchPanel.Controls.Add(this.button2);
            this.SearchPanel.Location = new System.Drawing.Point(8, 141);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(124, 248);
            this.SearchPanel.TabIndex = 13;
            this.SearchPanel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Check/Search";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckPanel
            // 
            this.CheckPanel.Controls.Add(this.label4);
            this.CheckPanel.Controls.Add(this.button3);
            this.CheckPanel.Controls.Add(this.textBox4);
            this.CheckPanel.Location = new System.Drawing.Point(8, 40);
            this.CheckPanel.Name = "CheckPanel";
            this.CheckPanel.Size = new System.Drawing.Size(124, 81);
            this.CheckPanel.TabIndex = 15;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(754, 29);
            this.trackBar1.Maximum = 18;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 360);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 26;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Size";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(42, 151);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(40, 17);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Stats";
            // 
            // CheckedLabel
            // 
            this.CheckedLabel.AutoSize = true;
            this.CheckedLabel.Location = new System.Drawing.Point(0, 168);
            this.CheckedLabel.Name = "CheckedLabel";
            this.CheckedLabel.Size = new System.Drawing.Size(79, 17);
            this.CheckedLabel.TabIndex = 10;
            this.CheckedLabel.Text = "Checked: 0";
            // 
            // FoundLabel
            // 
            this.FoundLabel.AutoSize = true;
            this.FoundLabel.Location = new System.Drawing.Point(16, 194);
            this.FoundLabel.Name = "FoundLabel";
            this.FoundLabel.Size = new System.Drawing.Size(64, 17);
            this.FoundLabel.TabIndex = 11;
            this.FoundLabel.Text = "Found: 0";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(25, 222);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(55, 17);
            this.TimeLabel.TabIndex = 12;
            this.TimeLabel.Text = "Time: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.CheckPanel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Prime numbers";
            this.contextMenuStrip1.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.CheckPanel.ResumeLayout(false);
            this.CheckPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartText;
        private System.Windows.Forms.TextBox EndText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel CheckPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TimeLabel;
        public System.Windows.Forms.Label FoundLabel;
        public System.Windows.Forms.Label CheckedLabel;
        private System.Windows.Forms.Label Label6;
    }
}