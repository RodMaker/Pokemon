using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapArea : MonoBehaviour
{
    /// <summary>
    /// Class responsible for randomizing the pokemon encounters on the wild
    /// </summary>

    [SerializeField] List<Pokemon> wildPokemons;

    public Pokemon GetRandomWildPokemon()
    {
        var wildPokemon = wildPokemons[Random.Range(0, wildPokemons.Count)];
        wildPokemon.Init();
        return wildPokemon;
    }
}
