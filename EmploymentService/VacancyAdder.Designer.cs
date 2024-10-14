namespace EmploymentService
{
    partial class VacancyAdder
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
            this.components = new System.ComponentModel.Container();
            this.textBox_Tip = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Req = new System.Windows.Forms.TextBox();
            this.textBox_Descr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddVac = new System.Windows.Forms.Button();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Specialty = new System.Windows.Forms.ComboBox();
            this.comboBox_Employer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dBemploymentDataSet = new EmploymentService.DBemploymentDataSet();
            this.спеціальностіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спеціальностіTableAdapter = new EmploymentService.DBemploymentDataSetTableAdapters.СпеціальностіTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBemploymentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Tip
            // 
            this.textBox_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Tip.Location = new System.Drawing.Point(575, 176);
            this.textBox_Tip.Name = "textBox_Tip";
            this.textBox_Tip.Size = new System.Drawing.Size(276, 26);
            this.textBox_Tip.TabIndex = 24;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Status.Location = new System.Drawing.Point(575, 127);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(276, 26);
            this.textBox_Status.TabIndex = 23;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Salary.Location = new System.Drawing.Point(575, 82);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(276, 26);
            this.textBox_Salary.TabIndex = 22;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(575, 29);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(276, 26);
            this.textBox_Name.TabIndex = 21;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Address.Location = new System.Drawing.Point(575, 220);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(276, 26);
            this.textBox_Address.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(422, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Тип зайнятості";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(490, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(467, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Зарплата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(497, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(486, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Адреса";
            // 
            // textBox_Req
            // 
            this.textBox_Req.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Req.Location = new System.Drawing.Point(262, 36);
            this.textBox_Req.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textBox_Req.MinimumSize = new System.Drawing.Size(200, 200);
            this.textBox_Req.Multiline = true;
            this.textBox_Req.Name = "textBox_Req";
            this.textBox_Req.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Req.Size = new System.Drawing.Size(274, 240);
            this.textBox_Req.TabIndex = 25;
            // 
            // textBox_Descr
            // 
            this.textBox_Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Descr.Location = new System.Drawing.Point(14, 147);
            this.textBox_Descr.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textBox_Descr.MinimumSize = new System.Drawing.Size(100, 100);
            this.textBox_Descr.Multiline = true;
            this.textBox_Descr.Name = "textBox_Descr";
            this.textBox_Descr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Descr.Size = new System.Drawing.Size(386, 197);
            this.textBox_Descr.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(465, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Вимоги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "ОПИС ВАКАНСІЇ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(29, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(420, 39);
            this.label8.TabIndex = 29;
            this.label8.Text = "Додавання нової вакансії";
            // 
            // btn_AddVac
            // 
            this.btn_AddVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddVac.Location = new System.Drawing.Point(36, 559);
            this.btn_AddVac.Name = "btn_AddVac";
            this.btn_AddVac.Size = new System.Drawing.Size(308, 128);
            this.btn_AddVac.TabIndex = 30;
            this.btn_AddVac.Text = "Зберегти";
            this.btn_AddVac.UseVisualStyleBackColor = true;
            this.btn_AddVac.Click += new System.EventHandler(this.btn_AddVac_Click);
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(20, 189);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(211, 26);
            this.dateTimePicker_Date.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Дата додавання";
            // 
            // comboBox_Specialty
            // 
            this.comboBox_Specialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Specialty.FormattingEnabled = true;
            this.comboBox_Specialty.Location = new System.Drawing.Point(14, 52);
            this.comboBox_Specialty.Name = "comboBox_Specialty";
            this.comboBox_Specialty.Size = new System.Drawing.Size(386, 28);
            this.comboBox_Specialty.TabIndex = 33;
            // 
            // comboBox_Employer
            // 
            this.comboBox_Employer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Employer.FormattingEnabled = true;
            this.comboBox_Employer.Location = new System.Drawing.Point(20, 36);
            this.comboBox_Employer.Name = "comboBox_Employer";
            this.comboBox_Employer.Size = new System.Drawing.Size(211, 28);
            this.comboBox_Employer.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Спеціальність";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Роботодавець";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Descr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_Address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_Specialty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_Salary);
            this.panel1.Controls.Add(this.textBox_Status);
            this.panel1.Controls.Add(this.textBox_Tip);
            this.panel1.Location = new System.Drawing.Point(36, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 357);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_Req);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker_Date);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboBox_Employer);
            this.panel2.Location = new System.Drawing.Point(388, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 279);
            this.panel2.TabIndex = 38;
            // 
            // dBemploymentDataSet
            // 
            this.dBemploymentDataSet.DataSetName = "DBemploymentDataSet";
            this.dBemploymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // спеціальностіBindingSource
            // 
            this.спеціальностіBindingSource.DataMember = "Спеціальності";
            this.спеціальностіBindingSource.DataSource = this.dBemploymentDataSet;
            // 
            // спеціальностіTableAdapter
            // 
            this.спеціальностіTableAdapter.ClearBeforeFill = true;
            // 
            // VacancyAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 771);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AddVac);
            this.Controls.Add(this.label8);
            this.Name = "VacancyAdder";
            this.Text = "VacancyAdder";
            this.Load += new System.EventHandler(this.VacancyAdder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBemploymentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Tip;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Req;
        private System.Windows.Forms.TextBox textBox_Descr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_AddVac;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Specialty;
        private System.Windows.Forms.ComboBox comboBox_Employer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DBemploymentDataSet dBemploymentDataSet;
        private System.Windows.Forms.BindingSource спеціальностіBindingSource;
        private DBemploymentDataSetTableAdapters.СпеціальностіTableAdapter спеціальностіTableAdapter;
    }
}