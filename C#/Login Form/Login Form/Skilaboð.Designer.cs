namespace Login_Form
{
    partial class Skilaboð
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
            this.rtb_Skilaboð = new System.Windows.Forms.RichTextBox();
            this.bt_fri = new System.Windows.Forms.Button();
            this.tb_netfang = new System.Windows.Forms.TextBox();
            this.tb_nafn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_Skilaboð
            // 
            this.rtb_Skilaboð.Location = new System.Drawing.Point(13, 13);
            this.rtb_Skilaboð.Name = "rtb_Skilaboð";
            this.rtb_Skilaboð.Size = new System.Drawing.Size(480, 297);
            this.rtb_Skilaboð.TabIndex = 0;
            this.rtb_Skilaboð.Text = "";
            // 
            // bt_fri
            // 
            this.bt_fri.Location = new System.Drawing.Point(564, 181);
            this.bt_fri.Name = "bt_fri";
            this.bt_fri.Size = new System.Drawing.Size(75, 23);
            this.bt_fri.TabIndex = 1;
            this.bt_fri.Text = "Senda í frí";
            this.bt_fri.UseVisualStyleBackColor = true;
            this.bt_fri.Click += new System.EventHandler(this.bt_fri_Click);
            // 
            // tb_netfang
            // 
            this.tb_netfang.Location = new System.Drawing.Point(564, 155);
            this.tb_netfang.Name = "tb_netfang";
            this.tb_netfang.Size = new System.Drawing.Size(100, 20);
            this.tb_netfang.TabIndex = 2;
            // 
            // tb_nafn
            // 
            this.tb_nafn.Location = new System.Drawing.Point(564, 129);
            this.tb_nafn.Name = "tb_nafn";
            this.tb_nafn.Size = new System.Drawing.Size(100, 20);
            this.tb_nafn.TabIndex = 3;
            // 
            // Skilaboð
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 317);
            this.Controls.Add(this.tb_nafn);
            this.Controls.Add(this.tb_netfang);
            this.Controls.Add(this.bt_fri);
            this.Controls.Add(this.rtb_Skilaboð);
            this.Name = "Skilaboð";
            this.Text = "Skilaboð";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Skilaboð;
        private System.Windows.Forms.Button bt_fri;
        private System.Windows.Forms.TextBox tb_netfang;
        private System.Windows.Forms.TextBox tb_nafn;
    }
}