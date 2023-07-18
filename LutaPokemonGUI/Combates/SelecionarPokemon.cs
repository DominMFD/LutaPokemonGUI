using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LutaPokemonGUI.Combate
{
    public partial class SelecionarPokemon : Form
    {
        public static SelecionarPokemon Instance { get; private set; }
        public int id;
        public static Combate combate = new Combate();
        public SelecionarPokemon()
        {
            InitializeComponent();

        }

        private void SelecionarPokemon_Load(object sender, EventArgs e)
        {
            Instance = this;

            int id = 0;

            foreach (var pokemon in LutaPokemonGUI.AreaDeTrab.Trainer.pokesJogador)
            {
                ListViewItem pokelista = new ListViewItem(id.ToString());
                pokelista.SubItems.Add(pokemon.nome);
                pokelista.SubItems.Add(pokemon.elemento);
                pokelista.SubItems.Add(pokemon.nivel.ToString());

                lvSelecionarPoke.Items.Add(pokelista);
                id++;
            }
        }

        private void btComecarJogo_Click(object sender, EventArgs e)
        {
            AreaDeTrab.SoundButton.Play();
            combate = new Combate();
            combate.Show();
            LutaPokemonGUI.AreaDeTrab.selecionar.Close();
        }
    }
}
