using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LutaPokemonGUI.PokemonsCapturados
{
    public partial class PokemonsCapturados : Form
    {
        public PokemonsCapturados()
        {
            InitializeComponent();
        }

        private void PokemonsCapturados_Load(object sender, EventArgs e)
        {
            int id = 0;

            foreach (var pokemon in LutaPokemonGUI.AreaDeTrab.Trainer.pokesJogador)
            {
                ListViewItem pokelista = new ListViewItem(id.ToString());
                pokelista.SubItems.Add(pokemon.nome);
                pokelista.SubItems.Add(pokemon.elemento);
                pokelista.SubItems.Add(pokemon.nivel.ToString());

                lvPokesCap.Items.Add(pokelista);
                id++;
            }
        }
    }
}
