namespace matchMeGame
{
    partial class frmMatchMe
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
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(150, 50);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(170, 180);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "Click Me!";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(380, 50);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(170, 180);
            this.btn11.TabIndex = 1;
            this.btn11.Text = "Click Me!";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(150, 260);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(170, 180);
            this.btn00.TabIndex = 2;
            this.btn00.Text = "Click Me!";
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(380, 260);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(170, 180);
            this.btn01.TabIndex = 3;
            this.btn01.Text = "Click Me!";
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // frmMatchMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 545);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Name = "frmMatchMe";
            this.Text = "The Match Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
    }
}

