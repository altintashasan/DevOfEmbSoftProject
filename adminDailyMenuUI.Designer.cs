namespace DevApp
{
    partial class adminDailyMenuUI
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
            this.lunchEdit = new System.Windows.Forms.Button();
            this.dinnerEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lunchEdit
            // 
            this.lunchEdit.Location = new System.Drawing.Point(634, 116);
            this.lunchEdit.Name = "lunchEdit";
            this.lunchEdit.Size = new System.Drawing.Size(89, 100);
            this.lunchEdit.TabIndex = 7;
            this.lunchEdit.Text = "EDIT";
            this.lunchEdit.UseVisualStyleBackColor = true;
            this.lunchEdit.Click += new System.EventHandler(this.lunchEdit_Click);
            // 
            // dinnerEdit
            // 
            this.dinnerEdit.Location = new System.Drawing.Point(634, 269);
            this.dinnerEdit.Name = "dinnerEdit";
            this.dinnerEdit.Size = new System.Drawing.Size(89, 100);
            this.dinnerEdit.TabIndex = 8;
            this.dinnerEdit.Text = "EDIT";
            this.dinnerEdit.UseVisualStyleBackColor = true;
            // 
            // adminDailyMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dinnerEdit);
            this.Controls.Add(this.lunchEdit);
            this.Name = "adminDailyMenuUI";
            this.Text = "adminDailyMenuUI";
            this.Load += new System.EventHandler(this.adminDailyMenuUI_Load);
            this.Controls.SetChildIndex(this.lunchEdit, 0);
            this.Controls.SetChildIndex(this.dinnerEdit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lunchEdit;
        private System.Windows.Forms.Button dinnerEdit;
    }
}