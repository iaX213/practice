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
            this.plus = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.umn = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.plus.FlatAppearance.BorderSize = 2;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.plus.Location = new System.Drawing.Point(12, 117);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(56, 56);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
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
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minus.FlatAppearance.BorderSize = 2;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.minus.Location = new System.Drawing.Point(89, 117);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(56, 56);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // umn
            // 
            this.umn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.umn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.umn.FlatAppearance.BorderSize = 2;
            this.umn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.umn.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.umn.Location = new System.Drawing.Point(168, 117);
            this.umn.Name = "umn";
            this.umn.Size = new System.Drawing.Size(56, 56);
            this.umn.TabIndex = 5;
            this.umn.Text = "*";
            this.umn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.umn.UseVisualStyleBackColor = false;
            this.umn.Click += new System.EventHandler(this.umn_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.del.FlatAppearance.BorderSize = 2;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del.Location = new System.Drawing.Point(247, 117);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(56, 56);
            this.del.TabIndex = 6;
            this.del.Text = "/";
            this.del.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(333, 418);
            this.Controls.Add(this.del);
            this.Controls.Add(this.umn);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.plus);
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

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button umn;
        private System.Windows.Forms.Button del;
    }
}

