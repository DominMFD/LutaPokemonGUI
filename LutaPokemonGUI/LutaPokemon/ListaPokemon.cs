using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    public class ListaPokemon
    {


        public static List<Pokemon> ListaPokemons()
        {
           // List<Pokemon> jsonPokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(File.ReadAllText("pokemon.json"));

     
            

            List<Pokemon> pokemons = new List<Pokemon>();
            Pokemon poke = new Pokemon("Bulbasaur", "Planta", 92, 200, 92, Golpe.setPlanta, Image.FromFile("Images/Bulbasaur2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Charmander", "Fogo", 98, 188, 81, Golpe.setFogo, Image.FromFile("Images/Charmander2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Squirtle", "Agua", 90, 198, 121, Golpe.setAgua, Image.FromFile("Images/Squirtle2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Pikachu", "Eletrico", 103, 180, 76, Golpe.setEletrico, Image.FromFile("Images/Pikachu2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Pidgey", "Voador", 85, 190, 76, Golpe.setVoador, Image.FromFile("Images/Pidgey2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Spearow", "Voador", 112, 190, 58, Golpe.setVoador, Image.FromFile("Images/Spearow2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Rattata", "Normal", 105, 170, 67, Golpe.setNormal, Image.FromFile("Images/Rattata2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Ekans", "Veneno", 112, 180, 83, Golpe.setVeneno, Image.FromFile("Images/Ekans2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Vulpix", "Fogo", 78, 186, 76, Golpe.setFogo, Image.FromFile("Images/Vulpix2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Zubat", "Veneno", 85, 190, 67, Golpe.setVeneno, Image.FromFile("Images/Zubat2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Oddish", "Planta", 94, 200, 103, Golpe.setPlanta, Image.FromFile("Images/Oddish2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Paras", "Inseto", 130, 180, 103, Golpe.setInseto, Image.FromFile("Images/Paras2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Diglett", "Terra", 103, 130, 49, Golpe.setTerra, Image.FromFile("Images/Diglett2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Psyduck", "Agua", 98, 210, 90, Golpe.setAgua, Image.FromFile("Images/Psyduck2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Mankey", "Lutador", 148, 190, 67, Golpe.setLutador, Image.FromFile("Images/Mankey2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Growlithe", "Fogo", 130, 220, 85, Golpe.setFogo, Image.FromFile("Images/Growlithe2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Poliwag", "Agua", 94, 190, 76, Golpe.setAgua, Image.FromFile("Images/Poliwag2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Abra", "Psiquico", 40, 160, 31, Golpe.setPsi, Image.FromFile("Images/Abra2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Machop", "Lutador", 148, 250, 94, Golpe.setLutador, Image.FromFile("Images/Machop2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Geodude", "Pedra", 148, 190, 184, Golpe.setPedra, Image.FromFile("Images/Geodude2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Ponyta", "Fogo", 157, 210, 103, Golpe.setFogo, Image.FromFile("Images/Ponyta2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Magnemite", "Eletrico", 67, 160, 130, Golpe.setEletrico, Image.FromFile("Images/Magnemite2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Voltorb", "Eletrico", 58, 190, 94, Golpe.setEletrico, Image.FromFile("Images/Voltorb2.png"));
            pokemons.Add(poke);
            poke = new Pokemon("Horsea", "Agua", 76, 170, 130, Golpe.setAgua, Image.FromFile("Images/Horsea2.png"));
            pokemons.Add(poke);
            return pokemons;
        }
    }
}
