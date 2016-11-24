namespace Login_Form
{
    partial class Form1
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
            this.bt_Login = new System.Windows.Forms.Button();
            this.tb_Notendanafn = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_NotendanafnVirkja = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Virkja = new System.Windows.Forms.Button();
            this.tb_Lykilorð1 = new System.Windows.Forms.TextBox();
            this.tb_Lykilorð2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(255, 84);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // tb_Notendanafn
            // 
            this.tb_Notendanafn.Location = new System.Drawing.Point(114, 29);
            this.tb_Notendanafn.Name = "tb_Notendanafn";
            this.tb_Notendanafn.Size = new System.Drawing.Size(216, 20);
            this.tb_Notendanafn.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(114, 58);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(216, 20);
            this.tb_Password.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 173);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_Login);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tb_Password);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_Notendanafn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_Lykilorð2);
            this.tabPage2.Controls.Add(this.tb_Lykilorð1);
            this.tabPage2.Controls.Add(this.bt_Virkja);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_Email);
            this.tabPage2.Controls.Add(this.tb_NotendanafnVirkja);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nýr Notandi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notendanafn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lykilorð:";
            // 
            // tb_NotendanafnVirkja
            // 
            this.tb_NotendanafnVirkja.Location = new System.Drawing.Point(161, 19);
            this.tb_NotendanafnVirkja.Name = "tb_NotendanafnVirkja";
            this.tb_NotendanafnVirkja.Size = new System.Drawing.Size(100, 20);
            this.tb_NotendanafnVirkja.TabIndex = 0;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(161, 45);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spurðu yfirmann um notendanafnið þitt ef þú ert ekki kominn með það";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notendanafn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nýtt Lykilorð:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Staðfesta lykilorð:";
            // 
            // bt_Virkja
            // 
            this.bt_Virkja.Location = new System.Drawing.Point(302, 118);
            this.bt_Virkja.Name = "bt_Virkja";
            this.bt_Virkja.Size = new System.Drawing.Size(84, 23);
            this.bt_Virkja.TabIndex = 7;
            this.bt_Virkja.Text = "virkja til aðgang";
            this.bt_Virkja.UseVisualStyleBackColor = true;
            // 
            // tb_Lykilorð1
            // 
            this.tb_Lykilorð1.Location = new System.Drawing.Point(161, 71);
            this.tb_Lykilorð1.Name = "tb_Lykilorð1";
            this.tb_Lykilorð1.Size = new System.Drawing.Size(100, 20);
            this.tb_Lykilorð1.TabIndex = 8;
            // 
            // tb_Lykilorð2
            // 
            this.tb_Lykilorð2.Location = new System.Drawing.Point(161, 97);
            this.tb_Lykilorð2.Name = "tb_Lykilorð2";
            this.tb_Lykilorð2.Size = new System.Drawing.Size(100, 20);
            this.tb_Lykilorð2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(424, 192);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox tb_Notendanafn;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_Lykilorð2;
        private System.Windows.Forms.TextBox tb_Lykilorð1;
        private System.Windows.Forms.Button bt_Virkja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_NotendanafnVirkja;
    }
}

