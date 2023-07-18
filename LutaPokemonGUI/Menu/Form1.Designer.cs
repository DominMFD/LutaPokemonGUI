namespace LutaPokemonGUI
{
    partial class AreaDeTrab
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaDeTrab));
            pbLogo = new PictureBox();
            btInfoTrainer = new Button();
            btPokesCap = new Button();
            btBattle = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(236, 110);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(476, 119);
            pbLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // btInfoTrainer
            // 
            btInfoTrainer.BackColor = Color.Transparent;
            btInfoTrainer.BackgroundImage = (Image)resources.GetObject("btInfoTrainer.BackgroundImage");
            btInfoTrainer.Cursor = Cursors.Hand;
            btInfoTrainer.FlatStyle = FlatStyle.Popup;
            btInfoTrainer.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btInfoTrainer.ForeColor = Color.Black;
            btInfoTrainer.Location = new Point(346, 289);
            btInfoTrainer.Name = "btInfoTrainer";
            btInfoTrainer.Size = new Size(273, 44);
            btInfoTrainer.TabIndex = 2;
            btInfoTrainer.Text = "Informações do Treinador";
            btInfoTrainer.UseVisualStyleBackColor = false;
            btInfoTrainer.Click += btInfoTrainer_Click;
            // 
            // btPokesCap
            // 
            btPokesCap.BackColor = Color.Transparent;
            btPokesCap.BackgroundImage = (Image)resources.GetObject("btPokesCap.BackgroundImage");
            btPokesCap.Cursor = Cursors.Hand;
            btPokesCap.FlatStyle = FlatStyle.Popup;
            btPokesCap.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btPokesCap.ForeColor = Color.Black;
            btPokesCap.Location = new Point(346, 373);
            btPokesCap.Name = "btPokesCap";
            btPokesCap.Size = new Size(273, 44);
            btPokesCap.TabIndex = 3;
            btPokesCap.Text = "Pokemons Capturados";
            btPokesCap.UseVisualStyleBackColor = false;
            btPokesCap.Click += btPokesCap_Click;
            // 
            // btBattle
            // 
            btBattle.BackColor = Color.Transparent;
            btBattle.BackgroundImage = (Image)resources.GetObject("btBattle.BackgroundImage");
            btBattle.Cursor = Cursors.Hand;
            btBattle.FlatStyle = FlatStyle.Popup;
            btBattle.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btBattle.ForeColor = Color.Black;
            btBattle.Location = new Point(346, 455);
            btBattle.Name = "btBattle";
            btBattle.Size = new Size(273, 44);
            btBattle.TabIndex = 4;
            btBattle.Text = "Batalhar";
            btBattle.UseVisualStyleBackColor = false;
            btBattle.Click += btBattle_Click;
            // 
            // AreaDeTrab
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.SkyBlue;
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(900, 607);
            this.Controls.Add(btBattle);
            this.Controls.Add(btPokesCap);
            this.Controls.Add(btInfoTrainer);
            this.Controls.Add(pbLogo);
            this.MaximumSize = new Size(916, 646);
            this.MinimumSize = new Size(916, 646);
            this.Name = "AreaDeTrab";
            this.Text = "Luta Pokemon";
            Load += AreaDeTrab_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Button btInfoTrainer;
        private Button btPokesCap;
        private Button btBattle;
    }
}