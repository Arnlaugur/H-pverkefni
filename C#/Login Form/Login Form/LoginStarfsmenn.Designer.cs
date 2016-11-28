namespace Login_Form
{
    partial class LoginStarfsmenn
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
            this.labelVelkominn = new System.Windows.Forms.Label();
            this.btSkráSemVeikur = new System.Windows.Forms.Button();
            this.btSkráIFrí = new System.Windows.Forms.Button();
            this.btSkráSemMættur = new System.Windows.Forms.Button();
            this.labelMotd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVelkominn
            // 
            this.labelVelkominn.AutoSize = true;
            this.labelVelkominn.BackColor = System.Drawing.SystemColors.Control;
            this.labelVelkominn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVelkominn.Location = new System.Drawing.Point(12, 12);
            this.labelVelkominn.Name = "labelVelkominn";
            this.labelVelkominn.Size = new System.Drawing.Size(15, 13);
            this.labelVelkominn.TabIndex = 0;
            this.labelVelkominn.Text = "**";
            // 
            // btSkráSemVeikur
            // 
            this.btSkráSemVeikur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSkráSemVeikur.Location = new System.Drawing.Point(140, 123);
            this.btSkráSemVeikur.Name = "btSkráSemVeikur";
            this.btSkráSemVeikur.Size = new System.Drawing.Size(96, 33);
            this.btSkráSemVeikur.TabIndex = 1;
            this.btSkráSemVeikur.Text = "Skrá sem veikur";
            this.btSkráSemVeikur.UseVisualStyleBackColor = false;
            this.btSkráSemVeikur.Click += new System.EventHandler(this.btSkráSemVeikur_Click);
            // 
            // btSkráIFrí
            // 
            this.btSkráIFrí.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSkráIFrí.Location = new System.Drawing.Point(140, 69);
            this.btSkráIFrí.Name = "btSkráIFrí";
            this.btSkráIFrí.Size = new System.Drawing.Size(96, 33);
            this.btSkráIFrí.TabIndex = 2;
            this.btSkráIFrí.Text = "Skrá í frí";
            this.btSkráIFrí.UseVisualStyleBackColor = false;
            this.btSkráIFrí.Click += new System.EventHandler(this.btSkráIFrí_Click);
            // 
            // btSkráSemMættur
            // 
            this.btSkráSemMættur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSkráSemMættur.Location = new System.Drawing.Point(140, 12);
            this.btSkráSemMættur.Name = "btSkráSemMættur";
            this.btSkráSemMættur.Size = new System.Drawing.Size(96, 33);
            this.btSkráSemMættur.TabIndex = 3;
            this.btSkráSemMættur.Text = "Skrá sem mættur";
            this.btSkráSemMættur.UseVisualStyleBackColor = false;
            this.btSkráSemMættur.Click += new System.EventHandler(this.btSkráSemMættur_Click);
            // 
            // labelMotd
            // 
            this.labelMotd.AutoSize = true;
            this.labelMotd.Location = new System.Drawing.Point(12, 69);
            this.labelMotd.Name = "labelMotd";
            this.labelMotd.Size = new System.Drawing.Size(15, 13);
            this.labelMotd.TabIndex = 4;
            this.labelMotd.Text = "**";
            // 
            // LoginStarfsmenn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(248, 168);
            this.Controls.Add(this.labelMotd);
            this.Controls.Add(this.btSkráSemMættur);
            this.Controls.Add(this.btSkráIFrí);
            this.Controls.Add(this.btSkráSemVeikur);
            this.Controls.Add(this.labelVelkominn);
            this.Name = "LoginStarfsmenn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginStarfsmenn";
            this.Load += new System.EventHandler(this.LoginStarfsmenn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVelkominn;
        private System.Windows.Forms.Button btSkráSemVeikur;
        private System.Windows.Forms.Button btSkráIFrí;
        private System.Windows.Forms.Button btSkráSemMættur;
        private System.Windows.Forms.Label labelMotd;
    }
}