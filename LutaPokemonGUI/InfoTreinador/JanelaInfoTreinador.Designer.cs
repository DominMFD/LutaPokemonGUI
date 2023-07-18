namespace LutaPokemonGUI.InfoTreinador
{
    partial class JanelaInfoTreinador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaInfoTreinador));
            pictureBox1 = new PictureBox();
            lbTrainerName = new Label();
            lbNome = new Label();
            lbBatVenc = new Label();
            lbBatV = new Label();
            lbBatPerd = new Label();
            lbPokeCap = new Label();
            lbBatP = new Label();
            lbPC = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(69, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbTrainerName
            // 
            lbTrainerName.BackColor = Color.Transparent;
            lbTrainerName.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTrainerName.Location = new Point(130, 166);
            lbTrainerName.Name = "lbTrainerName";
            lbTrainerName.Size = new Size(243, 44);
            lbTrainerName.TabIndex = 1;
            lbTrainerName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbNome
            // 
            lbNome.BackColor = Color.Transparent;
            lbNome.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNome.Location = new Point(12, 166);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(88, 35);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome:";
            lbNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbBatVenc
            // 
            lbBatVenc.BackColor = Color.Transparent;
            lbBatVenc.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBatVenc.Location = new Point(130, 216);
            lbBatVenc.Name = "lbBatVenc";
            lbBatVenc.Size = new Size(243, 44);
            lbBatVenc.TabIndex = 3;
            lbBatVenc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbBatV
            // 
            lbBatV.BackColor = Color.Transparent;
            lbBatV.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbBatV.Location = new Point(12, 221);
            lbBatV.Name = "lbBatV";
            lbBatV.Size = new Size(132, 37);
            lbBatV.TabIndex = 4;
            lbBatV.Text = "Batalhas Vencidas:";
            lbBatV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbBatPerd
            // 
            lbBatPerd.BackColor = Color.Transparent;
            lbBatPerd.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBatPerd.Location = new Point(136, 277);
            lbBatPerd.Name = "lbBatPerd";
            lbBatPerd.Size = new Size(237, 44);
            lbBatPerd.TabIndex = 5;
            lbBatPerd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPokeCap
            // 
            lbPokeCap.BackColor = Color.Transparent;
            lbPokeCap.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbPokeCap.Location = new Point(136, 343);
            lbPokeCap.Name = "lbPokeCap";
            lbPokeCap.Size = new Size(243, 44);
            lbPokeCap.TabIndex = 6;
            lbPokeCap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbBatP
            // 
            lbBatP.BackColor = Color.Transparent;
            lbBatP.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbBatP.Location = new Point(12, 282);
            lbBatP.Name = "lbBatP";
            lbBatP.Size = new Size(134, 37);
            lbBatP.TabIndex = 7;
            lbBatP.Text = "Batalhas Perdidas:";
            lbBatP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPC
            // 
            lbPC.BackColor = Color.Transparent;
            lbPC.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbPC.Location = new Point(12, 343);
            lbPC.Name = "lbPC";
            lbPC.Size = new Size(162, 37);
            lbPC.TabIndex = 8;
            lbPC.Text = "Pokemons Capturados:";
            lbPC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(170, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 38);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // JanelaInfoTreinador
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(413, 558);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(lbPC);
            this.Controls.Add(lbBatP);
            this.Controls.Add(lbPokeCap);
            this.Controls.Add(lbBatPerd);
            this.Controls.Add(lbBatV);
            this.Controls.Add(lbBatVenc);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbTrainerName);
            this.Controls.Add(pictureBox1);
            this.MaximumSize = new Size(429, 597);
            this.MinimumSize = new Size(429, 597);
            this.Name = "JanelaInfoTreinador";
            this.Text = "Informações do Treinador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        public Label lbTrainerName;
        private Label lbNome;
        public Label lbBatVenc;
        private Label lbBatV;
        public Label lbBatPerd;
        public Label lbPokeCap;
        private Label lbBatP;
        private Label lbPC;
        private PictureBox pictureBox2;
    }
}