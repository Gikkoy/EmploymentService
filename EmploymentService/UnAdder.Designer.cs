namespace EmploymentService
{
    partial class UnAdder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AddVac = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_dosvid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_riven = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_BIRTH = new System.Windows.Forms.DateTimePicker();
            this.textBox_statusUn = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_addressUn = new System.Windows.Forms.TextBox();
            this.textBox_poshta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_phoneNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_PIB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_Specialty = new System.Windows.Forms.ComboBox();
            this.спеціальностіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBemploymentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBemploymentDataSet = new EmploymentService.DBemploymentDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.спеціальностіTableAdapter = new EmploymentService.DBemploymentDataSetTableAdapters.СпеціальностіTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBemploymentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBemploymentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker_Date);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_AddVac);
            this.panel2.Location = new System.Drawing.Point(88, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 239);
            this.panel2.TabIndex = 42;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(24, 110);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(376, 26);
            this.dateTimePicker_Date.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(20, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Дата постановки на облік";
            // 
            // btn_AddVac
            // 
            this.btn_AddVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddVac.Location = new System.Drawing.Point(517, 57);
            this.btn_AddVac.Name = "btn_AddVac";
            this.btn_AddVac.Size = new System.Drawing.Size(308, 128);
            this.btn_AddVac.TabIndex = 40;
            this.btn_AddVac.Text = "Зберегти";
            this.btn_AddVac.UseVisualStyleBackColor = true;
            this.btn_AddVac.Click += new System.EventHandler(this.btn_AddVac_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_dosvid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_riven);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker_BIRTH);
            this.panel1.Controls.Add(this.textBox_statusUn);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.textBox_addressUn);
            this.panel1.Controls.Add(this.textBox_poshta);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox_phoneNum);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_PIB);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox_Specialty);
            this.panel1.Location = new System.Drawing.Point(88, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 357);
            this.panel1.TabIndex = 41;
            // 
            // textBox_dosvid
            // 
            this.textBox_dosvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dosvid.Location = new System.Drawing.Point(491, 220);
            this.textBox_dosvid.Name = "textBox_dosvid";
            this.textBox_dosvid.Size = new System.Drawing.Size(386, 26);
            this.textBox_dosvid.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(487, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Досвід";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(487, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Рівень освіти";
            // 
            // textBox_riven
            // 
            this.textBox_riven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_riven.Location = new System.Drawing.Point(491, 49);
            this.textBox_riven.Name = "textBox_riven";
            this.textBox_riven.Size = new System.Drawing.Size(386, 26);
            this.textBox_riven.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Дата народження";
            // 
            // dateTimePicker_BIRTH
            // 
            this.dateTimePicker_BIRTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_BIRTH.Location = new System.Drawing.Point(14, 311);
            this.dateTimePicker_BIRTH.Name = "dateTimePicker_BIRTH";
            this.dateTimePicker_BIRTH.Size = new System.Drawing.Size(386, 26);
            this.dateTimePicker_BIRTH.TabIndex = 37;
            // 
            // textBox_statusUn
            // 
            this.textBox_statusUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_statusUn.Location = new System.Drawing.Point(14, 220);
            this.textBox_statusUn.Name = "textBox_statusUn";
            this.textBox_statusUn.Size = new System.Drawing.Size(284, 26);
            this.textBox_statusUn.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(329, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "Статус";
            // 
            // textBox_addressUn
            // 
            this.textBox_addressUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_addressUn.Location = new System.Drawing.Point(14, 168);
            this.textBox_addressUn.Name = "textBox_addressUn";
            this.textBox_addressUn.Size = new System.Drawing.Size(284, 26);
            this.textBox_addressUn.TabIndex = 47;
            // 
            // textBox_poshta
            // 
            this.textBox_poshta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_poshta.Location = new System.Drawing.Point(14, 119);
            this.textBox_poshta.Name = "textBox_poshta";
            this.textBox_poshta.Size = new System.Drawing.Size(284, 26);
            this.textBox_poshta.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(325, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Адреса";
            // 
            // textBox_phoneNum
            // 
            this.textBox_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_phoneNum.Location = new System.Drawing.Point(14, 74);
            this.textBox_phoneNum.Name = "textBox_phoneNum";
            this.textBox_phoneNum.Size = new System.Drawing.Size(284, 26);
            this.textBox_phoneNum.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(487, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Спеціальність";
            // 
            // textBox_PIB
            // 
            this.textBox_PIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PIB.Location = new System.Drawing.Point(14, 21);
            this.textBox_PIB.Name = "textBox_PIB";
            this.textBox_PIB.Size = new System.Drawing.Size(284, 26);
            this.textBox_PIB.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(331, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 46;
            this.label13.Text = "Пошта";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(312, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 45;
            this.label14.Text = "Телефон";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(346, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "ПІБ";
            // 
            // comboBox_Specialty
            // 
            this.comboBox_Specialty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Specialty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Specialty.DataSource = this.спеціальностіBindingSource;
            this.comboBox_Specialty.DisplayMember = "Назва";
            this.comboBox_Specialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Specialty.FormattingEnabled = true;
            this.comboBox_Specialty.Location = new System.Drawing.Point(491, 134);
            this.comboBox_Specialty.Name = "comboBox_Specialty";
            this.comboBox_Specialty.Size = new System.Drawing.Size(386, 28);
            this.comboBox_Specialty.TabIndex = 33;
            this.comboBox_Specialty.ValueMember = "Ід";
            // 
            // спеціальностіBindingSource
            // 
            this.спеціальностіBindingSource.DataMember = "Спеціальності";
            this.спеціальностіBindingSource.DataSource = this.dBemploymentDataSetBindingSource;
            // 
            // dBemploymentDataSetBindingSource
            // 
            this.dBemploymentDataSetBindingSource.DataSource = this.dBemploymentDataSet;
            this.dBemploymentDataSetBindingSource.Position = 0;
            // 
            // dBemploymentDataSet
            // 
            this.dBemploymentDataSet.DataSetName = "DBemploymentDataSet";
            this.dBemploymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(81, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(525, 39);
            this.label8.TabIndex = 39;
            this.label8.Text = "Додавання нового безробітного";
            // 
            // спеціальностіTableAdapter
            // 
            this.спеціальностіTableAdapter.ClearBeforeFill = true;
            // 
            // UnAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "UnAdder";
            this.Text = "UnAdder";
            this.Load += new System.EventHandler(this.UnAdder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBemploymentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBemploymentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Specialty;
        private System.Windows.Forms.Button btn_AddVac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_statusUn;
        private System.Windows.Forms.TextBox textBox_addressUn;
        private System.Windows.Forms.TextBox textBox_poshta;
        private System.Windows.Forms.TextBox textBox_phoneNum;
        private System.Windows.Forms.TextBox textBox_PIB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_riven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BIRTH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dBemploymentDataSetBindingSource;
        private DBemploymentDataSet dBemploymentDataSet;
        private System.Windows.Forms.BindingSource спеціальностіBindingSource;
        private DBemploymentDataSetTableAdapters.СпеціальностіTableAdapter спеціальностіTableAdapter;
        private System.Windows.Forms.TextBox textBox_dosvid;
    }
}