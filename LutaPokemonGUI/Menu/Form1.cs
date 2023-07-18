using LutaPokemon;
using LutaPokemonGUI.Combate;
using System.Media;

namespace LutaPokemonGUI
{
    public partial class AreaDeTrab : Form
    {
        public static Jogador Trainer = new Jogador("Domiinguera");
        public static SelecionarPokemon selecionar = new SelecionarPokemon();
        public static SoundPlayer SoundMenu = new SoundPlayer("Sounds/Opening.wav");
        public static SoundPlayer SoundButton = new SoundPlayer("Sounds/ButtonClick.wav");


        public AreaDeTrab()
        {
            InitializeComponent();
            Trainer.PokemonInicial();
            SoundMenu.PlayLooping();
        }

        private async void btInfoTrainer_Click(object sender, EventArgs e)
        {
            SoundButton.Play();
            InfoTreinador.JanelaInfoTreinador janela = new InfoTreinador.JanelaInfoTreinador();
            janela.lbTrainerName.Text = Trainer.nome;
            janela.lbBatVenc.Text = Trainer.batVenc.ToString();
            janela.lbBatPerd.Text = Trainer.batPerd.ToString();
            janela.lbPokeCap.Text = Trainer.pokeCap.ToString();

            janela.Show();
            await Task.Delay(1000);
            SoundMenu.Play();

        }

        private async void btPokesCap_Click(object sender, EventArgs e)
        {
            SoundButton.Play();
            PokemonsCapturados.PokemonsCapturados pokecap = new PokemonsCapturados.PokemonsCapturados();
            pokecap.Show();
            await Task.Delay(1000);
            SoundMenu.Play();

        }

        private void btBattle_Click(object sender, EventArgs e)
        {
            SoundMenu.Stop();
            SoundButton.Play();
            selecionar = new SelecionarPokemon();
            LutaPokemon.Golpe.ListadeGolpes();
            LutaPokemon.ListaPokemon.ListaPokemons();
            selecionar.Show();
        }

        private void AreaDeTrab_Load(object sender, EventArgs e)
        {

        }
    }
}