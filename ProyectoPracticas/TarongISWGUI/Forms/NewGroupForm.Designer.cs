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
            this.SuspendLayout();
            // 
            // NewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "NewGroupForm";
            this.Load += new System.EventHandler(this.NewGroupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Parcela_label;
        private System.Windows.Forms.Label Miembros_label;
        private System.Windows.Forms.ListBox Miembros_listBox;
        private System.Windows.Forms.TextBox Parcela_textBox;
    }
}