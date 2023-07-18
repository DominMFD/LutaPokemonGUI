using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{

    public class Pokemon
    {
        public string Nome { get; set; }
        public string Elemento { get; set; }
        public int Forca { get; set; }
        public double Vida { get; set; }
        public int Def { get; set; }
        public Golpe[] Golpes { get; set; }
        public Image Image { get; set; }
        public static Random r = new Random();

        public Pokemon()
        {

        }
        public Pokemon(string nome, string elemento, int forca, double vida, int def, Golpe[] golpes, Image image)
        {
            this.Golpes = golpes;
            this.Nome = nome;
            this.Elemento = elemento;
            this.Forca = forca;
            this.Vida = vida;
            this.Def = def;
            this.Golpes = golpes;
            this.Image = image;
        }
    }
}
