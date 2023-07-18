namespace LutaPokemonGUI.PokemonsCapturados
{
    partial class PokemonsCapturados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonsCapturados));
            lvPokesCap = new ListView();
            colID = new ColumnHeader();
            colNome = new ColumnHeader();
            colElemento = new ColumnHeader();
            colLevel = new ColumnHeader();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lvPokesCap
            // 
            lvPokesCap.AccessibleRole = AccessibleRole.MenuPopup;
            lvPokesCap.Activation = ItemActivation.TwoClick;
            lvPokesCap.BackColor = Color.PaleTurquoise;
            lvPokesCap.Columns.AddRange(new ColumnHeader[] { colID, colNome, colElemento, colLevel });
            lvPokesCap.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lvPokesCap.Location = new Point(32, 118);
            lvPokesCap.MaximumSize = new Size(327, 355);
            lvPokesCap.MinimumSize = new Size(327, 355);
            lvPokesCap.Name = "lvPokesCap";
            lvPokesCap.Size = new Size(327, 355);
            lvPokesCap.TabIndex = 0;
            lvPokesCap.UseCompatibleStateImageBehavior = false;
            lvPokesCap.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "#";
            colID.Width = 40;
            // 
            // colNome
            // 
            colNome.Text = "Nome";
            colNome.TextAlign = HorizontalAlignment.Center;
            colNome.Width = 90;
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
            colLevel.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 58);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(56, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 46);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // PokemonsCapturados
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(393, 497);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(lvPokesCap);
            this.MaximumSize = new Size(409, 536);
            this.MinimumSize = new Size(409, 536);
            this.Name = "PokemonsCapturados";
            this.Text = "PokemonsCapturados";
            Load += PokemonsCapturados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListView lvPokesCap;
        private PictureBox pictureBox1;
        private ColumnHeader colID;
        private ColumnHeader colNome;
        private ColumnHeader colElemento;
        private ColumnHeader colLevel;
        private PictureBox pictureBox2;
    }
}