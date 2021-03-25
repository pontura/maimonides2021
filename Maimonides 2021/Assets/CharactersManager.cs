using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    public List<string> names;
    public List<Character> all;
    public Character character_to_instantiate;
    public Transform container;
    public int maxPlayers;

    private void Start()
    {
        //agregar los personajes desde la lista names.
    }
    void CreateCharacter(string name)
    {
        Character character = Instantiate(character_to_instantiate, container);
        character.transform.localPosition = new Vector3(GetRandomBetween(-10, 10), 5, GetRandomBetween(-10, 10));
        character.SetName(name);
        all.Add(character);
    }
    float GetRandomBetween(float min, float max)
    {
        return Random.Range(min, max);
    }

}
