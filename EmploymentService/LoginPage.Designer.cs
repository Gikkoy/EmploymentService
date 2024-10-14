namespace EmploymentService
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pictureBox2_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1_open = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_open)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторінка входу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(260, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вхід";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(270, 233);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(259, 36);
            this.textBox_login.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(264, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Логін";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(268, 340);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(259, 36);
            this.textBox_password.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(264, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пароль";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Login.Location = new System.Drawing.Point(268, 402);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(259, 62);
            this.btn_Login.TabIndex = 13;
            this.btn_Login.Text = "Підтвердити вхід";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(332, 480);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ще нема в системі?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clear.Location = new System.Drawing.Point(680, 9);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Clear.Size = new System.Drawing.Size(116, 74);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "Очистити форму";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pictureBox2_close
            // 
            this.pictureBox2_close.Image = global::EmploymentService.Properties.Resources.imgonline_com_ua_Resize_TIJJ1UVmQH03t;
            this.pictureBox2_close.InitialImage = null;
            this.pictureBox2_close.Location = new System.Drawing.Point(546, 340);
            this.pictureBox2_close.Name = "pictureBox2_close";
            this.pictureBox2_close.Size = new System.Drawing.Size(64, 36);
            this.pictureBox2_close.TabIndex = 17;
            this.pictureBox2_close.TabStop = false;
            this.pictureBox2_close.Click += new System.EventHandler(this.pictureBox2_close_Click);
            // 
            // pictureBox1_open
            // 
            this.pictureBox1_open.Image = global::EmploymentService.Properties.Resources.openEye1;
            this.pictureBox1_open.InitialImage = null;
            this.pictureBox1_open.Location = new System.Drawing.Point(546, 340);
            this.pictureBox1_open.Name = "pictureBox1_open";
            this.pictureBox1_open.Size = new System.Drawing.Size(64, 36);
            this.pictureBox1_open.TabIndex = 16;
            this.pictureBox1_open.TabStop = false;
            this.pictureBox1_open.Click += new System.EventHandler(this.pictureBox1_open_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 632);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pictureBox2_close);
            this.Controls.Add(this.pictureBox1_open);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.Text = "Employment Service";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1_open;
        private System.Windows.Forms.PictureBox pictureBox2_close;
        private System.Windows.Forms.Button btn_Clear;
    }
}

