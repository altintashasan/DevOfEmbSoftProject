namespace DevApp
{
    partial class customerMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerMainUI));
            this.showDailyMenu = new System.Windows.Forms.Button();
            this.makeReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showDailyMenu
            // 
            this.showDailyMenu.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold);
            this.showDailyMenu.Image = ((System.Drawing.Image)(resources.GetObject("showDailyMenu.Image")));
            this.showDailyMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDailyMenu.Location = new System.Drawing.Point(305, 128);
            this.showDailyMenu.Name = "showDailyMenu";
            this.showDailyMenu.Size = new System.Drawing.Size(219, 55);
            this.showDailyMenu.TabIndex = 5;
            this.showDailyMenu.Text = "Show Daily Menu";
            this.showDailyMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showDailyMenu.UseVisualStyleBackColor = true;
            this.showDailyMenu.Click += new System.EventHandler(this.showDailyMenu_Click);
            // 
            // makeReservation
            // 
            this.makeReservation.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.makeReservation.Image = global::DevApp.Properties.Resources.reservation;
            this.makeReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makeReservation.Location = new System.Drawing.Point(305, 202);
            this.makeReservation.Name = "makeReservation";
            this.makeReservation.Size = new System.Drawing.Size(219, 61);
            this.makeReservation.TabIndex = 6;
            this.makeReservation.Text = "Make A Reservation";
            this.makeReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.makeReservation.UseVisualStyleBackColor = true;
            this.makeReservation.Click += new System.EventHandler(this.makeReservation_Click);
            // 
            // customerMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.makeReservation);
            this.Controls.Add(this.showDailyMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerMainUI";
            this.Text = "customerMainUI";
            this.Controls.SetChildIndex(this.showDailyMenu, 0);
            this.Controls.SetChildIndex(this.makeReservation, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showDailyMenu;
        private System.Windows.Forms.Button makeReservation;
    }
}