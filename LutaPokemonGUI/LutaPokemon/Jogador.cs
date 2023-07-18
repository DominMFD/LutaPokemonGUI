using LutaPokemonGUI;
using LutaPokemonGUI.Combate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

 namespace LutaPokemon
{
    public class Jogador
    {
        public string Nome { set; get; }
        public int BatVenc { set; get; }
        public int BatPerd { set; get; }
        public int PokeCap { set; get; } 

        public Jogador() 
        {

        }
        public Jogador(string nome)
        {
            this.Nome = nome;
  
        }

        public List<PokemonJogador> pokesJogador = new List<PokemonJogador>();

        public void PokemonInicial()
        {
            PokemonJogador pokemon = new PokemonJogador("Bulbasaur", "Planta", 92, 200, 92, Golpe.setPlanta, Image.FromFile("Images/Bulbasaur.png"));
            pokesJogador.Add(pokemon);
            PokeCap++;
        }



        

        public PokemonJogador Selecionar() 
        {

            string nomePoke = SelecionarPokemon.Instance.lvSelecionarPoke.SelectedItems[0].SubItems[1].Text;
            PokemonJogador poke = pokesJogador.Find(x => x.Nome == nomePoke);
           

            return poke;
        }


        public void Capturar(Pokemon pokemonSelvagem)
        {
                SoundPlayer sound = new SoundPlayer();
                Random r = new Random();
                PokemonJogador poke = new PokemonJogador();
                List<PokemonJogador> pokeencontrado = pokesJogador.FindAll(delegate (PokemonJogador p)
                {
                    return p.Nome.Equals(pokemonSelvagem.Nome);
                });

                int catchRate = r.Next(0, 100);
                int pokeFugir = r.Next(0, 100);
              


                if (pokeencontrado.Count() > 0)
                {
                    LutaPokemonGUI.Combate.SelecionarPokemon.combate.pbPokeSelvagem.Image = LutaPokemonGUI.Combate.SelecionarPokemon.combate.pokeSelvagem.Image;
                    MessageBox.Show("Voce já possui esse pokemon");
                    
                    sound = new SoundPlayer("Sounds/Battle.wav");
                    sound.Play();
                    
            }
                else
                {
                    if (catchRate > 48)
                    {
                        sound = new SoundPlayer("Sounds/PokemonCapturou.wav");
                        sound.Play();
                        poke = new PokemonJogador(pokemonSelvagem.Nome, pokemonSelvagem.Elemento, pokemonSelvagem.Forca, pokemonSelvagem.Vida, pokemonSelvagem.Def, pokemonSelvagem.Golpes, Image.FromFile($"Images/{pokemonSelvagem.Nome}.png"));
                        pokesJogador.Add(poke);
                        MessageBox.Show("Parabens!!! Voce capturou um " + pokemonSelvagem.Nome);
                        LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                        AreaDeTrab.SoundMenu.Play();
                }
                    else
                    {
                    if (pokeFugir > 51)
                    {
                        sound = new SoundPlayer("Sounds/PokeBallNaoCapturou.wav");
                        sound.Play();
                        MessageBox.Show($"Que pena, sua pokebola quebrou e o {pokemonSelvagem.Nome} fugiu");
                        LutaPokemonGUI.Combate.SelecionarPokemon.combate.Close();
                        Combate.SoundBattle.Play();
                    }
                    else
                    {
                        sound = new SoundPlayer("Sounds/PokeBallNaoCapturou.wav");
                        sound.Play();
                        MessageBox.Show("Que pena, sua pokebola quebrou.");
                        Task.Delay(1000);
                        Combate.SoundBattle.Play();
                    } 
                    }

                LutaPokemonGUI.Combate.SelecionarPokemon.combate.pbPokeSelvagem.Image = LutaPokemonGUI.Combate.SelecionarPokemon.combate.pokeSelvagem.Image;
                }
            } 
        }

 }
            

    

