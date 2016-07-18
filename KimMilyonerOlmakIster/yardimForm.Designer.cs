namespace KimMilyonerOlmakIster
{
    partial class yardimForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkOrchid;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Oyunda 3 adet joker hakkın bulunmaktadır.",
            "",
            "Telefon jokeri ile arkadaşını arayabilirsin.",
            "",
            "Yarı yarıya jokeri ile yalnış 2 cevacı sildirebilirsin.",
            "",
            "",
            "Seyirciye sor jokeri ile seyirgilerin görüşünü alabilirsin."});
            this.listBox1.Location = new System.Drawing.Point(60, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 204);
            this.listBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KimMilyonerOlmakIster.Properties.Resources.logolar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // yardimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(435, 204);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "yardimForm";
            this.Text = "YARDIM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}