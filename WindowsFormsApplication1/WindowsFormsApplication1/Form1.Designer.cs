namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashLabel = new System.Windows.Forms.Label();
            this.reportHashLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address:";
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(75, 52);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(0, 13);
            this.addLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hashrate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reported Hashrate:";
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(72, 77);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(0, 13);
            this.hashLabel.TabIndex = 5;
            // 
            // reportHashLabel
            // 
            this.reportHashLabel.AutoSize = true;
            this.reportHashLabel.Location = new System.Drawing.Point(120, 103);
            this.reportHashLabel.Name = "reportHashLabel";
            this.reportHashLabel.Size = new System.Drawing.Size(0, 13);
            this.reportHashLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Credits:";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(65, 131);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(0, 13);
            this.creditLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 262);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportHashLabel);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.Label reportHashLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label creditLabel;
    }
}

