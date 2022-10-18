namespace Cinema
{
    partial class Assentos
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
            this.btnAssento1 = new System.Windows.Forms.Button();
            this.btnAssento2 = new System.Windows.Forms.Button();
            this.btnAssento3 = new System.Windows.Forms.Button();
            this.LabelNassentos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConfirmar = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssento1
            // 
            this.btnAssento1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAssento1.Location = new System.Drawing.Point(70, 37);
            this.btnAssento1.Name = "btnAssento1";
            this.btnAssento1.Size = new System.Drawing.Size(75, 23);
            this.btnAssento1.TabIndex = 0;
            this.btnAssento1.Text = "btnAssento1";
            this.btnAssento1.UseVisualStyleBackColor = false;
            this.btnAssento1.Click += new System.EventHandler(this.btnAssento1_Click);
            // 
            // btnAssento2
            // 
            this.btnAssento2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAssento2.Location = new System.Drawing.Point(188, 37);
            this.btnAssento2.Name = "btnAssento2";
            this.btnAssento2.Size = new System.Drawing.Size(75, 23);
            this.btnAssento2.TabIndex = 1;
            this.btnAssento2.Text = "btnAssento2";
            this.btnAssento2.UseVisualStyleBackColor = false;
            this.btnAssento2.Click += new System.EventHandler(this.btnAssento2_Click);
            // 
            // btnAssento3
            // 
            this.btnAssento3.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAssento3.Location = new System.Drawing.Point(302, 37);
            this.btnAssento3.Name = "btnAssento3";
            this.btnAssento3.Size = new System.Drawing.Size(75, 23);
            this.btnAssento3.TabIndex = 2;
            this.btnAssento3.Text = "btnAssento3";
            this.btnAssento3.UseVisualStyleBackColor = false;
            this.btnAssento3.Click += new System.EventHandler(this.btnAssento3_Click);
            // 
            // LabelNassentos
            // 
            this.LabelNassentos.AutoSize = true;
            this.LabelNassentos.ForeColor = System.Drawing.Color.White;
            this.LabelNassentos.Location = new System.Drawing.Point(446, 42);
            this.LabelNassentos.Name = "LabelNassentos";
            this.LabelNassentos.Size = new System.Drawing.Size(19, 13);
            this.LabelNassentos.TabIndex = 3;
            this.LabelNassentos.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(471, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assentos disponiveis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelConfirmar
            // 
            this.labelConfirmar.AutoSize = true;
            this.labelConfirmar.ForeColor = System.Drawing.Color.White;
            this.labelConfirmar.Location = new System.Drawing.Point(471, 109);
            this.labelConfirmar.Name = "labelConfirmar";
            this.labelConfirmar.Size = new System.Drawing.Size(97, 13);
            this.labelConfirmar.TabIndex = 5;
            this.labelConfirmar.Text = "Confirmar Assentos";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(452, 75);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(13, 13);
            this.label0.TabIndex = 6;
            this.label0.Text = "0";
            this.label0.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(471, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Assentos selecionados";
            // 
            // Assentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.labelConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelNassentos);
            this.Controls.Add(this.btnAssento3);
            this.Controls.Add(this.btnAssento2);
            this.Controls.Add(this.btnAssento1);
            this.Name = "Assentos";
            this.Text = "Assentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssento1;
        private System.Windows.Forms.Button btnAssento2;
        private System.Windows.Forms.Button btnAssento3;
        private System.Windows.Forms.Label LabelNassentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConfirmar;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label3;
    }
}