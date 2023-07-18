using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{

    public class Pokemon
    {
        public string nome { get; set; }
        public string elemento { get; set; }
        public int forca { get; set; }
        public double vida { get; set; }
        public int def { get; set; }
        public Golpe[] golpes { get; set; }
        public Image Image { get; set; }
        public static Random r = new Random();

        public Pokemon()
        {

        }
        public Pokemon(string nome, string elemento, int forca, double vida, int def, Golpe[] golpes, Image image)
        {
            this.golpes = golpes;
            this.nome = nome;
            this.elemento = elemento;
            this.forca = forca;
            this.vida = vida;
            this.def = def;
            this.golpes = golpes;
            this.Image = image;
        }
    }
}
