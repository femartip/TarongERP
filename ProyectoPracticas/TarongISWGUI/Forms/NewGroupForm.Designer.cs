using TarongISW.Services;
namespace TarongISW.Presentation
{
    partial class NewGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ITarongISWService service;

        public NewGroupForm(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

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
            this.Parcela_label = new System.Windows.Forms.Label();
            this.Miembros_label = new System.Windows.Forms.Label();
            this.Miembros_listBox = new System.Windows.Forms.ListBox();
            this.Parcela_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Parcela_label
            // 
            this.Parcela_label.AutoSize = true;
            this.Parcela_label.Location = new System.Drawing.Point(90, 97);
            this.Parcela_label.Name = "Parcela_label";
            this.Parcela_label.Size = new System.Drawing.Size(55, 16);
            this.Parcela_label.TabIndex = 0;
            this.Parcela_label.Text = "Parcela";
            // 
            // Miembros_label
            // 
            this.Miembros_label.AutoSize = true;
            this.Miembros_label.Location = new System.Drawing.Point(93, 162);
            this.Miembros_label.Name = "Miembros_label";
            this.Miembros_label.Size = new System.Drawing.Size(68, 16);
            this.Miembros_label.TabIndex = 1;
            this.Miembros_label.Text = "Miembros";
            // 
            // Miembros_listBox
            // 
            this.Miembros_listBox.FormattingEnabled = true;
            this.Miembros_listBox.ItemHeight = 16;
            this.Miembros_listBox.Location = new System.Drawing.Point(211, 162);
            this.Miembros_listBox.Name = "Miembros_listBox";
            this.Miembros_listBox.Size = new System.Drawing.Size(331, 148);
            this.Miembros_listBox.TabIndex = 2;
            // 
            // Parcela_textBox
            // 
            this.Parcela_textBox.Location = new System.Drawing.Point(211, 97);
            this.Parcela_textBox.Name = "Parcela_textBox";
            this.Parcela_textBox.Size = new System.Drawing.Size(100, 22);
            this.Parcela_textBox.TabIndex = 3;
            // 
            // NewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Parcela_textBox);
            this.Controls.Add(this.Miembros_listBox);
            this.Controls.Add(this.Miembros_label);
            this.Controls.Add(this.Parcela_label);
            this.Name = "NewGroupForm";
            this.Text = "NewGroupForm";
            this.Load += new System.EventHandler(this.carga);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Parcela_label;
        private System.Windows.Forms.Label Miembros_label;
        private System.Windows.Forms.ListBox Miembros_listBox;
        private System.Windows.Forms.TextBox Parcela_textBox;
    }
}