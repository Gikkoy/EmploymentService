namespace EmploymentService
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1_open = new System.Windows.Forms.PictureBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_login2 = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_open)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(301, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Реєстрація";
            // 
            // pictureBox2_close
            // 
            this.pictureBox2_close.Image = global::EmploymentService.Properties.Resources.imgonline_com_ua_Resize_TIJJ1UVmQH03t;
            this.pictureBox2_close.InitialImage = null;
            this.pictureBox2_close.Location = new System.Drawing.Point(551, 277);
            this.pictureBox2_close.Name = "pictureBox2_close";
            this.pictureBox2_close.Size = new System.Drawing.Size(64, 36);
            this.pictureBox2_close.TabIndex = 26;
            this.pictureBox2_close.TabStop = false;
            this.pictureBox2_close.Click += new System.EventHandler(this.pictureBox2_close_Click);
            // 
            // pictureBox1_open
            // 
            this.pictureBox1_open.Image = global::EmploymentService.Properties.Resources.openEye1;
            this.pictureBox1_open.InitialImage = null;
            this.pictureBox1_open.Location = new System.Drawing.Point(551, 277);
            this.pictureBox1_open.Name = "pictureBox1_open";
            this.pictureBox1_open.Size = new System.Drawing.Size(64, 36);
            this.pictureBox1_open.TabIndex = 25;
            this.pictureBox1_open.TabStop = false;
            this.pictureBox1_open.Click += new System.EventHandler(this.pictureBox1_open_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Register.Location = new System.Drawing.Point(273, 369);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(259, 62);
            this.btn_Register.TabIndex = 23;
            this.btn_Register.Text = "Створити акаунт";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(269, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Пароль";
            // 
            // textBox_password2
            // 
            this.textBox_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password2.Location = new System.Drawing.Point(273, 277);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(259, 36);
            this.textBox_password2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(269, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Логін";
            // 
            // textBox_login2
            // 
            this.textBox_login2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login2.Location = new System.Drawing.Point(275, 170);
            this.textBox_login2.Name = "textBox_login2";
            this.textBox_login2.Size = new System.Drawing.Size(259, 36);
            this.textBox_login2.TabIndex = 19;
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clear.Location = new System.Drawing.Point(742, 12);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Clear.Size = new System.Drawing.Size(116, 74);
            this.btn_Clear.TabIndex = 27;
            this.btn_Clear.Text = "Очистити форму";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 552);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pictureBox2_close);
            this.Controls.Add(this.pictureBox1_open);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_login2);
            this.Controls.Add(this.label3);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2_close;
        private System.Windows.Forms.PictureBox pictureBox1_open;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_login2;
        private System.Windows.Forms.Button btn_Clear;
    }
}