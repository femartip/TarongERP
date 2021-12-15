
namespace TarongISW.Presentation
{
    partial class TarongISWApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonNewPersonForm = new System.Windows.Forms.Button();
            this.buttonGetTruckTrips = new System.Windows.Forms.Button();
            this.buttonAddCrateToTrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exitButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "NewContractFrom";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.goToNewContractForm);
            // 
            // buttonNewPersonForm
            // 
            this.buttonNewPersonForm.Location = new System.Drawing.Point(115, 199);
            this.buttonNewPersonForm.Name = "buttonNewPersonForm";
            this.buttonNewPersonForm.Size = new System.Drawing.Size(173, 68);
            this.buttonNewPersonForm.TabIndex = 2;
            this.buttonNewPersonForm.Text = "NewPersonForm";
            this.buttonNewPersonForm.UseVisualStyleBackColor = true;
            this.buttonNewPersonForm.Click += new System.EventHandler(this.goNewPersonForm);
            // 
            // buttonGetTruckTrips
            // 
            this.buttonGetTruckTrips.Location = new System.Drawing.Point(115, 125);
            this.buttonGetTruckTrips.Name = "buttonGetTruckTrips";
            this.buttonGetTruckTrips.Size = new System.Drawing.Size(173, 68);
            this.buttonGetTruckTrips.TabIndex = 3;
            this.buttonGetTruckTrips.Text = "GetTruckTripsForm";
            this.buttonGetTruckTrips.UseVisualStyleBackColor = true;
            this.buttonGetTruckTrips.Click += new System.EventHandler(this.goGetTruckTrips);
            // 
            // buttonAddCrateToTrip
            // 
            this.buttonAddCrateToTrip.Location = new System.Drawing.Point(115, 51);
            this.buttonAddCrateToTrip.Name = "buttonAddCrateToTrip";
            this.buttonAddCrateToTrip.Size = new System.Drawing.Size(173, 68);
            this.buttonAddCrateToTrip.TabIndex = 4;
            this.buttonAddCrateToTrip.Text = "AddCrateToTripForm";
            this.buttonAddCrateToTrip.UseVisualStyleBackColor = true;
            this.buttonAddCrateToTrip.Click += new System.EventHandler(this.goAddCrateToTrip);
            // 
            // TarongISWApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.buttonAddCrateToTrip);
            this.Controls.Add(this.buttonGetTruckTrips);
            this.Controls.Add(this.buttonNewPersonForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TarongISWApp";
            this.Text = "TarongISWApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonNewPersonForm;
        private System.Windows.Forms.Button buttonGetTruckTrips;
        private System.Windows.Forms.Button buttonAddCrateToTrip;
    }
}