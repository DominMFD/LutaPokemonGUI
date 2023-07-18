using LutaPokemonGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    public class PokemonJogador : Pokemon
    {
        public int nivel;


        public int exp { set; get; }

        public PokemonJogador() : base() 
        {
            this.nivel = 1;
            this.exp = 0;
        }

        public PokemonJogador(string nome, string elemento, int forca, double vida, int def, Golpe[] golpes, Image image) : base(nome, elemento, forca, vida, def, golpes, image)
        {
            this.nivel = 1;
            this.exp = 0;
        }


        public void SubirNivel()
        {
            SoundPlayer sound = new SoundPlayer("Sounds/LevelUp.wav");
            if (exp >= 100)
            {
                sound.Play();
                nivel++;
                MessageBox.Show("Seu pokemon subiu para o nivel " + nivel);
                exp = exp - 100;
                Task.Delay(1000);    
            }
        }
       

    }
}
