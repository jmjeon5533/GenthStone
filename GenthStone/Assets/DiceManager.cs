using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public static DiceManager instance = new DiceManager();
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public enum dice
    {
        fire,
        water,
        ice,
        light,
        grass,
        Rock,
        wind
    }
    List<dice> Dices = new List<dice>();
    public void RollDice()
    {

    }
}
