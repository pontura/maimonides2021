using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    public List<CharacterData> allcharacterData;
    public List<Character> all;
    public Character character_to_instantiate;
    public Transform container;
    public int maxPlayers;

    private void Start()
    {
        foreach(CharacterData data in allcharacterData)
        {
            CreateCharacter(data);
        }
    }
    void CreateCharacter(CharacterData data)
    {
        Character character = Instantiate(character_to_instantiate, container);
        character.transform.localPosition = new Vector3(GetRandomBetween(-10, 10), 5, GetRandomBetween(-10, 10));
        character.SetName(data.username);
        character.SetColor(data.color);
        character.SetEdad(data.edad);
        all.Add(character);
    }
    float GetRandomBetween(float min, float max)
    {
        return Random.Range(min, max);
    }

}
