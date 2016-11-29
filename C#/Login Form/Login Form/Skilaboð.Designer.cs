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
            // Skilaboð
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 322);
            this.Controls.Add(this.rtb_Skilaboð);
            this.Name = "Skilaboð";
            this.Text = "Skilaboð";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Skilaboð;
    }
}