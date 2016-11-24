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
            this.label1 = new System.Windows.Forms.Label();
            this.btSýnaStarfsmenn = new System.Windows.Forms.Button();
            this.btSýnaYfirmenn = new System.Windows.Forms.Button();
            this.btRekaStarfsmann = new System.Windows.Forms.Button();
            this.tbRekaNafn = new System.Windows.Forms.TextBox();
            this.tbRekaSimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Ráða = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btSýnaAlla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(176, 117);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(610, 331);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*";
            // 
            // btSýnaStarfsmenn
            // 
            this.btSýnaStarfsmenn.Location = new System.Drawing.Point(13, 146);
            this.btSýnaStarfsmenn.Name = "btSýnaStarfsmenn";
            this.btSýnaStarfsmenn.Size = new System.Drawing.Size(158, 23);
            this.btSýnaStarfsmenn.TabIndex = 2;
            this.btSýnaStarfsmenn.Text = "Sýna alla starfsmenn";
            this.btSýnaStarfsmenn.UseVisualStyleBackColor = true;
            this.btSýnaStarfsmenn.Click += new System.EventHandler(this.btSýnaStarfsmenn_Click);
            // 
            // btSýnaYfirmenn
            // 
            this.btSýnaYfirmenn.Location = new System.Drawing.Point(13, 175);
            this.btSýnaYfirmenn.Name = "btSýnaYfirmenn";
            this.btSýnaYfirmenn.Size = new System.Drawing.Size(158, 23);
            this.btSýnaYfirmenn.TabIndex = 3;
            this.btSýnaYfirmenn.Text = "Sýna alla yfirmenn";
            this.btSýnaYfirmenn.UseVisualStyleBackColor = true;
            this.btSýnaYfirmenn.Click += new System.EventHandler(this.btSýnaYfirmenn_Click);
            // 
            // btRekaStarfsmann
            // 
            this.btRekaStarfsmann.Location = new System.Drawing.Point(13, 233);
            this.btRekaStarfsmann.Name = "btRekaStarfsmann";
            this.btRekaStarfsmann.Size = new System.Drawing.Size(158, 23);
            this.btRekaStarfsmann.TabIndex = 4;
            this.btRekaStarfsmann.Text = "Reka starfsmann";
            this.btRekaStarfsmann.UseVisualStyleBackColor = true;
            // 
            // tbRekaNafn
            // 
            this.tbRekaNafn.Location = new System.Drawing.Point(53, 262);
            this.tbRekaNafn.Name = "tbRekaNafn";
            this.tbRekaNafn.Size = new System.Drawing.Size(118, 20);
            this.tbRekaNafn.TabIndex = 5;
            // 
            // tbRekaSimi
            // 
            this.tbRekaSimi.Location = new System.Drawing.Point(53, 288);
            this.tbRekaSimi.Name = "tbRekaSimi";
            this.tbRekaSimi.Size = new System.Drawing.Size(118, 20);
            this.tbRekaSimi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nafn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sími:";
            // 
            // bt_Ráða
            // 
            this.bt_Ráða.Location = new System.Drawing.Point(13, 204);
            this.bt_Ráða.Name = "bt_Ráða";
            this.bt_Ráða.Size = new System.Drawing.Size(158, 23);
            this.bt_Ráða.TabIndex = 9;
            this.bt_Ráða.Text = "Ráða starfsmann";
            this.bt_Ráða.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Senda í frí";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Motd";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btSýnaAlla
            // 
            this.btSýnaAlla.Location = new System.Drawing.Point(13, 117);
            this.btSýnaAlla.Name = "btSýnaAlla";
            this.btSýnaAlla.Size = new System.Drawing.Size(158, 23);
            this.btSýnaAlla.TabIndex = 12;
            this.btSýnaAlla.Text = "Sýna alla";
            this.btSýnaAlla.UseVisualStyleBackColor = true;
            this.btSýnaAlla.Click += new System.EventHandler(this.btSýnaAlla_Click);
            // 
            // LoginYfirmaður
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 460);
            this.Controls.Add(this.btSýnaAlla);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_Ráða);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRekaSimi);
            this.Controls.Add(this.tbRekaNafn);
            this.Controls.Add(this.btRekaStarfsmann);
            this.Controls.Add(this.btSýnaYfirmenn);
            this.Controls.Add(this.btSýnaStarfsmenn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "LoginYfirmaður";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginYfirmaður";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSýnaStarfsmenn;
        private System.Windows.Forms.Button btSýnaYfirmenn;
        private System.Windows.Forms.Button btRekaStarfsmann;
        private System.Windows.Forms.TextBox tbRekaNafn;
        private System.Windows.Forms.TextBox tbRekaSimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Ráða;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btSýnaAlla;
    }
}