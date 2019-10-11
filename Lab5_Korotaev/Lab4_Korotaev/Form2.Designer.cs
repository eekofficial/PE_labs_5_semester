namespace Lab4_Korotaev
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.interval = new System.Windows.Forms.RadioButton();
            this.less_value = new System.Windows.Forms.RadioButton();
            this.more_value = new System.Windows.Forms.RadioButton();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value_label1 = new System.Windows.Forms.Label();
            this.value_label2 = new System.Windows.Forms.Label();
            this.hide_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.interval);
            this.groupBox1.Controls.Add(this.less_value);
            this.groupBox1.Controls.Add(this.more_value);
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим работы";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // interval
            // 
            this.interval.AutoSize = true;
            this.interval.Location = new System.Drawing.Point(17, 81);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(74, 17);
            this.interval.TabIndex = 2;
            this.interval.TabStop = true;
            this.interval.Text = "Интервал";
            this.interval.UseVisualStyleBackColor = true;
            this.interval.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // less_value
            // 
            this.less_value.AutoSize = true;
            this.less_value.Location = new System.Drawing.Point(17, 58);
            this.less_value.Name = "less_value";
            this.less_value.Size = new System.Drawing.Size(122, 17);
            this.less_value.TabIndex = 1;
            this.less_value.TabStop = true;
            this.less_value.Text = "Меньше значенияя";
            this.less_value.UseVisualStyleBackColor = true;
            this.less_value.CheckedChanged += new System.EventHandler(this.MoreValue_CheckedChanged);
            // 
            // more_value
            // 
            this.more_value.AutoSize = true;
            this.more_value.Location = new System.Drawing.Point(17, 35);
            this.more_value.Name = "more_value";
            this.more_value.Size = new System.Drawing.Size(114, 17);
            this.more_value.TabIndex = 0;
            this.more_value.TabStop = true;
            this.more_value.Text = "Больше значения";
            this.more_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.more_value.UseVisualStyleBackColor = true;
            this.more_value.CheckedChanged += new System.EventHandler(this.More_value_CheckedChanged);
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(86, 169);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(100, 20);
            this.value1.TabIndex = 1;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(86, 205);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(100, 20);
            this.value2.TabIndex = 2;
            this.value2.Visible = false;
            // 
            // value_label1
            // 
            this.value_label1.AutoSize = true;
            this.value_label1.Location = new System.Drawing.Point(16, 172);
            this.value_label1.Name = "value_label1";
            this.value_label1.Size = new System.Drawing.Size(55, 13);
            this.value_label1.TabIndex = 3;
            this.value_label1.Text = "Значение";
            // 
            // value_label2
            // 
            this.value_label2.AutoSize = true;
            this.value_label2.Location = new System.Drawing.Point(16, 208);
            this.value_label2.Name = "value_label2";
            this.value_label2.Size = new System.Drawing.Size(64, 13);
            this.value_label2.TabIndex = 4;
            this.value_label2.Text = "Значение b";
            this.value_label2.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.Location = new System.Drawing.Point(208, 169);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(55, 56);
            this.hide_button.TabIndex = 5;
            this.hide_button.Text = "Скрыть";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.Hide_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.hide_button);
            this.Controls.Add(this.value_label2);
            this.Controls.Add(this.value_label1);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(1000, 300);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hide_button;
        public System.Windows.Forms.RadioButton interval;
        public System.Windows.Forms.RadioButton less_value;
        public System.Windows.Forms.RadioButton more_value;
        public System.Windows.Forms.TextBox value1;
        public System.Windows.Forms.TextBox value2;
        public System.Windows.Forms.Label value_label1;
        public System.Windows.Forms.Label value_label2;
    }
}