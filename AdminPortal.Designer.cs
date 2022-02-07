namespace CST_Project_1
{
    partial class AdminPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPortal));
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.modStaff_btn = new System.Windows.Forms.Button();
            this.modStoreItems_btn = new System.Windows.Forms.Button();
            this.modMembers_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(271, 30);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(279, 55);
            this.welcome_lbl.TabIndex = 1;
            this.welcome_lbl.Text = "WELCOME";
            // 
            // modStaff_btn
            // 
            this.modStaff_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modStaff_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modStaff_btn.Location = new System.Drawing.Point(56, 153);
            this.modStaff_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modStaff_btn.Name = "modStaff_btn";
            this.modStaff_btn.Size = new System.Drawing.Size(211, 31);
            this.modStaff_btn.TabIndex = 2;
            this.modStaff_btn.Text = "Staff";
            this.modStaff_btn.UseVisualStyleBackColor = true;
            // 
            // modStoreItems_btn
            // 
            this.modStoreItems_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modStoreItems_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modStoreItems_btn.Location = new System.Drawing.Point(309, 153);
            this.modStoreItems_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modStoreItems_btn.Name = "modStoreItems_btn";
            this.modStoreItems_btn.Size = new System.Drawing.Size(211, 31);
            this.modStoreItems_btn.TabIndex = 2;
            this.modStoreItems_btn.Text = "Store Items";
            this.modStoreItems_btn.UseVisualStyleBackColor = true;
            this.modStoreItems_btn.Click += new System.EventHandler(this.modStoreItems_btn_Click);
            // 
            // modMembers_btn
            // 
            this.modMembers_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modMembers_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modMembers_btn.Location = new System.Drawing.Point(560, 153);
            this.modMembers_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modMembers_btn.Name = "modMembers_btn";
            this.modMembers_btn.Size = new System.Drawing.Size(211, 31);
            this.modMembers_btn.TabIndex = 2;
            this.modMembers_btn.Text = "Members";
            this.modMembers_btn.UseVisualStyleBackColor = true;
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(858, 479);
            this.Controls.Add(this.modMembers_btn);
            this.Controls.Add(this.modStoreItems_btn);
            this.Controls.Add(this.modStaff_btn);
            this.Controls.Add(this.welcome_lbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Portal ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Button modStaff_btn;
        private System.Windows.Forms.Button modStoreItems_btn;
        private System.Windows.Forms.Button modMembers_btn;
    }
}