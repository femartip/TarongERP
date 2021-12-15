
using TarongISW.Services;

namespace TarongISW.Presentation
{
    public partial class NewContractFrom
    {
        private ITarongISWService service;


        public NewContractFrom(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBankAccount = new System.Windows.Forms.TextBox();
            this.textBoxSNN = new System.Windows.Forms.TextBox();
            this.textBoxHired = new System.Windows.Forms.TextBox();
            this.dateTimePickerInitDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(253, 271);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(125, 31);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(137, 22);
            this.textBoxDNI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "SSN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hired:";
            // 
            // textBoxBankAccount
            // 
            this.textBoxBankAccount.Location = new System.Drawing.Point(125, 76);
            this.textBoxBankAccount.Name = "textBoxBankAccount";
            this.textBoxBankAccount.Size = new System.Drawing.Size(137, 22);
            this.textBoxBankAccount.TabIndex = 7;
            // 
            // textBoxSNN
            // 
            this.textBoxSNN.Location = new System.Drawing.Point(125, 117);
            this.textBoxSNN.Name = "textBoxSNN";
            this.textBoxSNN.Size = new System.Drawing.Size(137, 22);
            this.textBoxSNN.TabIndex = 9;
            // 
            // textBoxHired
            // 
            this.textBoxHired.Location = new System.Drawing.Point(125, 156);
            this.textBoxHired.Name = "textBoxHired";
            this.textBoxHired.Size = new System.Drawing.Size(137, 22);
            this.textBoxHired.TabIndex = 10;
            //this.textBoxHired.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dateTimePickerInitDate
            // 
            this.dateTimePickerInitDate.Location = new System.Drawing.Point(125, 196);
            this.dateTimePickerInitDate.Name = "dateTimePickerInitDate";
            this.dateTimePickerInitDate.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerInitDate.TabIndex = 11;
            // 
            // TarongISWApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 314);
            this.Controls.Add(this.dateTimePickerInitDate);
            this.Controls.Add(this.textBoxHired);
            this.Controls.Add(this.textBoxSNN);
            this.Controls.Add(this.textBoxBankAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "TarongISWApp";
            this.Text = "New Contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBankAccount;
        private System.Windows.Forms.TextBox textBoxSNN;
        private System.Windows.Forms.TextBox textBoxHired;
        private System.Windows.Forms.DateTimePicker dateTimePickerInitDate;
    }
}

