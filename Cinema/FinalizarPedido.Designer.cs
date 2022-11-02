namespace Cinema
{
    partial class FinalizarPedido
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
            this.LabelNomeFilme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHorarioSessao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelAssento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCpf = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImgFilmes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeFilme
            // 
            this.LabelNomeFilme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNomeFilme.AutoSize = true;
            this.LabelNomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeFilme.ForeColor = System.Drawing.Color.White;
            this.LabelNomeFilme.Location = new System.Drawing.Point(211, 44);
            this.LabelNomeFilme.Name = "LabelNomeFilme";
            this.LabelNomeFilme.Size = new System.Drawing.Size(62, 24);
            this.LabelNomeFilme.TabIndex = 0;
            this.LabelNomeFilme.Text = "Filme";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sessão";
            // 
            // labelHorarioSessao
            // 
            this.labelHorarioSessao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHorarioSessao.AutoSize = true;
            this.labelHorarioSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioSessao.ForeColor = System.Drawing.Color.White;
            this.labelHorarioSessao.Location = new System.Drawing.Point(485, 44);
            this.labelHorarioSessao.Name = "labelHorarioSessao";
            this.labelHorarioSessao.Size = new System.Drawing.Size(21, 24);
            this.labelHorarioSessao.TabIndex = 3;
            this.labelHorarioSessao.Text = "0";
            this.labelHorarioSessao.Click += new System.EventHandler(this.labelHorarioSessao_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assentos";
            // 
            // LabelAssento
            // 
            this.LabelAssento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAssento.AutoSize = true;
            this.LabelAssento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAssento.ForeColor = System.Drawing.Color.White;
            this.LabelAssento.Location = new System.Drawing.Point(14, 316);
            this.LabelAssento.Name = "LabelAssento";
            this.LabelAssento.Size = new System.Drawing.Size(38, 20);
            this.LabelAssento.TabIndex = 5;
            this.LabelAssento.Text = "abc";
            this.LabelAssento.Click += new System.EventHandler(this.LabelAssento_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(366, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dados do cpf";
            // 
            // LabelCpf
            // 
            this.LabelCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelCpf.AutoSize = true;
            this.LabelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCpf.ForeColor = System.Drawing.Color.White;
            this.LabelCpf.Location = new System.Drawing.Point(367, 405);
            this.LabelCpf.Name = "LabelCpf";
            this.LabelCpf.Size = new System.Drawing.Size(35, 20);
            this.LabelCpf.TabIndex = 7;
            this.LabelCpf.Text = "abc";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 4);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(291, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 448);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "BAIXAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Cinema.Properties.Resources.X;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(538, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ImgFilmes
            // 
            this.ImgFilmes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgFilmes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgFilmes.Location = new System.Drawing.Point(18, 31);
            this.ImgFilmes.Name = "ImgFilmes";
            this.ImgFilmes.Size = new System.Drawing.Size(173, 220);
            this.ImgFilmes.TabIndex = 1;
            this.ImgFilmes.TabStop = false;
            this.ImgFilmes.Click += new System.EventHandler(this.ImgFilmes_Click);
            // 
            // FinalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(574, 710);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelAssento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHorarioSessao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImgFilmes);
            this.Controls.Add(this.LabelNomeFilme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FinalizarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinalizarPedido";
            this.Load += new System.EventHandler(this.FinalizarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNomeFilme;
        private System.Windows.Forms.PictureBox ImgFilmes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHorarioSessao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelAssento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelCpf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}