using TarongISW.Services;
namespace TarongISW.Presentation
{
    partial class ViajesCamionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ITarongISWService service;

        public ViajesCamionForm(ITarongISWService service)
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(150, 228);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ClickGo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Llegada";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(101, 39);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(200, 20);
            this.textBoxMatricula.TabIndex = 5;
            this.textBoxMatricula.TextChanged += new System.EventHandler(this.textMatriculaChanged);
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Location = new System.Drawing.Point(101, 94);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSalida.TabIndex = 6;
            this.dateTimePickerSalida.ValueChanged += new System.EventHandler(this.salidaChanged);
            // 
            // dateTimePickerLlegada
            // 
            this.dateTimePickerLlegada.Location = new System.Drawing.Point(101, 156);
            this.dateTimePickerLlegada.Name = "dateTimePickerLlegada";
            this.dateTimePickerLlegada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLlegada.TabIndex = 7;
            this.dateTimePickerLlegada.ValueChanged += new System.EventHandler(this.LlegadaChanged);
            // 
            // ViajesCamionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 299);
            this.Controls.Add(this.dateTimePickerLlegada);
            this.Controls.Add(this.dateTimePickerSalida);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Name = "ViajesCamionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.DateTimePicker dateTimePickerLlegada;
    }
}