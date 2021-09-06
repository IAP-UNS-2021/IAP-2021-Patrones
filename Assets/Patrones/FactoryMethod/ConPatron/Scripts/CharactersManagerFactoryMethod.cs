using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersManagerFactoryMethod : MonoBehaviour
{
    private ICharacterFactory charFactory;

    // Start is called before the first frame update
    void Start()
    {
        //fábrica por defecto
        charFactory = new CartmanFactory();
    }


    public void CreateNewCharacter()
    {
        charFactory.CreateNewCharacter();
    }


    //*********************************************************
    
    public void ActivateCartmanFactory()
    {
        charFactory = new CartmanFactory();
    }

    public void ActivateKennyFactory()
    {
        charFactory = new KennyFactory();
    }

    public void ActivateKyleFactory()
    {
        charFactory = new KyleFactory();
    }

    public void ActivateStanFactory()
    {
        charFactory = new StanFactory();
    }
}
