namespace Cinema
{
    partial class Compra
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
            this.label1 = new System.Windows.Forms.Label();
            this.butlow1 = new System.Windows.Forms.Button();
            this.butPlus1 = new System.Windows.Forms.Button();
            this.labelInt = new System.Windows.Forms.Label();
            this.labelMeia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butPlus2 = new System.Windows.Forms.Button();
            this.butLow2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(343, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butlow1
            // 
            this.butlow1.Location = new System.Drawing.Point(346, 170);
            this.butlow1.Name = "butlow1";
            this.butlow1.Size = new System.Drawing.Size(75, 23);
            this.butlow1.TabIndex = 2;
            this.butlow1.Text = "-";
            this.butlow1.UseVisualStyleBackColor = true;
            this.butlow1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butPlus1
            // 
            this.butPlus1.Location = new System.Drawing.Point(509, 175);
            this.butPlus1.Name = "butPlus1";
            this.butPlus1.Size = new System.Drawing.Size(75, 23);
            this.butPlus1.TabIndex = 3;
            this.butPlus1.Text = "+";
            this.butPlus1.UseVisualStyleBackColor = true;
            this.butPlus1.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(450, 180);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(13, 13);
            this.labelInt.TabIndex = 4;
            this.labelInt.Text = "0";
            // 
            // labelMeia
            // 
            this.labelMeia.AutoSize = true;
            this.labelMeia.Location = new System.Drawing.Point(450, 233);
            this.labelMeia.Name = "labelMeia";
            this.labelMeia.Size = new System.Drawing.Size(13, 13);
            this.labelMeia.TabIndex = 7;
            this.labelMeia.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // butPlus2
            // 
            this.butPlus2.Location = new System.Drawing.Point(509, 228);
            this.butPlus2.Name = "butPlus2";
            this.butPlus2.Size = new System.Drawing.Size(75, 23);
            this.butPlus2.TabIndex = 10;
            this.butPlus2.Text = "+";
            this.butPlus2.UseVisualStyleBackColor = true;
            this.butPlus2.Click += new System.EventHandler(this.butPlus2_Click);
            // 
            // butLow2
            // 
            this.butLow2.Location = new System.Drawing.Point(346, 229);
            this.butLow2.Name = "butLow2";
            this.butLow2.Size = new System.Drawing.Size(75, 23);
            this.butLow2.TabIndex = 11;
            this.butLow2.Text = "-";
            this.butLow2.UseVisualStyleBackColor = true;
            this.butLow2.Click += new System.EventHandler(this.butLow2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ingressos restantes :";
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butLow2);
            this.Controls.Add(this.butPlus2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMeia);
            this.Controls.Add(this.labelInt);
            this.Controls.Add(this.butPlus1);
            this.Controls.Add(this.butlow1);
            this.Controls.Add(this.label1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butlow1;
        private System.Windows.Forms.Button butPlus1;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelMeia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butPlus2;
        private System.Windows.Forms.Button butLow2;
        private System.Windows.Forms.Label label2;
    }
}