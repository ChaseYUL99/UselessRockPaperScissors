namespace UselessRockPaperScissors.View
{
    partial class MainForm
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
            this.headerLbl = new System.Windows.Forms.Label();
            this.weaponCB = new System.Windows.Forms.ComboBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.headerLbl.Location = new System.Drawing.Point(199, 116);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(411, 51);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.Text = "Choose your weapon:";
            // 
            // weaponCB
            // 
            this.weaponCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.weaponCB.FormattingEnabled = true;
            this.weaponCB.Location = new System.Drawing.Point(116, 280);
            this.weaponCB.Name = "weaponCB";
            this.weaponCB.Size = new System.Drawing.Size(186, 28);
            this.weaponCB.TabIndex = 1;
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.playBtn.Location = new System.Drawing.Point(425, 262);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(220, 64);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.weaponCB);
            this.Controls.Add(this.headerLbl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Useless Rock Paper Scissors";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button playBtn;

        private System.Windows.Forms.ComboBox weaponCB;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label headerLbl;

        #endregion
    }
}