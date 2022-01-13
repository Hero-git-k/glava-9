
namespace AfanasevGlava9
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
            this.butProcCount_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.butCheckOS_Click = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.butDetectBitVersion_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butProcCount_Click
            // 
            this.butProcCount_Click.Location = new System.Drawing.Point(28, 21);
            this.butProcCount_Click.Name = "butProcCount_Click";
            this.butProcCount_Click.Size = new System.Drawing.Size(111, 60);
            this.butProcCount_Click.TabIndex = 0;
            this.butProcCount_Click.Text = "Узнать число процессоров в системе";
            this.butProcCount_Click.UseVisualStyleBackColor = true;
            this.butProcCount_Click.Click += new System.EventHandler(this.butProcCount_Click_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Второй способ узнать число процессоров";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Приостановить выполнение программы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Получить список всех процессов,\r\nзапущенных в системе\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 301);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 368);
            this.listBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 75);
            this.button4.TabIndex = 5;
            this.button4.Text = "Получение списка определенных процессов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // butCheckOS_Click
            // 
            this.butCheckOS_Click.Location = new System.Drawing.Point(145, 102);
            this.butCheckOS_Click.Name = "butCheckOS_Click";
            this.butCheckOS_Click.Size = new System.Drawing.Size(111, 60);
            this.butCheckOS_Click.TabIndex = 6;
            this.butCheckOS_Click.Text = "Исправленная версия проверки операционной системы";
            this.butCheckOS_Click.UseVisualStyleBackColor = true;
            this.butCheckOS_Click.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(145, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 60);
            this.button5.TabIndex = 7;
            this.button5.Text = "Получение информации об исполняемом файле ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // butDetectBitVersion_Click
            // 
            this.butDetectBitVersion_Click.Location = new System.Drawing.Point(145, 234);
            this.butDetectBitVersion_Click.Name = "butDetectBitVersion_Click";
            this.butDetectBitVersion_Click.Size = new System.Drawing.Size(111, 60);
            this.butDetectBitVersion_Click.TabIndex = 8;
            this.butDetectBitVersion_Click.Text = "Определение архитектуры операционной системы";
            this.butDetectBitVersion_Click.UseVisualStyleBackColor = true;
            this.butDetectBitVersion_Click.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 682);
            this.Controls.Add(this.butDetectBitVersion_Click);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.butCheckOS_Click);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butProcCount_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butProcCount_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button butCheckOS_Click;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button butDetectBitVersion_Click;
    }
}

