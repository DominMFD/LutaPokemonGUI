using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LutaPokemonGUI.Combate
{
    public partial class Combate : Form
    {
        public static LutaPokemon.PokemonJogador pokeEscolhido = new LutaPokemon.PokemonJogador();
        public LutaPokemon.Pokemon pokeSelvagem = new LutaPokemon.Pokemon();
        double vidapokejogador;
        double vidapokeselvagem;
        public static SoundPlayer SoundBattle = new SoundPlayer("Sounds/Battle.wav");
        SoundPlayer SoundPokeball = new SoundPlayer("Sounds/PokeBallCapturando.wav");
        public Combate()
        {
            InitializeComponent();
        }

        private void Combate_Load(object sender, EventArgs e)
        {
            SoundBattle.PlayLooping();
            pokeSelvagem = PokeSelvagem();
            SelecionarPokemon selecionarPokemon = new SelecionarPokemon();
            try
            {
                pokeEscolhido = AreaDeTrab.Trainer.Selecionar();

                BtnColors();
                pbPokeEscolhido.Image = pokeEscolhido.Image;
                pbPokeSelvagem.Image = pokeSelvagem.Image;
                label1.Text = pokeEscolhido.Nome;
                label2.Text = pokeSelvagem.Nome;
                label3.Text = pokeEscolhido.Vida.ToString();
                label4.Text = pokeSelvagem.Vida.ToString();
                btAttack1.Text = pokeEscolhido.Golpes[0].Nome;
                btAttack2.Text = pokeEscolhido.Golpes[1].Nome;
                btAttack3.Text = pokeEscolhido.Golpes[2].Nome;
                btAttack4.Text = pokeEscolhido.Golpes[3].Nome;
                this.vidapokejogador = pokeEscolhido.Vida;
                this.vidapokeselvagem = pokeSelvagem.Vida;
                lblDanoSelvagem.Text = "";
                lbDanoJogador.Text = "";
                label5.Text = pokeEscolhido.Vida.ToString();
                label6.Text = pokeSelvagem.Vida.ToString();
                LutaPokemonGUI.AreaDeTrab.selecionar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por Favor selecione um pokemon");
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
            }


        }
        private LutaPokemon.Pokemon PokeSelvagem()
        {
            List<LutaPokemon.Pokemon> pokesSelvagem = LutaPokemon.ListaPokemon.ListaPokemons();
            Random r = new Random();
            int random = r.Next(0, pokesSelvagem.Count);
            return pokesSelvagem[random];
        }

        private void btAttack1_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int random = r.Next(0, pokeSelvagem.Golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.Forca + pokeEscolhido.Golpes[0].Poder + (pokeEscolhido.Forca * 0.5);
            double WildDamage = pokeSelvagem.Forca + pokeEscolhido.Golpes[random].Poder + (pokeEscolhido.Forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.Nome} ataca {pokeSelvagem.Nome} usando {pokeEscolhido.Golpes[0].Nome} e causando {PlayerDamage - pokeSelvagem.Def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.Def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.Nome} ataca {pokeEscolhido.Nome} usando {pokeSelvagem.Golpes[random].Nome} e causando {WildDamage - pokeEscolhido.Def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.Def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.Nome} ganhou a batalha!!!\n{pokeEscolhido.Nome} recebeu {xp} de experiência");
                pokeEscolhido.Exp = pokeEscolhido.Exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.BatVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.Nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.BatPerd++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();

            }
        }

        private void btAttack2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random = r.Next(0, pokeSelvagem.Golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.Forca + pokeEscolhido.Golpes[1].Poder + (pokeEscolhido.Forca * 0.5);
            double WildDamage = pokeSelvagem.Forca + pokeEscolhido.Golpes[random].Poder + (pokeEscolhido.Forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.Nome} ataca {pokeSelvagem.Nome} usando {pokeEscolhido.Golpes[1].Nome} e causando {PlayerDamage - pokeSelvagem.Def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.Def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.Nome} ataca {pokeEscolhido.Nome} usando {pokeSelvagem.Golpes[random].Nome} e causando {WildDamage - pokeEscolhido.Def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.Def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.Nome} ganhou a batalha!!!\n{pokeEscolhido.Nome} recebeu {xp} de experiência");
                pokeEscolhido.Exp = pokeEscolhido.Exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.BatVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.Nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.BatPerd++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
        }

        private void btAttack3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random = r.Next(0, pokeSelvagem.Golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.Forca + pokeEscolhido.Golpes[2].Poder + (pokeEscolhido.Forca * 0.5);
            double WildDamage = pokeSelvagem.Forca + pokeEscolhido.Golpes[random].Poder + (pokeEscolhido.Forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.Nome} ataca {pokeSelvagem.Nome} usando {pokeEscolhido.Golpes[2].Nome} e causando {PlayerDamage - pokeSelvagem.Def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.Def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.Nome} ataca {pokeEscolhido.Nome} usando {pokeSelvagem.Golpes[random].Nome} e causando {WildDamage - pokeEscolhido.Def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.Def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.Nome} ganhou a batalha!!!\n{pokeEscolhido.Nome} recebeu {xp} de experiência");
                pokeEscolhido.Exp = pokeEscolhido.Exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.BatVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.Nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.BatPerd++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
        }

        private void btAttack4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random = r.Next(0, pokeSelvagem.Golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.Forca + pokeEscolhido.Golpes[3].Poder + (pokeEscolhido.Forca * 0.5);
            double WildDamage = pokeSelvagem.Forca + pokeEscolhido.Golpes[random].Poder + (pokeEscolhido.Forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.Nome} ataca {pokeSelvagem.Nome} usando {pokeEscolhido.Golpes[3].Nome} e causando {PlayerDamage - pokeSelvagem.Def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.Def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.Nome} ataca {pokeEscolhido.Nome} usando {pokeSelvagem.Golpes[random].Nome} e causando {WildDamage - pokeEscolhido.Def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.Def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.Nome} ganhou a batalha!!!\n{pokeEscolhido.Nome} recebeu {xp} de experiência");
                pokeEscolhido.Exp = pokeEscolhido.Exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.BatVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.Nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.BatPerd++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
        }

        private async void btnCapturar_Click(object sender, EventArgs e)
        {
            AreaDeTrab.SoundButton.Play();
            Random r = new Random();
            int tempo = r.Next(2800, 5000);
            if (vidapokejogador > 0)
            {
                if (CanCapture())
                {
                    pbPokeSelvagem.Image = Image.FromFile("Images/pokeball2.gif");
                    SoundPokeball.Play();
                    await Task.Delay(tempo);
                    LutaPokemonGUI.AreaDeTrab.Trainer.Capturar(pokeSelvagem);
                }

            }
            else
            {

            }

        }

        private void BtnColors()
        {
            if (pokeEscolhido.Elemento == "Planta")
            {
                btAttack1.BackColor = Color.DarkGreen;
                btAttack2.BackColor = Color.DarkGreen;
                btAttack3.BackColor = Color.DarkGreen;
                btAttack4.BackColor = Color.DarkGreen;
            }
            else if (pokeEscolhido.Elemento == "Fogo")
            {
                btAttack1.BackColor = Color.Orange;
                btAttack2.BackColor = Color.Orange;
                btAttack3.BackColor = Color.Orange;
                btAttack4.BackColor = Color.Orange;
            }
            else if (pokeEscolhido.Elemento == "Agua")
            {
                btAttack1.BackColor = Color.Aqua;
                btAttack2.BackColor = Color.Aqua;
                btAttack3.BackColor = Color.Aqua;
                btAttack4.BackColor = Color.Aqua;
            }
            else if (pokeEscolhido.Elemento == "Eletrico")
            {
                btAttack1.BackColor = Color.Yellow;
                btAttack2.BackColor = Color.Yellow;
                btAttack3.BackColor = Color.Yellow;
                btAttack4.BackColor = Color.Yellow;
            }
            else if (pokeEscolhido.Elemento == "Voador")
            {
                btAttack1.BackColor = Color.Wheat;
                btAttack2.BackColor = Color.Wheat;
                btAttack3.BackColor = Color.Wheat;
                btAttack4.BackColor = Color.Wheat;
            }
            else if (pokeEscolhido.Elemento == "Normal")
            {
                btAttack1.BackColor = Color.Coral;
                btAttack2.BackColor = Color.Coral;
                btAttack3.BackColor = Color.Coral;
                btAttack4.BackColor = Color.Coral;
            }
            else if (pokeEscolhido.Elemento == "Veneno")
            {
                btAttack1.BackColor = Color.Indigo;
                btAttack2.BackColor = Color.Indigo;
                btAttack3.BackColor = Color.Indigo;
                btAttack4.BackColor = Color.Indigo;
            }
            else if (pokeEscolhido.Elemento == "Inseto")
            {
                btAttack1.BackColor = Color.YellowGreen;
                btAttack2.BackColor = Color.YellowGreen;
                btAttack3.BackColor = Color.YellowGreen;
                btAttack4.BackColor = Color.YellowGreen;
            }
            else if (pokeEscolhido.Elemento == "Terra")
            {
                btAttack1.BackColor = Color.Tan;
                btAttack2.BackColor = Color.Tan;
                btAttack3.BackColor = Color.Tan;
                btAttack4.BackColor = Color.Tan;
            }
            else if (pokeEscolhido.Elemento == "Lutador")
            {
                btAttack1.BackColor = Color.DarkRed;
                btAttack2.BackColor = Color.DarkRed;
                btAttack3.BackColor = Color.DarkRed;
                btAttack4.BackColor = Color.DarkRed;
            }
            else if (pokeEscolhido.Elemento == "Psiquico")
            {
                btAttack1.BackColor = Color.Violet;
                btAttack2.BackColor = Color.Violet;
                btAttack3.BackColor = Color.Violet;
                btAttack4.BackColor = Color.Violet;
            }
            else if (pokeEscolhido.Elemento == "Pedra")
            {
                btAttack1.BackColor = Color.Gray;
                btAttack2.BackColor = Color.Gray;
                btAttack3.BackColor = Color.Gray;
                btAttack4.BackColor = Color.Gray;
            }
        }

        private void LifeColorsAlly()
        {
            if (vidapokejogador == pokeEscolhido.Vida)
            {
                label3.ForeColor = Color.LimeGreen;
            }
            if (vidapokejogador > 140 && vidapokejogador < pokeEscolhido.Vida)
            {
                label3.ForeColor = Color.PaleGreen;
            }
            if (vidapokejogador < 140 && vidapokejogador > 90)
            {
                label3.ForeColor = Color.Khaki;
            }
            if (vidapokejogador < 90 && vidapokejogador > 35)
            {
                label3.ForeColor = Color.LightCoral;
            }
            if (vidapokejogador < 35)
            {
                label3.ForeColor = Color.Red;
            }
        }

        private void LifeColorsEnemy()
        {
            if (vidapokeselvagem == pokeSelvagem.Vida)
            {
                label4.ForeColor = Color.LimeGreen;
            }
            if (vidapokeselvagem > 140 && vidapokejogador < pokeSelvagem.Vida)
            {
                label4.ForeColor = Color.PaleGreen;
            }
            if (vidapokeselvagem < 140 && vidapokeselvagem > 90)
            {
                label4.ForeColor = Color.Khaki;
            }
            if (vidapokeselvagem < 90 && vidapokeselvagem > 35)
            {
                label4.ForeColor = Color.LightCoral;
            }
            if (vidapokeselvagem < 35)
            {
                label4.ForeColor = Color.Red;
            }
        }

        public bool CanCapture()
        {
            return vidapokejogador <= 130 && vidapokejogador > 0;
        }
    }
}
