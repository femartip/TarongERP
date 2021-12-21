
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerFinalDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerInitDate2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.buttonAddPerm = new System.Windows.Forms.Button();
            this.textBoxSSN2 = new System.Windows.Forms.TextBox();
            this.textBoxBankAccount2 = new System.Windows.Forms.TextBox();
            this.textBoxDNI2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButtonTemp
            // 
            this.addButtonTemp.Location = new System.Drawing.Point(358, 271);
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
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(125, 6);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(137, 22);
            this.textBoxDNI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "SSN:";
            // 
            // textBoxBankAccount
            // 
            this.textBoxBankAccount.Location = new System.Drawing.Point(125, 52);
            this.textBoxBankAccount.Name = "textBoxBankAccount";
            this.textBoxBankAccount.Size = new System.Drawing.Size(137, 22);
            this.textBoxBankAccount.TabIndex = 7;
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(125, 105);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(137, 22);
            this.textBoxSSN.TabIndex = 9;
            // 
            // dateTimePickerInitDate
            // 
            this.dateTimePickerInitDate.Location = new System.Drawing.Point(125, 153);
            this.dateTimePickerInitDate.Name = "dateTimePickerInitDate";
            this.dateTimePickerInitDate.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerInitDate.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 343);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dateTimePickerFinalDate);
            this.tabPage1.Controls.Add(this.addButtonTemp);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxDNI);
            this.tabPage1.Controls.Add(this.dateTimePickerInitDate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxSSN);
            this.tabPage1.Controls.Add(this.textBoxBankAccount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Temporary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "AddPerson";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.goAddPerson_Click);
            // 
            // dateTimePickerFinalDate
            // 
            this.dateTimePickerFinalDate.Location = new System.Drawing.Point(125, 200);
            this.dateTimePickerFinalDate.Name = "dateTimePickerFinalDate";
            this.dateTimePickerFinalDate.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerFinalDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Final Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dateTimePickerInitDate2);
            this.tabPage2.Controls.Add(this.textBoxSalary);
            this.tabPage2.Controls.Add(this.buttonAddPerm);
            this.tabPage2.Controls.Add(this.textBoxSSN2);
            this.tabPage2.Controls.Add(this.textBoxBankAccount2);
            this.tabPage2.Controls.Add(this.textBoxDNI2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Permanent";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "AddPerson";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.goAddPerson_Click);
            // 
            // dateTimePickerInitDate2
            // 
            this.dateTimePickerInitDate2.Location = new System.Drawing.Point(125, 210);
            this.dateTimePickerInitDate2.Name = "dateTimePickerInitDate2";
            this.dateTimePickerInitDate2.Size = new System.Drawing.Size(226, 22);
            this.dateTimePickerInitDate2.TabIndex = 14;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(125, 162);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(137, 22);
            this.textBoxSalary.TabIndex = 13;
            // 
            // buttonAddPerm
            // 
            this.buttonAddPerm.Location = new System.Drawing.Point(358, 271);
            this.buttonAddPerm.Name = "buttonAddPerm";
            this.buttonAddPerm.Size = new System.Drawing.Size(102, 35);
            this.buttonAddPerm.TabIndex = 12;
            this.buttonAddPerm.Text = "Add";
            this.buttonAddPerm.UseVisualStyleBackColor = true;
            this.buttonAddPerm.Click += new System.EventHandler(this.addButtonPerm_Click);
            // 
            // textBoxSSN2
            // 
            this.textBoxSSN2.Location = new System.Drawing.Point(125, 116);
            this.textBoxSSN2.Name = "textBoxSSN2";
            this.textBoxSSN2.Size = new System.Drawing.Size(137, 22);
            this.textBoxSSN2.TabIndex = 11;
            // 
            // textBoxBankAccount2
            // 
            this.textBoxBankAccount2.Location = new System.Drawing.Point(125, 63);
            this.textBoxBankAccount2.Name = "textBoxBankAccount2";
            this.textBoxBankAccount2.Size = new System.Drawing.Size(137, 22);
            this.textBoxBankAccount2.TabIndex = 10;
            // 
            // textBoxDNI2
            // 
            this.textBoxDNI2.Location = new System.Drawing.Point(125, 5);
            this.textBoxDNI2.Name = "textBoxDNI2";
            this.textBoxDNI2.Size = new System.Drawing.Size(137, 22);
            this.textBoxDNI2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Salary:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Initial Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "SSN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bank Account:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "DNI:";
            // 
            // NewContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewContractForm";
            this.Text = "New Contract";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinalDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxSSN2;
        private System.Windows.Forms.TextBox textBoxBankAccount2;
        private System.Windows.Forms.TextBox textBoxDNI2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddPerm;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.DateTimePicker dateTimePickerInitDate2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

