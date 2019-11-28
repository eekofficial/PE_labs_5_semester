namespace Lab6_PE_Korotaev
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
            this.show = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.show_all = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.add_last = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.task_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.service_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.TextBox();
            this.region = new System.Windows.Forms.TextBox();
            this.head = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(20, 219);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(108, 23);
            this.show.TabIndex = 0;
            this.show.Text = "Показать";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(20, 248);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(108, 23);
            this.previous.TabIndex = 1;
            this.previous.Text = "Предыдущий";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(20, 277);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(108, 23);
            this.next.TabIndex = 2;
            this.next.Text = "Следующий";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // show_all
            // 
            this.show_all.Location = new System.Drawing.Point(20, 306);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(108, 23);
            this.show_all.TabIndex = 3;
            this.show_all.Text = "Показать все";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(149, 219);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(108, 23);
            this.change.TabIndex = 4;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(149, 248);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // add_last
            // 
            this.add_last.Location = new System.Drawing.Point(149, 277);
            this.add_last.Name = "add_last";
            this.add_last.Size = new System.Drawing.Size(108, 23);
            this.add_last.TabIndex = 6;
            this.add_last.Text = "Добавить в конец";
            this.add_last.UseVisualStyleBackColor = true;
            this.add_last.Click += new System.EventHandler(this.add_last_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(149, 306);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 23);
            this.delete.TabIndex = 7;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(440, 277);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(128, 52);
            this.run.TabIndex = 8;
            this.run.Text = "Выполнить задание";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // task_box
            // 
            this.task_box.Location = new System.Drawing.Point(313, 34);
            this.task_box.Multiline = true;
            this.task_box.Name = "task_box";
            this.task_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.task_box.Size = new System.Drawing.Size(375, 237);
            this.task_box.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Окно служебных сообщений";
            // 
            // service_box
            // 
            this.service_box.Location = new System.Drawing.Point(12, 34);
            this.service_box.Multiline = true;
            this.service_box.Name = "service_box";
            this.service_box.Size = new System.Drawing.Size(267, 54);
            this.service_box.TabIndex = 11;
            this.service_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Окно задания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество элементов в списке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Индекс элемента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Округ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Глава администрации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Площадь зеленых насаждений";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(187, 95);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(41, 20);
            this.count.TabIndex = 18;
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(117, 116);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(40, 20);
            this.index.TabIndex = 19;
            // 
            // region
            // 
            this.region.Location = new System.Drawing.Point(57, 139);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(100, 20);
            this.region.TabIndex = 20;
            this.region.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // head
            // 
            this.head.Location = new System.Drawing.Point(134, 161);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(112, 20);
            this.head.TabIndex = 21;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(179, 187);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(38, 20);
            this.area.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 334);
            this.Controls.Add(this.area);
            this.Controls.Add(this.head);
            this.Controls.Add(this.region);
            this.Controls.Add(this.index);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.service_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_box);
            this.Controls.Add(this.run);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add_last);
            this.Controls.Add(this.add);
            this.Controls.Add(this.change);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button add_last;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox task_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox service_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox region;
        private System.Windows.Forms.TextBox head;
        private System.Windows.Forms.TextBox area;
    }
}

