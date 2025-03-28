namespace MovieX
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.Black;
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt3.ForeColor = System.Drawing.SystemColors.Window;
            this.txt3.Location = new System.Drawing.Point(328, 113);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(142, 27);
            this.txt3.TabIndex = 1;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.Black;
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt4.ForeColor = System.Drawing.SystemColors.Window;
            this.txt4.Location = new System.Drawing.Point(328, 156);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(142, 20);
            this.txt4.TabIndex = 2;
            // 
            // txt6
            // 
            this.txt6.BackColor = System.Drawing.Color.Black;
            this.txt6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt6.ForeColor = System.Drawing.SystemColors.Window;
            this.txt6.Location = new System.Drawing.Point(329, 234);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(142, 20);
            this.txt6.TabIndex = 3;
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.Color.Black;
            this.txt5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt5.ForeColor = System.Drawing.SystemColors.Window;
            this.txt5.Location = new System.Drawing.Point(329, 194);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(142, 20);
            this.txt5.TabIndex = 4;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(329, 270);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(142, 24);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Create";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button btn2;
    }
}