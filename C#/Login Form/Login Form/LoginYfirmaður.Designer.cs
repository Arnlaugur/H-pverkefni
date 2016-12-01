namespace Login_Form
{
    partial class LoginYfirmaður
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelNafn = new System.Windows.Forms.Label();
            this.btSýnaStarfsmenn = new System.Windows.Forms.Button();
            this.btSýnaYfirmenn = new System.Windows.Forms.Button();
            this.btRekaStarfsmann = new System.Windows.Forms.Button();
            this.tbRekaNafn = new System.Windows.Forms.TextBox();
            this.tbRekaEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Ráða = new System.Windows.Forms.Button();
            this.btMotd = new System.Windows.Forms.Button();
            this.btSýnaAlla = new System.Windows.Forms.Button();
            this.tbMotd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSkráMættur = new System.Windows.Forms.Button();
            this.btSkráVeikur = new System.Windows.Forms.Button();
            this.btFaraÍFrí = new System.Windows.Forms.Button();
            this.bt_Skilaboð = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(176, 12);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(610, 436);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // labelNafn
            // 
            this.labelNafn.AutoSize = true;
            this.labelNafn.Location = new System.Drawing.Point(10, 9);
            this.labelNafn.Name = "labelNafn";
            this.labelNafn.Size = new System.Drawing.Size(15, 13);
            this.labelNafn.TabIndex = 1;
            this.labelNafn.Text = "**";
            // 
            // btSýnaStarfsmenn
            // 
            this.btSýnaStarfsmenn.Location = new System.Drawing.Point(12, 196);
            this.btSýnaStarfsmenn.Name = "btSýnaStarfsmenn";
            this.btSýnaStarfsmenn.Size = new System.Drawing.Size(158, 23);
            this.btSýnaStarfsmenn.TabIndex = 2;
            this.btSýnaStarfsmenn.Text = "Sýna alla starfsmenn";
            this.btSýnaStarfsmenn.UseVisualStyleBackColor = true;
            this.btSýnaStarfsmenn.Click += new System.EventHandler(this.btSýnaStarfsmenn_Click);
            // 
            // btSýnaYfirmenn
            // 
            this.btSýnaYfirmenn.Location = new System.Drawing.Point(12, 225);
            this.btSýnaYfirmenn.Name = "btSýnaYfirmenn";
            this.btSýnaYfirmenn.Size = new System.Drawing.Size(158, 23);
            this.btSýnaYfirmenn.TabIndex = 3;
            this.btSýnaYfirmenn.Text = "Sýna alla yfirmenn";
            this.btSýnaYfirmenn.UseVisualStyleBackColor = true;
            this.btSýnaYfirmenn.Click += new System.EventHandler(this.btSýnaYfirmenn_Click);
            // 
            // btRekaStarfsmann
            // 
            this.btRekaStarfsmann.Location = new System.Drawing.Point(12, 283);
            this.btRekaStarfsmann.Name = "btRekaStarfsmann";
            this.btRekaStarfsmann.Size = new System.Drawing.Size(158, 23);
            this.btRekaStarfsmann.TabIndex = 4;
            this.btRekaStarfsmann.Text = "Reka starfsmann";
            this.btRekaStarfsmann.UseVisualStyleBackColor = true;
            this.btRekaStarfsmann.Click += new System.EventHandler(this.btRekaStarfsmann_Click);
            // 
            // tbRekaNafn
            // 
            this.tbRekaNafn.Location = new System.Drawing.Point(90, 312);
            this.tbRekaNafn.Name = "tbRekaNafn";
            this.tbRekaNafn.Size = new System.Drawing.Size(80, 20);
            this.tbRekaNafn.TabIndex = 5;
            // 
            // tbRekaEmail
            // 
            this.tbRekaEmail.Location = new System.Drawing.Point(52, 338);
            this.tbRekaEmail.Name = "tbRekaEmail";
            this.tbRekaEmail.Size = new System.Drawing.Size(118, 20);
            this.tbRekaEmail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Notendanafn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // bt_Ráða
            // 
            this.bt_Ráða.Location = new System.Drawing.Point(12, 254);
            this.bt_Ráða.Name = "bt_Ráða";
            this.bt_Ráða.Size = new System.Drawing.Size(158, 23);
            this.bt_Ráða.TabIndex = 9;
            this.bt_Ráða.Text = "Ráða starfsmann";
            this.bt_Ráða.UseVisualStyleBackColor = true;
            this.bt_Ráða.Click += new System.EventHandler(this.bt_Ráða_Click);
            // 
            // btMotd
            // 
            this.btMotd.Location = new System.Drawing.Point(13, 364);
            this.btMotd.Name = "btMotd";
            this.btMotd.Size = new System.Drawing.Size(157, 23);
            this.btMotd.TabIndex = 11;
            this.btMotd.Text = "Motd";
            this.btMotd.UseVisualStyleBackColor = true;
            this.btMotd.Click += new System.EventHandler(this.btMotd_Click);
            // 
            // btSýnaAlla
            // 
            this.btSýnaAlla.Location = new System.Drawing.Point(12, 167);
            this.btSýnaAlla.Name = "btSýnaAlla";
            this.btSýnaAlla.Size = new System.Drawing.Size(158, 23);
            this.btSýnaAlla.TabIndex = 12;
            this.btSýnaAlla.Text = "Sýna alla";
            this.btSýnaAlla.UseVisualStyleBackColor = true;
            this.btSýnaAlla.Click += new System.EventHandler(this.btSýnaAlla_Click);
            // 
            // tbMotd
            // 
            this.tbMotd.Location = new System.Drawing.Point(49, 398);
            this.tbMotd.Name = "tbMotd";
            this.tbMotd.Size = new System.Drawing.Size(118, 20);
            this.tbMotd.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Motd:";
            // 
            // btSkráMættur
            // 
            this.btSkráMættur.Location = new System.Drawing.Point(12, 67);
            this.btSkráMættur.Name = "btSkráMættur";
            this.btSkráMættur.Size = new System.Drawing.Size(158, 23);
            this.btSkráMættur.TabIndex = 15;
            this.btSkráMættur.Text = "Skrá sem mættur";
            this.btSkráMættur.UseVisualStyleBackColor = true;
            this.btSkráMættur.Click += new System.EventHandler(this.btSkráMættur_Click);
            // 
            // btSkráVeikur
            // 
            this.btSkráVeikur.Location = new System.Drawing.Point(12, 96);
            this.btSkráVeikur.Name = "btSkráVeikur";
            this.btSkráVeikur.Size = new System.Drawing.Size(158, 23);
            this.btSkráVeikur.TabIndex = 16;
            this.btSkráVeikur.Text = "Skrá sem veikur";
            this.btSkráVeikur.UseVisualStyleBackColor = true;
            this.btSkráVeikur.Click += new System.EventHandler(this.btSkráVeikur_Click);
            // 
            // btFaraÍFrí
            // 
            this.btFaraÍFrí.Location = new System.Drawing.Point(12, 125);
            this.btFaraÍFrí.Name = "btFaraÍFrí";
            this.btFaraÍFrí.Size = new System.Drawing.Size(158, 23);
            this.btFaraÍFrí.TabIndex = 17;
            this.btFaraÍFrí.Text = "Fara í frí";
            this.btFaraÍFrí.UseVisualStyleBackColor = true;
            this.btFaraÍFrí.Click += new System.EventHandler(this.btFaraÍFrí_Click);
            // 
            // bt_Skilaboð
            // 
            this.bt_Skilaboð.Location = new System.Drawing.Point(13, 424);
            this.bt_Skilaboð.Name = "bt_Skilaboð";
            this.bt_Skilaboð.Size = new System.Drawing.Size(155, 23);
            this.bt_Skilaboð.TabIndex = 15;
            this.bt_Skilaboð.Text = "Sýna Skilaboð";
            this.bt_Skilaboð.UseVisualStyleBackColor = true;
            this.bt_Skilaboð.Click += new System.EventHandler(this.bt_Skilaboð_Click);
            // 
            // LoginYfirmaður
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 460);
            this.Controls.Add(this.btFaraÍFrí);
            this.Controls.Add(this.btSkráVeikur);
            this.Controls.Add(this.btSkráMættur);
            this.Controls.Add(this.bt_Skilaboð);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMotd);
            this.Controls.Add(this.btSýnaAlla);
            this.Controls.Add(this.btMotd);
            this.Controls.Add(this.bt_Ráða);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRekaEmail);
            this.Controls.Add(this.tbRekaNafn);
            this.Controls.Add(this.btRekaStarfsmann);
            this.Controls.Add(this.btSýnaYfirmenn);
            this.Controls.Add(this.btSýnaStarfsmenn);
            this.Controls.Add(this.labelNafn);
            this.Controls.Add(this.listView1);
            this.Name = "LoginYfirmaður";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginYfirmaður";
            this.Load += new System.EventHandler(this.LoginYfirmaður_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelNafn;
        private System.Windows.Forms.Button btSýnaStarfsmenn;
        private System.Windows.Forms.Button btSýnaYfirmenn;
        private System.Windows.Forms.Button btRekaStarfsmann;
        private System.Windows.Forms.TextBox tbRekaNafn;
        private System.Windows.Forms.TextBox tbRekaEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Ráða;
        private System.Windows.Forms.Button btMotd;
        private System.Windows.Forms.Button btSýnaAlla;
        private System.Windows.Forms.TextBox tbMotd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSkráMættur;
        private System.Windows.Forms.Button btSkráVeikur;
        private System.Windows.Forms.Button btFaraÍFrí;
        private System.Windows.Forms.Button bt_Skilaboð;
    }
}