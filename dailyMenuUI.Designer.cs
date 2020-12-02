namespace DevApp
{
    partial class dailyMenuUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dailyMenuUI));
            this.dinner = new System.Windows.Forms.Button();
            this.lunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dinner
            // 
            this.dinner.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold);
            this.dinner.ForeColor = System.Drawing.Color.Red;
            this.dinner.Image = global::DevApp.Properties.Resources.dinner;
            this.dinner.Location = new System.Drawing.Point(198, 269);
            this.dinner.Name = "dinner";
            this.dinner.Size = new System.Drawing.Size(430, 100);
            this.dinner.TabIndex = 6;
            this.dinner.Text = "Dinner";
            this.dinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dinner.UseVisualStyleBackColor = true;
            this.dinner.Click += new System.EventHandler(this.dinner_Click);
            // 
            // lunch
            // 
            this.lunch.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lunch.Image = ((System.Drawing.Image)(resources.GetObject("lunch.Image")));
            this.lunch.Location = new System.Drawing.Point(198, 116);
            this.lunch.Name = "lunch";
            this.lunch.Size = new System.Drawing.Size(430, 100);
            this.lunch.TabIndex = 5;
            this.lunch.Text = "Lunch";
            this.lunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lunch.UseVisualStyleBackColor = true;
            this.lunch.Click += new System.EventHandler(this.lunch_Click);
            // 
            // dailyMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dinner);
            this.Controls.Add(this.lunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dailyMenuUI";
            this.Text = "dailyMenuUI";
            this.Load += new System.EventHandler(this.dailyMenuUI_Load);
            this.Controls.SetChildIndex(this.lunch, 0);
            this.Controls.SetChildIndex(this.dinner, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lunch;
        private System.Windows.Forms.Button dinner;
    }
}