
namespace TarongISW.Presentation
{
    partial class NewGroupForm
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
            this.Parcel_text = new System.Windows.Forms.Label();
            this.Parcel_groupBox = new System.Windows.Forms.GroupBox();
            this.Parcela_button = new System.Windows.Forms.Button();
            this.Parcel_textBox = new System.Windows.Forms.TextBox();
            this.Members_ListBox = new System.Windows.Forms.CheckedListBox();
            this.NewMember_button = new System.Windows.Forms.Button();
            this.Members_text = new System.Windows.Forms.Label();
            this.CrearCuadrilla_button = new System.Windows.Forms.Button();
            this.Members_groupBox = new System.Windows.Forms.GroupBox();
            this.Parcel_groupBox.SuspendLayout();
            this.Members_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parcel_text
            // 
            this.Parcel_text.AutoSize = true;
            this.Parcel_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Parcel_text.Location = new System.Drawing.Point(27, 20);
            this.Parcel_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Parcel_text.Name = "Parcel_text";
            this.Parcel_text.Size = new System.Drawing.Size(77, 16);
            this.Parcel_text.TabIndex = 0;
            this.Parcel_text.Text = "Parcela (id)";
            // 
            // Parcel_groupBox
            // 
            this.Parcel_groupBox.Controls.Add(this.Parcela_button);
            this.Parcel_groupBox.Controls.Add(this.Parcel_textBox);
            this.Parcel_groupBox.Controls.Add(this.Parcel_text);
            this.Parcel_groupBox.Location = new System.Drawing.Point(16, 37);
            this.Parcel_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.Parcel_groupBox.Name = "Parcel_groupBox";
            this.Parcel_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.Parcel_groupBox.Size = new System.Drawing.Size(499, 60);
            this.Parcel_groupBox.TabIndex = 2;
            this.Parcel_groupBox.TabStop = false;
            // 
            // Parcela_button
            // 
            this.Parcela_button.Location = new System.Drawing.Point(380, 16);
            this.Parcela_button.Margin = new System.Windows.Forms.Padding(4);
            this.Parcela_button.Name = "Parcela_button";
            this.Parcela_button.Size = new System.Drawing.Size(111, 28);
            this.Parcela_button.TabIndex = 2;
            this.Parcela_button.Text = "Buscar";
            this.Parcela_button.UseVisualStyleBackColor = true;
            this.Parcela_button.Click += new System.EventHandler(this.Parcela_button_Click);
            // 
            // Parcel_textBox
            // 
            this.Parcel_textBox.Location = new System.Drawing.Point(137, 18);
            this.Parcel_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Parcel_textBox.Name = "Parcel_textBox";
            this.Parcel_textBox.Size = new System.Drawing.Size(233, 22);
            this.Parcel_textBox.TabIndex = 1;
            this.Parcel_textBox.TextChanged += new System.EventHandler(this.Parcel_textBox_TextChanged);
            // 
            // Members_ListBox
            // 
            this.Members_ListBox.FormattingEnabled = true;
            this.Members_ListBox.Location = new System.Drawing.Point(30, 59);
            this.Members_ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.Members_ListBox.Name = "Members_ListBox";
            this.Members_ListBox.Size = new System.Drawing.Size(340, 242);
            this.Members_ListBox.TabIndex = 0;
            // 
            // NewMember_button
            // 
            this.NewMember_button.Location = new System.Drawing.Point(378, 59);
            this.NewMember_button.Margin = new System.Windows.Forms.Padding(4);
            this.NewMember_button.Name = "NewMember_button";
            this.NewMember_button.Size = new System.Drawing.Size(111, 29);
            this.NewMember_button.TabIndex = 1;
            this.NewMember_button.Text = "Añadir miembro";
            this.NewMember_button.UseVisualStyleBackColor = true;
            this.NewMember_button.Click += new System.EventHandler(this.NewMember_button_Click);
            // 
            // Members_text
            // 
            this.Members_text.AutoSize = true;
            this.Members_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Members_text.Location = new System.Drawing.Point(27, 25);
            this.Members_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Members_text.Name = "Members_text";
            this.Members_text.Size = new System.Drawing.Size(68, 16);
            this.Members_text.TabIndex = 2;
            this.Members_text.Text = "Miembros";
            // 
            // CrearCuadrilla_button
            // 
            this.CrearCuadrilla_button.Location = new System.Drawing.Point(380, 303);
            this.CrearCuadrilla_button.Margin = new System.Windows.Forms.Padding(4);
            this.CrearCuadrilla_button.Name = "CrearCuadrilla_button";
            this.CrearCuadrilla_button.Size = new System.Drawing.Size(111, 28);
            this.CrearCuadrilla_button.TabIndex = 5;
            this.CrearCuadrilla_button.Text = "Crear Cuadrilla";
            this.CrearCuadrilla_button.UseVisualStyleBackColor = true;
            this.CrearCuadrilla_button.Click += new System.EventHandler(this.CrearCuadrilla_button_Click);
            // 
            // Members_groupBox
            // 
            this.Members_groupBox.Controls.Add(this.CrearCuadrilla_button);
            this.Members_groupBox.Controls.Add(this.Members_text);
            this.Members_groupBox.Controls.Add(this.NewMember_button);
            this.Members_groupBox.Controls.Add(this.Members_ListBox);
            this.Members_groupBox.Location = new System.Drawing.Point(16, 105);
            this.Members_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.Members_groupBox.Name = "Members_groupBox";
            this.Members_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.Members_groupBox.Size = new System.Drawing.Size(499, 338);
            this.Members_groupBox.TabIndex = 3;
            this.Members_groupBox.TabStop = false;
            this.Members_groupBox.Visible = false;
            // 
            // NewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 485);
            this.Controls.Add(this.Members_groupBox);
            this.Controls.Add(this.Parcel_groupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewGroupForm";
            this.Text = "AltaCuadrillaForm";
            this.Load += new System.EventHandler(this.NewGroupForm_Load);
            this.Parcel_groupBox.ResumeLayout(false);
            this.Parcel_groupBox.PerformLayout();
            this.Members_groupBox.ResumeLayout(false);
            this.Members_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Parcel_text;
        private System.Windows.Forms.GroupBox Parcel_groupBox;
        private System.Windows.Forms.ComboBox Parcel_comboBox;
        private System.Windows.Forms.Button Parcela_button;
        private System.Windows.Forms.TextBox Parcel_textBox;
        private System.Windows.Forms.CheckedListBox Members_ListBox;
        private System.Windows.Forms.Button NewMember_button;
        private System.Windows.Forms.Label Members_text;
        private System.Windows.Forms.Button CrearCuadrilla_button;
        private System.Windows.Forms.GroupBox Members_groupBox;
    }
}