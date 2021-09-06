using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    public void CreateCartmanCharacter()
    {
        Character newCharacter = new Cartman();
    }
    public void CreateKennyCharacter()
    {
        Character newCharacter = new Kenny();
    }
    public void CreateKyleCharacter()
    {
        Character newCharacter = new Kyle();
    }
    public void CreateStanCharacter()
    {
        Character newCharacter = new Stan();
    }
}
