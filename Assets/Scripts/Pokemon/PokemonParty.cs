using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PokemonParty : MonoBehaviour
{
    /// <summary>
    /// Class responsible for creating a party of pokemons
    /// </summary>

    [SerializeField] List<Pokemon> pokemons;

    private void Start()
    {
        foreach (var pokemon in pokemons)
        {
            pokemon.Init();
        }
    }

    public Pokemon GetHealthyPokemon()
    {
        return pokemons.Where(x => x.HP > 0).FirstOrDefault();
    }
}
