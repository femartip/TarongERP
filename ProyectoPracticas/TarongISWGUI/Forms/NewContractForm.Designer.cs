
using TarongISW.Services;

namespace TarongISW.Presentation
{
    public partial class NewContractForm
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
            this.addButtonTemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBankAccount = new System.Windows.Forms.TextBox();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.dateTimePickerInitDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerFinalDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.RadioButton();
            this.perm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // addButtonTemp
            // 
            this.addButtonTemp.Location = new System.Drawing.Point(364, 297);
            this.addButtonTemp.Name = "addButtonTemp";
            this.addButtonTemp.Size = new System.Drawing.Size(102, 35);
            this.addButtonTemp.TabIndex = 0;
            this.addButtonTemp.Text = "Add";
            this.addButtonTemp.UseVisualStyleBackColor = true;
            this.addButtonTemp.Click += new System.EventHandler(this.addButtonTemp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(131, 19);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(137, 22);
            this.textBoxDNI.TabIndex = 2;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.DNIValido);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "SSN:";
            // 
            // textBoxBankAccount
            // 
            this.textBoxBankAccount.Location = new System.Drawing.Point(131, 97);
            this.textBoxBankAccount.Name = "textBoxBankAccount";
            this.textBoxBankAccount.Size = new System.Drawing.Size(137, 22);
            this.textBoxBankAccount.TabIndex = 7;
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(131, 140);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(137, 22);
            this.textBoxSSN.TabIndex = 9;
            // 
            // dateTimePickerInitDate
            // 
            this.dateTimePickerInitDate.Location = new System.Drawing.Point(131, 215);
            this.dateTimePickerInitDate.Name = "dateTimePickerInitDate";
            this.dateTimePickerInitDate.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerInitDate.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "AddPerson";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.goAddPerson_Click);
            // 
            // dateTimePickerFinalDate
            // 
            this.dateTimePickerFinalDate.Location = new System.Drawing.Point(131, 255);
            this.dateTimePickerFinalDate.Name = "dateTimePickerFinalDate";
            this.dateTimePickerFinalDate.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerFinalDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Final Date:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(131, 178);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(137, 22);
            this.textBoxSalary.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type:";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(131, 62);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(98, 21);
            this.temp.TabIndex = 17;
            this.temp.TabStop = true;
            this.temp.Text = "Temporary";
            this.temp.UseVisualStyleBackColor = true;
            this.temp.Click += new System.EventHandler(this.isTemporary);
            // 
            // perm
            // 
            this.perm.AutoSize = true;
            this.perm.Location = new System.Drawing.Point(234, 62);
            this.perm.Name = "perm";
            this.perm.Size = new System.Drawing.Size(98, 21);
            this.perm.TabIndex = 18;
            this.perm.TabStop = true;
            this.perm.Text = "Permanent";
            this.perm.UseVisualStyleBackColor = true;
            this.perm.Click += new System.EventHandler(this.isPermanent);
            // 
            // NewContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.perm);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFinalDate);
            this.Controls.Add(this.addButtonTemp);
            this.Controls.Add(this.textBoxBankAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerInitDate);
            this.Controls.Add(this.textBoxSSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "NewContractForm";
            this.Text = "New Contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButtonTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBankAccount;
        private System.Windows.Forms.TextBox textBoxSSN;
        private System.Windows.Forms.DateTimePicker dateTimePickerInitDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinalDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton temp;
        private System.Windows.Forms.RadioButton perm;
    }
}

