
namespace LeeroyAugustProject2
{
    partial class frmFrontPage
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAuteurs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::LeeroyAugustProject2.Properties.Resources.buttonStart;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(50, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAuteurs
            // 
            this.btnAuteurs.BackColor = System.Drawing.Color.Transparent;
            this.btnAuteurs.BackgroundImage = global::LeeroyAugustProject2.Properties.Resources.buttonStart;
            this.btnAuteurs.FlatAppearance.BorderSize = 0;
            this.btnAuteurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAuteurs.ForeColor = System.Drawing.Color.White;
            this.btnAuteurs.Location = new System.Drawing.Point(50, 172);
            this.btnAuteurs.Name = "btnAuteurs";
            this.btnAuteurs.Size = new System.Drawing.Size(189, 61);
            this.btnAuteurs.TabIndex = 1;
            this.btnAuteurs.Text = "auteurs";
            this.btnAuteurs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAuteurs.UseVisualStyleBackColor = false;
            this.btnAuteurs.Click += new System.EventHandler(this.BtnAuteurs_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::LeeroyAugustProject2.Properties.Resources.buttonStart;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(50, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 61);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Game";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(291, 377);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAuteurs);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFrontPage";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAuteurs;
        private System.Windows.Forms.Button btnExit;
    }
}

