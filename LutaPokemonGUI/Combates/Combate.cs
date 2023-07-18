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
                label1.Text = pokeEscolhido.nome;
                label2.Text = pokeSelvagem.nome;
                label3.Text = pokeEscolhido.vida.ToString();
                label4.Text = pokeSelvagem.vida.ToString();
                btAttack1.Text = pokeEscolhido.golpes[0].Nome;
                btAttack2.Text = pokeEscolhido.golpes[1].Nome;
                btAttack3.Text = pokeEscolhido.golpes[2].Nome;
                btAttack4.Text = pokeEscolhido.golpes[3].Nome;
                this.vidapokejogador = pokeEscolhido.vida;
                this.vidapokeselvagem = pokeSelvagem.vida;
                lblDanoSelvagem.Text = "";
                lbDanoJogador.Text = "";
                label5.Text = pokeEscolhido.vida.ToString();
                label6.Text = pokeSelvagem.vida.ToString();
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
            int random = r.Next(0, pokeSelvagem.golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.forca + pokeEscolhido.golpes[0].Poder + (pokeEscolhido.forca * 0.5);
            double WildDamage = pokeSelvagem.forca + pokeEscolhido.golpes[random].Poder + (pokeEscolhido.forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.nome} ataca {pokeSelvagem.nome} usando {pokeEscolhido.golpes[0].Nome} e causando {PlayerDamage - pokeSelvagem.def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.nome} ataca {pokeEscolhido.nome} usando {pokeSelvagem.golpes[random].Nome} e causando {WildDamage - pokeEscolhido.def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.nome} ganhou a batalha!!!\n{pokeEscolhido.nome} recebeu {xp} de experiência");
                pokeEscolhido.exp = pokeEscolhido.exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.batVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.batPerd++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();

            }
        }

        private void btAttack2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random = r.Next(0, pokeSelvagem.golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.forca + pokeEscolhido.golpes[1].Poder + (pokeEscolhido.forca * 0.5);
            double WildDamage = pokeSelvagem.forca + pokeEscolhido.golpes[random].Poder + (pokeEscolhido.forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.nome} ataca {pokeSelvagem.nome} usando {pokeEscolhido.golpes[1].Nome} e causando {PlayerDamage - pokeSelvagem.def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.nome} ataca {pokeEscolhido.nome} usando {pokeSelvagem.golpes[random].Nome} e causando {WildDamage - pokeEscolhido.def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.nome} ganhou a batalha!!!\n{pokeEscolhido.nome} recebeu {xp} de experiência");
                pokeEscolhido.exp = pokeEscolhido.exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.batVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.batPerd++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
        }

        private void btAttack3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random = r.Next(0, pokeSelvagem.golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.forca + pokeEscolhido.golpes[2].Poder + (pokeEscolhido.forca * 0.5);
            double WildDamage = pokeSelvagem.forca + pokeEscolhido.golpes[random].Poder + (pokeEscolhido.forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.nome} ataca {pokeSelvagem.nome} usando {pokeEscolhido.golpes[2].Nome} e causando {PlayerDamage - pokeSelvagem.def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.nome} ataca {pokeEscolhido.nome} usando {pokeSelvagem.golpes[random].Nome} e causando {WildDamage - pokeEscolhido.def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.nome} ganhou a batalha!!!\n{pokeEscolhido.nome} recebeu {xp} de experiência");
                pokeEscolhido.exp = pokeEscolhido.exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.batVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.batPerd++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
        }

        private void btAttack4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random = r.Next(0, pokeSelvagem.golpes.Length);
            int xp = r.Next(20, 45);
            double PlayerDamage = pokeEscolhido.forca + pokeEscolhido.golpes[3].Poder + (pokeEscolhido.forca * 0.5);
            double WildDamage = pokeSelvagem.forca + pokeEscolhido.golpes[random].Poder + (pokeEscolhido.forca * 0.5);

            lbDanoJogador.Text = $"{pokeEscolhido.nome} ataca {pokeSelvagem.nome} usando {pokeEscolhido.golpes[3].Nome} e causando {PlayerDamage - pokeSelvagem.def} de dano.";
            vidapokeselvagem = vidapokeselvagem - (PlayerDamage - pokeSelvagem.def);
            if (vidapokeselvagem > 0)
            {
                LifeColorsEnemy();
                label4.Text = vidapokeselvagem.ToString();

                lblDanoSelvagem.Text = $"{pokeSelvagem.nome} ataca {pokeEscolhido.nome} usando {pokeSelvagem.golpes[random].Nome} e causando {WildDamage - pokeEscolhido.def} de dano.";
                vidapokejogador = vidapokejogador - (WildDamage - pokeEscolhido.def);
                if (vidapokejogador > 0)
                {
                    LifeColorsAlly();
                    label3.Text = vidapokejogador.ToString();

                }
            }
            if (vidapokeselvagem <= 0)
            {
                label4.Text = "0";
                MessageBox.Show($"{pokeEscolhido.nome} ganhou a batalha!!!\n{pokeEscolhido.nome} recebeu {xp} de experiência");
                pokeEscolhido.exp = pokeEscolhido.exp + xp;
                pokeEscolhido.SubirNivel();
                LutaPokemonGUI.AreaDeTrab.Trainer.batVenc++;
                LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                AreaDeTrab.SoundMenu.Play();
            }
            if (vidapokejogador <= 0)
            {
                label3.Text = "0";
                MessageBox.Show($"{pokeSelvagem.nome} ganhou a batalha");
                LutaPokemonGUI.AreaDeTrab.Trainer.batPerd++;
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
            if (pokeEscolhido.elemento == "Planta")
            {
                btAttack1.BackColor = Color.DarkGreen;
                btAttack2.BackColor = Color.DarkGreen;
                btAttack3.BackColor = Color.DarkGreen;
                btAttack4.BackColor = Color.DarkGreen;
            }
            else if (pokeEscolhido.elemento == "Fogo")
            {
                btAttack1.BackColor = Color.Orange;
                btAttack2.BackColor = Color.Orange;
                btAttack3.BackColor = Color.Orange;
                btAttack4.BackColor = Color.Orange;
            }
            else if (pokeEscolhido.elemento == "Agua")
            {
                btAttack1.BackColor = Color.Aqua;
                btAttack2.BackColor = Color.Aqua;
                btAttack3.BackColor = Color.Aqua;
                btAttack4.BackColor = Color.Aqua;
            }
            else if (pokeEscolhido.elemento == "Eletrico")
            {
                btAttack1.BackColor = Color.Yellow;
                btAttack2.BackColor = Color.Yellow;
                btAttack3.BackColor = Color.Yellow;
                btAttack4.BackColor = Color.Yellow;
            }
            else if (pokeEscolhido.elemento == "Voador")
            {
                btAttack1.BackColor = Color.Wheat;
                btAttack2.BackColor = Color.Wheat;
                btAttack3.BackColor = Color.Wheat;
                btAttack4.BackColor = Color.Wheat;
            }
            else if (pokeEscolhido.elemento == "Normal")
            {
                btAttack1.BackColor = Color.Coral;
                btAttack2.BackColor = Color.Coral;
                btAttack3.BackColor = Color.Coral;
                btAttack4.BackColor = Color.Coral;
            }
            else if (pokeEscolhido.elemento == "Veneno")
            {
                btAttack1.BackColor = Color.Indigo;
                btAttack2.BackColor = Color.Indigo;
                btAttack3.BackColor = Color.Indigo;
                btAttack4.BackColor = Color.Indigo;
            }
            else if (pokeEscolhido.elemento == "Inseto")
            {
                btAttack1.BackColor = Color.YellowGreen;
                btAttack2.BackColor = Color.YellowGreen;
                btAttack3.BackColor = Color.YellowGreen;
                btAttack4.BackColor = Color.YellowGreen;
            }
            else if (pokeEscolhido.elemento == "Terra")
            {
                btAttack1.BackColor = Color.Tan;
                btAttack2.BackColor = Color.Tan;
                btAttack3.BackColor = Color.Tan;
                btAttack4.BackColor = Color.Tan;
            }
            else if (pokeEscolhido.elemento == "Lutador")
            {
                btAttack1.BackColor = Color.DarkRed;
                btAttack2.BackColor = Color.DarkRed;
                btAttack3.BackColor = Color.DarkRed;
                btAttack4.BackColor = Color.DarkRed;
            }
            else if (pokeEscolhido.elemento == "Psiquico")
            {
                btAttack1.BackColor = Color.Violet;
                btAttack2.BackColor = Color.Violet;
                btAttack3.BackColor = Color.Violet;
                btAttack4.BackColor = Color.Violet;
            }
            else if (pokeEscolhido.elemento == "Pedra")
            {
                btAttack1.BackColor = Color.Gray;
                btAttack2.BackColor = Color.Gray;
                btAttack3.BackColor = Color.Gray;
                btAttack4.BackColor = Color.Gray;
            }
        }

        private void LifeColorsAlly()
        {
            if (vidapokejogador == pokeEscolhido.vida)
            {
                label3.ForeColor = Color.LimeGreen;
            }
            if (vidapokejogador > 140 && vidapokejogador < pokeEscolhido.vida)
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
            if (vidapokeselvagem == pokeSelvagem.vida)
            {
                label4.ForeColor = Color.LimeGreen;
            }
            if (vidapokeselvagem > 140 && vidapokejogador < pokeSelvagem.vida)
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
