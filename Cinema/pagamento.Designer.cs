namespace Cinema
{
    partial class Pagamento
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelforma = new System.Windows.Forms.Label();
            this.labelpix = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelcpf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.ComboCard = new System.Windows.Forms.ComboBox();
            this.imgCartao = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCartao)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(867, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crédito/Débito";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(867, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "PicPay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(867, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pix";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelforma
            // 
            this.labelforma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelforma.AutoSize = true;
            this.labelforma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelforma.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelforma.Location = new System.Drawing.Point(593, 239);
            this.labelforma.Name = "labelforma";
            this.labelforma.Size = new System.Drawing.Size(269, 21);
            this.labelforma.TabIndex = 3;
            this.labelforma.Text = "Escolha o método de pagamento :";
            this.labelforma.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelpix
            // 
            this.labelpix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpix.AutoSize = true;
            this.labelpix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelpix.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelpix.Location = new System.Drawing.Point(743, 438);
            this.labelpix.Name = "labelpix";
            this.labelpix.Size = new System.Drawing.Size(89, 21);
            this.labelpix.TabIndex = 4;
            this.labelpix.Text = "Chave Pix:";
            this.labelpix.Visible = false;
            this.labelpix.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(862, 445);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelcpf
            // 
            this.labelcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcpf.AutoSize = true;
            this.labelcpf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelcpf.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcpf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelcpf.Location = new System.Drawing.Point(725, 438);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(107, 21);
            this.labelcpf.TabIndex = 7;
            this.labelcpf.Text = "Digite o CPF:";
            this.labelcpf.Visible = false;
            this.labelcpf.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(689, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bandeira do cartão:";
            this.label4.Visible = false;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirmar.BackColor = System.Drawing.Color.Red;
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnConfirmar.Location = new System.Drawing.Point(1173, 500);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(134, 32);
            this.BtnConfirmar.TabIndex = 25;
            this.BtnConfirmar.Text = "PROSSEGUIR";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Visible = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // ComboCard
            // 
            this.ComboCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboCard.FormattingEnabled = true;
            this.ComboCard.Items.AddRange(new object[] {
            "VISA",
            "MasterCard",
            "Elo",
            "Banco do Brasil"});
            this.ComboCard.Location = new System.Drawing.Point(862, 438);
            this.ComboCard.Name = "ComboCard";
            this.ComboCard.Size = new System.Drawing.Size(121, 21);
            this.ComboCard.TabIndex = 26;
            this.ComboCard.Text = "Escolha o Cartão";
            this.ComboCard.Visible = false;
            this.ComboCard.SelectedIndexChanged += new System.EventHandler(this.ComboCard_SelectedIndexChanged);
            // 
            // imgCartao
            // 
            this.imgCartao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCartao.BackgroundImage = global::Cinema.Properties.Resources.Visa_logo;
            this.imgCartao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCartao.Image = global::Cinema.Properties.Resources.elo_logo2;
            this.imgCartao.Location = new System.Drawing.Point(747, 482);
            this.imgCartao.Name = "imgCartao";
            this.imgCartao.Size = new System.Drawing.Size(100, 50);
            this.imgCartao.TabIndex = 27;
            this.imgCartao.TabStop = false;
            this.imgCartao.Visible = false;
            this.imgCartao.Click += new System.EventHandler(this.imgCartao_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(572, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 7);
            this.panel3.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(592, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pagamento";
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.imgCartao);
            this.Controls.Add(this.ComboCard);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelforma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelcpf);
            this.Controls.Add(this.labelpix);
            this.Name = "Pagamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCartao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelforma;
        private System.Windows.Forms.Label labelpix;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.ComboBox ComboCard;
        private System.Windows.Forms.PictureBox imgCartao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
    }
}