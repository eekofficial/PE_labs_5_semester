namespace Lab3_Korotaev
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
            this.input = new System.Windows.Forms.DataGridView();
            this.input_n = new System.Windows.Forms.TextBox();
            this.input_m = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.negativinlast = new System.Windows.Forms.Button();
            this.positivelines = new System.Windows.Forms.Button();
            this.create_matrix = new System.Windows.Forms.Button();
            this.fill_matrix = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input.Location = new System.Drawing.Point(495, 69);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(240, 150);
            this.input.TabIndex = 0;
            this.input.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Input_CellContentClick);
            // 
            // input_n
            // 
            this.input_n.Location = new System.Drawing.Point(321, 102);
            this.input_n.Name = "input_n";
            this.input_n.Size = new System.Drawing.Size(28, 20);
            this.input_n.TabIndex = 2;
            // 
            // input_m
            // 
            this.input_m.Location = new System.Drawing.Point(321, 161);
            this.input_m.Name = "input_m";
            this.input_m.Size = new System.Drawing.Size(28, 20);
            this.input_m.TabIndex = 3;
            this.input_m.TextChanged += new System.EventHandler(this.Input_m_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Строк";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Столбцов";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // negativinlast
            // 
            this.negativinlast.Location = new System.Drawing.Point(25, 319);
            this.negativinlast.Name = "negativinlast";
            this.negativinlast.Size = new System.Drawing.Size(183, 47);
            this.negativinlast.TabIndex = 6;
            this.negativinlast.Text = "Отрицательные в конец";
            this.negativinlast.UseVisualStyleBackColor = true;
            this.negativinlast.Click += new System.EventHandler(this.Negativinlast_Click);
            // 
            // positivelines
            // 
            this.positivelines.Location = new System.Drawing.Point(236, 319);
            this.positivelines.Name = "positivelines";
            this.positivelines.Size = new System.Drawing.Size(183, 47);
            this.positivelines.TabIndex = 7;
            this.positivelines.Text = "Вывести положительные строки";
            this.positivelines.UseVisualStyleBackColor = true;
            this.positivelines.Click += new System.EventHandler(this.Positivelines_Click);
            // 
            // create_matrix
            // 
            this.create_matrix.Location = new System.Drawing.Point(378, 102);
            this.create_matrix.Name = "create_matrix";
            this.create_matrix.Size = new System.Drawing.Size(79, 20);
            this.create_matrix.TabIndex = 8;
            this.create_matrix.Text = "Создать";
            this.create_matrix.UseVisualStyleBackColor = true;
            this.create_matrix.Click += new System.EventHandler(this.Input_matrix_Click);
            // 
            // fill_matrix
            // 
            this.fill_matrix.Location = new System.Drawing.Point(378, 160);
            this.fill_matrix.Name = "fill_matrix";
            this.fill_matrix.Size = new System.Drawing.Size(79, 20);
            this.fill_matrix.TabIndex = 9;
            this.fill_matrix.Text = "Заполнить";
            this.fill_matrix.UseVisualStyleBackColor = true;
            this.fill_matrix.Click += new System.EventHandler(this.Fill_matrix_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(495, 255);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(240, 150);
            this.output.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.fill_matrix);
            this.Controls.Add(this.create_matrix);
            this.Controls.Add(this.positivelines);
            this.Controls.Add(this.negativinlast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_m);
            this.Controls.Add(this.input_n);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView input;
        private System.Windows.Forms.TextBox input_n;
        private System.Windows.Forms.TextBox input_m;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button negativinlast;
        private System.Windows.Forms.Button positivelines;
        private System.Windows.Forms.Button create_matrix;
        private System.Windows.Forms.Button fill_matrix;
        private System.Windows.Forms.TextBox output;
    }
}

