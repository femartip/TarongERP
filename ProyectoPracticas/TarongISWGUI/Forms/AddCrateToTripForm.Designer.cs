
using TarongISW.Services;

namespace TarongISW.Presentation
{
    public partial class AddCrateToTripForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddCrateToTrip = new System.Windows.Forms.Button();
            this.textBoxParcel = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxPN = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.buttonParcel = new System.Windows.Forms.Button();
            this.buttonDNI = new System.Windows.Forms.Button();
            this.buttonPN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parcel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plate Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight:";
            // 
            // buttonAddCrateToTrip
            // 
            this.buttonAddCrateToTrip.Location = new System.Drawing.Point(269, 271);
            this.buttonAddCrateToTrip.Name = "buttonAddCrateToTrip";
            this.buttonAddCrateToTrip.Size = new System.Drawing.Size(89, 31);
            this.buttonAddCrateToTrip.TabIndex = 5;
            this.buttonAddCrateToTrip.Text = "Add";
            this.buttonAddCrateToTrip.UseVisualStyleBackColor = true;
            this.buttonAddCrateToTrip.Click += new System.EventHandler(this.addCrateToTrip_Click);
            // 
            // textBoxParcel
            // 
            this.textBoxParcel.Location = new System.Drawing.Point(168, 24);
            this.textBoxParcel.Name = "textBoxParcel";
            this.textBoxParcel.Size = new System.Drawing.Size(121, 22);
            this.textBoxParcel.TabIndex = 6;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(168, 71);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(121, 22);
            this.textBoxDNI.TabIndex = 7;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.validDNI);
            // 
            // textBoxPN
            // 
            this.textBoxPN.Location = new System.Drawing.Point(168, 124);
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(121, 22);
            this.textBoxPN.TabIndex = 8;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(168, 212);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 22);
            this.textBoxWeight.TabIndex = 9;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(168, 175);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProduct.TabIndex = 10;
            // 
            // buttonParcel
            // 
            this.buttonParcel.Location = new System.Drawing.Point(295, 23);
            this.buttonParcel.Name = "buttonParcel";
            this.buttonParcel.Size = new System.Drawing.Size(26, 23);
            this.buttonParcel.TabIndex = 11;
            this.buttonParcel.Text = "✓";
            this.buttonParcel.UseVisualStyleBackColor = true;
            this.buttonParcel.Click += new System.EventHandler(this.validParcel);
            // 
            // buttonDNI
            // 
            this.buttonDNI.Location = new System.Drawing.Point(295, 71);
            this.buttonDNI.Name = "buttonDNI";
            this.buttonDNI.Size = new System.Drawing.Size(26, 23);
            this.buttonDNI.TabIndex = 12;
            this.buttonDNI.Text = "✓";
            this.buttonDNI.UseVisualStyleBackColor = true;
            this.buttonDNI.Click += new System.EventHandler(this.validDNI);
            // 
            // buttonPN
            // 
            this.buttonPN.Location = new System.Drawing.Point(295, 124);
            this.buttonPN.Name = "buttonPN";
            this.buttonPN.Size = new System.Drawing.Size(26, 23);
            this.buttonPN.TabIndex = 13;
            this.buttonPN.Text = "✓";
            this.buttonPN.UseVisualStyleBackColor = true;
            this.buttonPN.Click += new System.EventHandler(this.validPN);
            // 
            // AddCrateToTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 314);
            this.Controls.Add(this.buttonPN);
            this.Controls.Add(this.buttonDNI);
            this.Controls.Add(this.buttonParcel);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxPN);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxParcel);
            this.Controls.Add(this.buttonAddCrateToTrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCrateToTripForm";
            this.Text = "AddCrateToTrip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddCrateToTrip;
        private System.Windows.Forms.TextBox textBoxParcel;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxPN;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button buttonParcel;
        private System.Windows.Forms.Button buttonDNI;
        private System.Windows.Forms.Button buttonPN;
    }
}

