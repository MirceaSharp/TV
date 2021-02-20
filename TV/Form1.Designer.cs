
namespace TV
{
    partial class TV
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
            this.lblChannelVolume = new System.Windows.Forms.Label();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChannelVolume
            // 
            this.lblChannelVolume.AutoSize = true;
            this.lblChannelVolume.Location = new System.Drawing.Point(47, 27);
            this.lblChannelVolume.Name = "lblChannelVolume";
            this.lblChannelVolume.Size = new System.Drawing.Size(96, 13);
            this.lblChannelVolume.TabIndex = 0;
            this.lblChannelVolume.Text = "Channel: - Volume:";
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(67, 78);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(219, 59);
            this.btnIncrease.TabIndex = 1;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(73, 164);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(212, 63);
            this.btnDecrease.TabIndex = 2;
            this.btnDecrease.Text = "Decrease";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 364);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.lblChannelVolume);
            this.Name = "TV";
            this.Text = "TV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChannelVolume;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
    }
}

