
namespace LeeroyAugustProject2
{
    partial class frmLoad
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
            this.components = new System.ComponentModel.Container();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.timerNieuweTip = new System.Windows.Forms.Timer(this.components);
            this.timerKlaar = new System.Windows.Forms.Timer(this.components);
            this.txtTipInhoud = new System.Windows.Forms.TextBox();
            this.timerDone = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Location = new System.Drawing.Point(665, 423);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(57, 16);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "Loading";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.White;
            this.lblTip.Location = new System.Drawing.Point(312, 123);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(80, 42);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip:";
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 1000;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // timerNieuweTip
            // 
            this.timerNieuweTip.Interval = 4000;
            this.timerNieuweTip.Tick += new System.EventHandler(this.timerNieuweTip_Tick);
            // 
            // timerKlaar
            // 
            this.timerKlaar.Tick += new System.EventHandler(this.timerKlaar_Tick);
            // 
            // txtTipInhoud
            // 
            this.txtTipInhoud.BackColor = System.Drawing.Color.Black;
            this.txtTipInhoud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipInhoud.Enabled = false;
            this.txtTipInhoud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtTipInhoud.ForeColor = System.Drawing.Color.White;
            this.txtTipInhoud.Location = new System.Drawing.Point(98, 177);
            this.txtTipInhoud.Multiline = true;
            this.txtTipInhoud.Name = "txtTipInhoud";
            this.txtTipInhoud.Size = new System.Drawing.Size(574, 122);
            this.txtTipInhoud.TabIndex = 3;
            // 
            // timerDone
            // 
            this.timerDone.Interval = 1000;
            this.timerDone.Tick += new System.EventHandler(this.timerDone_Tick);
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTipInhoud);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.Text = "S";
            this.Shown += new System.EventHandler(this.frmLoad_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Timer timerNieuweTip;
        private System.Windows.Forms.Timer timerKlaar;
        private System.Windows.Forms.TextBox txtTipInhoud;
        private System.Windows.Forms.Timer timerDone;
    }
}