namespace Lab4_Korotaev
{
    partial class Form3
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
            this.fill_matrix = new System.Windows.Forms.Button();
            this.create_matrix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_m = new System.Windows.Forms.TextBox();
            this.input_n = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.DataGridView();
            this.form_array = new System.Windows.Forms.Button();
            this.find_number = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // fill_matrix
            // 
            this.fill_matrix.Location = new System.Drawing.Point(167, 103);
            this.fill_matrix.Name = "fill_matrix";
            this.fill_matrix.Size = new System.Drawing.Size(79, 20);
            this.fill_matrix.TabIndex = 16;
            this.fill_matrix.Text = "Заполнить";
            this.fill_matrix.UseVisualStyleBackColor = true;
            this.fill_matrix.Click += new System.EventHandler(this.Fill_matrix_Click);
            // 
            // create_matrix
            // 
            this.create_matrix.Location = new System.Drawing.Point(167, 45);
            this.create_matrix.Name = "create_matrix";
            this.create_matrix.Size = new System.Drawing.Size(79, 20);
            this.create_matrix.TabIndex = 15;
            this.create_matrix.Text = "Создать";
            this.create_matrix.UseVisualStyleBackColor = true;
            this.create_matrix.Click += new System.EventHandler(this.Create_matrix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Столбцов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Строк";
            // 
            // input_m
            // 
            this.input_m.Location = new System.Drawing.Point(110, 104);
            this.input_m.Name = "input_m";
            this.input_m.Size = new System.Drawing.Size(28, 20);
            this.input_m.TabIndex = 12;
            // 
            // input_n
            // 
            this.input_n.Location = new System.Drawing.Point(110, 45);
            this.input_n.Name = "input_n";
            this.input_n.Size = new System.Drawing.Size(28, 20);
            this.input_n.TabIndex = 11;
            // 
            // input
            // 
            this.input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input.Location = new System.Drawing.Point(284, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(240, 150);
            this.input.TabIndex = 10;
            // 
            // form_array
            // 
            this.form_array.Location = new System.Drawing.Point(72, 192);
            this.form_array.Name = "form_array";
            this.form_array.Size = new System.Drawing.Size(136, 47);
            this.form_array.TabIndex = 18;
            this.form_array.Text = "Сформировать массив";
            this.form_array.UseVisualStyleBackColor = true;
            this.form_array.Click += new System.EventHandler(this.Form_array_Click);
            // 
            // find_number
            // 
            this.find_number.Location = new System.Drawing.Point(72, 139);
            this.find_number.Name = "find_number";
            this.find_number.Size = new System.Drawing.Size(136, 47);
            this.find_number.TabIndex = 17;
            this.find_number.Text = "Найти номер";
            this.find_number.UseVisualStyleBackColor = true;
            this.find_number.Click += new System.EventHandler(this.Negativinlast_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(284, 177);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(240, 62);
            this.output.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 250);
            this.Controls.Add(this.output);
            this.Controls.Add(this.form_array);
            this.Controls.Add(this.find_number);
            this.Controls.Add(this.fill_matrix);
            this.Controls.Add(this.create_matrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_m);
            this.Controls.Add(this.input_n);
            this.Controls.Add(this.input);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fill_matrix;
        private System.Windows.Forms.Button create_matrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_m;
        private System.Windows.Forms.TextBox input_n;
        private System.Windows.Forms.DataGridView input;
        private System.Windows.Forms.Button form_array;
        private System.Windows.Forms.Button find_number;
        private System.Windows.Forms.TextBox output;
    }
}