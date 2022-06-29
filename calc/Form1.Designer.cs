namespace calc
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.additional = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.lg = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // additional
            // 
            this.additional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.additional.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.additional.FlatAppearance.BorderSize = 2;
            this.additional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additional.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additional.Location = new System.Drawing.Point(12, 108);
            this.additional.Name = "additional";
            this.additional.Size = new System.Drawing.Size(56, 56);
            this.additional.TabIndex = 0;
            this.additional.Text = "+";
            this.additional.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.additional.UseVisualStyleBackColor = false;
            this.additional.Click += new System.EventHandler(this.Operation_Click);
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.first.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.ForeColor = System.Drawing.Color.White;
            this.first.Location = new System.Drawing.Point(12, 34);
            this.first.MaxLength = 5;
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(88, 39);
            this.first.TabIndex = 1;
            this.first.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.second.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.second.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.ForeColor = System.Drawing.Color.White;
            this.second.Location = new System.Drawing.Point(115, 34);
            this.second.MaxLength = 5;
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(88, 39);
            this.second.TabIndex = 2;
            this.second.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(64)))));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Cursor = System.Windows.Forms.Cursors.No;
            this.result.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(222, 34);
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
            this.subtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.subtraction.FlatAppearance.BorderSize = 2;
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtraction.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtraction.Location = new System.Drawing.Point(89, 108);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(56, 56);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.Operation_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.multiplication.FlatAppearance.BorderSize = 2;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(174, 108);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(56, 56);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.Operation_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.division.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.division.FlatAppearance.BorderSize = 2;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.division.Location = new System.Drawing.Point(254, 108);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(56, 56);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.Operation_Click);
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.exp.FlatAppearance.BorderSize = 2;
            this.exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exp.Location = new System.Drawing.Point(12, 190);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(56, 56);
            this.exp.TabIndex = 11;
            this.exp.Text = "^";
            this.exp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exp.UseVisualStyleBackColor = false;
            // 
            // logxy
            // 
            this.logxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logxy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.logxy.FlatAppearance.BorderSize = 2;
            this.logxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logxy.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.logxy.Image = ((System.Drawing.Image)(resources.GetObject("logxy.Image")));
            this.logxy.Location = new System.Drawing.Point(12, 274);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(56, 56);
            this.logxy.TabIndex = 12;
            this.logxy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logxy.UseVisualStyleBackColor = false;
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.sin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.sin.FlatAppearance.BorderSize = 2;
            this.sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sin.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.sin.Image = ((System.Drawing.Image)(resources.GetObject("sin.Image")));
            this.sin.Location = new System.Drawing.Point(12, 358);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(56, 56);
            this.sin.TabIndex = 13;
            this.sin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sin.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(70)))), ((int)(((byte)(34)))));
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.clear.FlatAppearance.BorderSize = 2;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear.Location = new System.Drawing.Point(89, 190);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(141, 140);
            this.clear.TabIndex = 22;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.lg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.lg.FlatAppearance.BorderSize = 2;
            this.lg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lg.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.lg.Image = ((System.Drawing.Image)(resources.GetObject("lg.Image")));
            this.lg.Location = new System.Drawing.Point(254, 190);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(56, 56);
            this.lg.TabIndex = 23;
            this.lg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lg.UseVisualStyleBackColor = false;
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.ln.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.ln.FlatAppearance.BorderSize = 2;
            this.ln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ln.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.ln.Image = ((System.Drawing.Image)(resources.GetObject("ln.Image")));
            this.ln.Location = new System.Drawing.Point(254, 274);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(56, 56);
            this.ln.TabIndex = 24;
            this.ln.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ln.UseVisualStyleBackColor = false;
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.cos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.cos.FlatAppearance.BorderSize = 2;
            this.cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cos.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.cos.Image = ((System.Drawing.Image)(resources.GetObject("cos.Image")));
            this.cos.Location = new System.Drawing.Point(89, 358);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(56, 56);
            this.cos.TabIndex = 25;
            this.cos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cos.UseVisualStyleBackColor = false;
            // 
            // tg
            // 
            this.tg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.tg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.tg.FlatAppearance.BorderSize = 2;
            this.tg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tg.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.tg.Image = ((System.Drawing.Image)(resources.GetObject("tg.Image")));
            this.tg.Location = new System.Drawing.Point(174, 358);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(56, 56);
            this.tg.TabIndex = 26;
            this.tg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tg.UseVisualStyleBackColor = false;
            // 
            // ctg
            // 
            this.ctg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.ctg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.ctg.FlatAppearance.BorderSize = 2;
            this.ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctg.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.ctg.Image = ((System.Drawing.Image)(resources.GetObject("ctg.Image")));
            this.ctg.Location = new System.Drawing.Point(254, 358);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(56, 56);
            this.ctg.TabIndex = 27;
            this.ctg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ctg.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(153, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(235, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = " Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(49, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "X";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(322, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.logxy);
            this.Controls.Add(this.exp);
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
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calculator";
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
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button lg;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

