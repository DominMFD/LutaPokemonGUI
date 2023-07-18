namespace LutaPokemonGUI.Combate
{
    partial class SelecionarPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarPokemon));
            pictureBox1 = new PictureBox();
            lvSelecionarPoke = new ListView();
            colID = new ColumnHeader();
            colNome = new ColumnHeader();
            colElemento = new ColumnHeader();
            colLevel = new ColumnHeader();
            btComecarJogo = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(48, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 49);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lvSelecionarPoke
            // 
            lvSelecionarPoke.BackColor = Color.PaleTurquoise;
            lvSelecionarPoke.Columns.AddRange(new ColumnHeader[] { colID, colNome, colElemento, colLevel });
            lvSelecionarPoke.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lvSelecionarPoke.Location = new Point(48, 126);
            lvSelecionarPoke.Name = "lvSelecionarPoke";
            lvSelecionarPoke.Size = new Size(269, 279);
            lvSelecionarPoke.TabIndex = 1;
            lvSelecionarPoke.UseCompatibleStateImageBehavior = false;
            lvSelecionarPoke.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "#";
            colID.Width = 30;
            // 
            // colNome
            // 
            colNome.Text = "Nome";
            colNome.TextAlign = HorizontalAlignment.Center;
            // 
            // colElemento
            // 
            colElemento.Text = "Elemento";
            colElemento.TextAlign = HorizontalAlignment.Center;
            colElemento.Width = 100;
            // 
            // colLevel
            // 
            colLevel.Text = "Level";
            colLevel.TextAlign = HorizontalAlignment.Center;
            // 
            // btComecarJogo
            // 
            btComecarJogo.BackgroundImage = (Image)resources.GetObject("btComecarJogo.BackgroundImage");
            btComecarJogo.FlatStyle = FlatStyle.Popup;
            btComecarJogo.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btComecarJogo.Location = new Point(48, 421);
            btComecarJogo.Name = "btComecarJogo";
            btComecarJogo.Size = new Size(269, 48);
            btComecarJogo.TabIndex = 2;
            btComecarJogo.Text = "Começar Batalha";
            btComecarJogo.UseVisualStyleBackColor = true;
            btComecarJogo.Click += btComecarJogo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(48, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 44);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // SelecionarPokemon
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(372, 502);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(btComecarJogo);
            this.Controls.Add(lvSelecionarPoke);
            this.Controls.Add(pictureBox1);
            this.MaximumSize = new Size(388, 541);
            this.MinimumSize = new Size(388, 541);
            this.Name = "SelecionarPokemon";
            this.Text = "SelecionarPokemon";
            Load += SelecionarPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        public ListView lvSelecionarPoke;
        private ColumnHeader colID;
        private ColumnHeader colNome;
        private ColumnHeader colElemento;
        private ColumnHeader colLevel;
        private Button btComecarJogo;
        private PictureBox pictureBox2;
    }
}