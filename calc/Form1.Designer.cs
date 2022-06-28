namespace calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.additional = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // additional
            // 
            this.additional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.additional.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.additional.FlatAppearance.BorderSize = 2;
            this.additional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additional.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.additional.Location = new System.Drawing.Point(12, 117);
            this.additional.Name = "additional";
            this.additional.Size = new System.Drawing.Size(56, 56);
            this.additional.TabIndex = 0;
            this.additional.Text = "+";
            this.additional.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.additional.UseVisualStyleBackColor = false;
            this.additional.Click += new System.EventHandler(this.OperationClick);
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.first.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.ForeColor = System.Drawing.Color.White;
            this.first.Location = new System.Drawing.Point(12, 49);
            this.first.MaxLength = 4;
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(88, 39);
            this.first.TabIndex = 1;
            this.first.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.second.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.second.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.ForeColor = System.Drawing.Color.White;
            this.second.Location = new System.Drawing.Point(118, 49);
            this.second.MaxLength = 4;
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(88, 39);
            this.second.TabIndex = 2;
            this.second.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(64)))));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Cursor = System.Windows.Forms.Cursors.No;
            this.result.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(232, 49);
            this.result.MaxLength = 6;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(88, 39);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subtraction.FlatAppearance.BorderSize = 2;
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtraction.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.subtraction.Location = new System.Drawing.Point(89, 117);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(56, 56);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.OperationClick);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.multiplication.FlatAppearance.BorderSize = 2;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.multiplication.Location = new System.Drawing.Point(168, 117);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(56, 56);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.OperationClick);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.division.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.division.FlatAppearance.BorderSize = 2;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.division.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.division.Location = new System.Drawing.Point(247, 117);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(56, 56);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.OperationClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(232, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Result";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(333, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.result);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.additional);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button additional;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
    }
}

