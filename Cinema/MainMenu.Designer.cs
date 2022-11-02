namespace Cinema
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelNomeFilme = new System.Windows.Forms.Label();
            this.PanelLine1 = new System.Windows.Forms.Panel();
            this.labelSinopse = new System.Windows.Forms.Label();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.PanelLine2 = new System.Windows.Forms.Panel();
            this.labelhoraio = new System.Windows.Forms.Label();
            this.ImgFilmes = new System.Windows.Forms.PictureBox();
            this.ImgFilme3 = new System.Windows.Forms.PictureBox();
            this.ImgFilme2 = new System.Windows.Forms.PictureBox();
            this.imgFilme1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilme3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFilme1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(352, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 5);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(360, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Em Cartaz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelNomeFilme
            // 
            this.LabelNomeFilme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNomeFilme.AutoSize = true;
            this.LabelNomeFilme.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeFilme.ForeColor = System.Drawing.Color.White;
            this.LabelNomeFilme.Location = new System.Drawing.Point(556, 519);
            this.LabelNomeFilme.Name = "LabelNomeFilme";
            this.LabelNomeFilme.Size = new System.Drawing.Size(0, 28);
            this.LabelNomeFilme.TabIndex = 8;
            this.LabelNomeFilme.Click += new System.EventHandler(this.LabelNomeFilme_Click);
            // 
            // PanelLine1
            // 
            this.PanelLine1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelLine1.BackColor = System.Drawing.Color.White;
            this.PanelLine1.Location = new System.Drawing.Point(518, 550);
            this.PanelLine1.Name = "PanelLine1";
            this.PanelLine1.Size = new System.Drawing.Size(222, 4);
            this.PanelLine1.TabIndex = 5;
            this.PanelLine1.Visible = false;
            this.PanelLine1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelSinopse
            // 
            this.labelSinopse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSinopse.AutoSize = true;
            this.labelSinopse.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinopse.ForeColor = System.Drawing.Color.White;
            this.labelSinopse.Location = new System.Drawing.Point(556, 611);
            this.labelSinopse.Name = "labelSinopse";
            this.labelSinopse.Size = new System.Drawing.Size(93, 28);
            this.labelSinopse.TabIndex = 10;
            this.labelSinopse.Text = "blablabla";
            this.labelSinopse.Visible = false;
            this.labelSinopse.Click += new System.EventHandler(this.labelSinopse_Click);
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaracteristicas.ForeColor = System.Drawing.Color.White;
            this.labelCaracteristicas.Location = new System.Drawing.Point(556, 752);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(93, 28);
            this.labelCaracteristicas.TabIndex = 11;
            this.labelCaracteristicas.Text = "blablabla";
            this.labelCaracteristicas.Visible = false;
            this.labelCaracteristicas.Click += new System.EventHandler(this.labelCaracteristicas_Click);
            // 
            // PanelLine2
            // 
            this.PanelLine2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelLine2.BackColor = System.Drawing.Color.White;
            this.PanelLine2.Location = new System.Drawing.Point(376, 886);
            this.PanelLine2.Name = "PanelLine2";
            this.PanelLine2.Size = new System.Drawing.Size(628, 5);
            this.PanelLine2.TabIndex = 5;
            this.PanelLine2.Visible = false;
            this.PanelLine2.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLine2_Paint);
            // 
            // labelhoraio
            // 
            this.labelhoraio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelhoraio.AutoSize = true;
            this.labelhoraio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhoraio.ForeColor = System.Drawing.Color.White;
            this.labelhoraio.Location = new System.Drawing.Point(384, 861);
            this.labelhoraio.Name = "labelhoraio";
            this.labelhoraio.Size = new System.Drawing.Size(97, 21);
            this.labelhoraio.TabIndex = 12;
            this.labelhoraio.Text = "Ver Horários";
            this.labelhoraio.Visible = false;
            this.labelhoraio.Click += new System.EventHandler(this.labelhoraio_Click);
            // 
            // ImgFilmes
            // 
            this.ImgFilmes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImgFilmes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgFilmes.Location = new System.Drawing.Point(309, 509);
            this.ImgFilmes.Name = "ImgFilmes";
            this.ImgFilmes.Size = new System.Drawing.Size(190, 296);
            this.ImgFilmes.TabIndex = 7;
            this.ImgFilmes.TabStop = false;
            this.ImgFilmes.Click += new System.EventHandler(this.ImgFilmes_Click_1);
            // 
            // ImgFilme3
            // 
            this.ImgFilme3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImgFilme3.BackgroundImage = global::Cinema.Properties.Resources.Filme_minons22;
            this.ImgFilme3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgFilme3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgFilme3.Location = new System.Drawing.Point(814, 99);
            this.ImgFilme3.Name = "ImgFilme3";
            this.ImgFilme3.Size = new System.Drawing.Size(190, 296);
            this.ImgFilme3.TabIndex = 2;
            this.ImgFilme3.TabStop = false;
            this.ImgFilme3.Click += new System.EventHandler(this.ImgFilme3_Click);
            // 
            // ImgFilme2
            // 
            this.ImgFilme2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImgFilme2.BackgroundImage = global::Cinema.Properties.Resources.filme_orfa2;
            this.ImgFilme2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgFilme2.Location = new System.Drawing.Point(562, 99);
            this.ImgFilme2.Name = "ImgFilme2";
            this.ImgFilme2.Size = new System.Drawing.Size(190, 296);
            this.ImgFilme2.TabIndex = 1;
            this.ImgFilme2.TabStop = false;
            this.ImgFilme2.Click += new System.EventHandler(this.ImgFilme2_Click);
            // 
            // imgFilme1
            // 
            this.imgFilme1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgFilme1.BackgroundImage = global::Cinema.Properties.Resources.Filme_adao_negro1;
            this.imgFilme1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFilme1.Location = new System.Drawing.Point(309, 99);
            this.imgFilme1.Name = "imgFilme1";
            this.imgFilme1.Size = new System.Drawing.Size(190, 296);
            this.imgFilme1.TabIndex = 0;
            this.imgFilme1.TabStop = false;
            this.imgFilme1.Click += new System.EventHandler(this.imgFilme1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.labelhoraio);
            this.Controls.Add(this.PanelLine2);
            this.Controls.Add(this.labelCaracteristicas);
            this.Controls.Add(this.labelSinopse);
            this.Controls.Add(this.PanelLine1);
            this.Controls.Add(this.LabelNomeFilme);
            this.Controls.Add(this.ImgFilmes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImgFilme3);
            this.Controls.Add(this.ImgFilme2);
            this.Controls.Add(this.imgFilme1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilme3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFilme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFilme1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFilme1;
        private System.Windows.Forms.PictureBox ImgFilme2;
        private System.Windows.Forms.PictureBox ImgFilme3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImgFilmes;
        private System.Windows.Forms.Label LabelNomeFilme;
        private System.Windows.Forms.Panel PanelLine1;
        private System.Windows.Forms.Label labelSinopse;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.Panel PanelLine2;
        private System.Windows.Forms.Label labelhoraio;
    }
}

