
namespace TarongISW.Presentation
{
    partial class GetTruckTrips
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
            this.Plate_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerInit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.Lista_listView = new System.Windows.Forms.ListView();
            this.Search_button = new System.Windows.Forms.Button();
            this.Parcel_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NCajas_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peso_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Plate_label
            // 
            this.Plate_label.AutoSize = true;
            this.Plate_label.Location = new System.Drawing.Point(87, 51);
            this.Plate_label.Name = "Plate_label";
            this.Plate_label.Size = new System.Drawing.Size(87, 16);
            this.Plate_label.TabIndex = 0;
            this.Plate_label.Text = "Plate number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.plate_textbox_change);
            // 
            // dateTimePickerInit
            // 
            this.dateTimePickerInit.Location = new System.Drawing.Point(403, 42);
            this.dateTimePickerInit.Name = "dateTimePickerInit";
            this.dateTimePickerInit.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInit.TabIndex = 2;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(403, 96);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFinal.TabIndex = 3;
            // 
            // Lista_listView
            // 
            this.Lista_listView.HideSelection = false;
            this.Lista_listView.Location = new System.Drawing.Point(90, 172);
            this.Lista_listView.Name = "Lista_listView";
            this.Lista_listView.Size = new System.Drawing.Size(513, 227);
            this.Lista_listView.TabIndex = 4;
            this.Lista_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(208, 96);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 5;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_click);
            // 
            // GetTruckTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Lista_listView);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Plate_label);
            this.Name = "GetTruckTrips";
            this.Text = "GetTruckTrips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plate_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInit;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.ListView Lista_listView;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.ColumnHeader Parcel_column;
        private System.Windows.Forms.ColumnHeader Fecha_column;
        private System.Windows.Forms.ColumnHeader NCajas_column;
        private System.Windows.Forms.ColumnHeader Peso_column;
    }
}