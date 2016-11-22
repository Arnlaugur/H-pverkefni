namespace Login_Form
{
    partial class RadaStarfsmann
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
            this.bt_Raða = new System.Windows.Forms.Button();
            this.tb_Nafn = new System.Windows.Forms.TextBox();
            this.tb_Simi = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Hlutverk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Raða
            // 
            this.bt_Raða.Location = new System.Drawing.Point(89, 132);
            this.bt_Raða.Name = "bt_Raða";
            this.bt_Raða.Size = new System.Drawing.Size(100, 23);
            this.bt_Raða.TabIndex = 0;
            this.bt_Raða.Text = "Ráða starfsmann";
            this.bt_Raða.UseVisualStyleBackColor = true;
            // 
            // tb_Nafn
            // 
            this.tb_Nafn.Location = new System.Drawing.Point(89, 27);
            this.tb_Nafn.Name = "tb_Nafn";
            this.tb_Nafn.Size = new System.Drawing.Size(100, 20);
            this.tb_Nafn.TabIndex = 1;
            // 
            // tb_Simi
            // 
            this.tb_Simi.Location = new System.Drawing.Point(89, 53);
            this.tb_Simi.Name = "tb_Simi";
            this.tb_Simi.Size = new System.Drawing.Size(100, 20);
            this.tb_Simi.TabIndex = 2;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(89, 79);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 3;
            // 
            // tb_Hlutverk
            // 
            this.tb_Hlutverk.Location = new System.Drawing.Point(89, 106);
            this.tb_Hlutverk.Name = "tb_Hlutverk";
            this.tb_Hlutverk.Size = new System.Drawing.Size(100, 20);
            this.tb_Hlutverk.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nafn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sími:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hlutverk:";
            // 
            // RadaStarfsmann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 200);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Hlutverk);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Simi);
            this.Controls.Add(this.tb_Nafn);
            this.Controls.Add(this.bt_Raða);
            this.Name = "RadaStarfsmann";
            this.Text = "RadaStarfsmann";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Raða;
        private System.Windows.Forms.TextBox tb_Nafn;
        private System.Windows.Forms.TextBox tb_Simi;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Hlutverk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}