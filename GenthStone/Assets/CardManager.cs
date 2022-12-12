using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager instance = new CardManager();
    Dictionary<int, string> CardDictionary = new Dictionary<int, string>
    {
        {0,"a"},
        {1,"b"},
        {2,"c"},
        {3,"d"},
        {4,"e"},
        {5,"f"},
        {6,"g"},
        {7,"h"},
        {8,"i"},
        {9,"j"},
        {10,"k"},
        {11,"l"},
        {12,"m"},
        {13,"n"},
        {14,"o"},
        {15,"p"},
    };
    public List<string> Deck 
        = new List<string>();
    public List<int> Cards = new List<int>();
    private void Start()
    {
        for (int i = 0; i < CardDictionary.Count; i++) {
            Deck.Add(CardDictionary[i]);
        }
        StartDeck(); 
    }
    public void ResetDeck()
    {

    }
    public void StartDeck()
    {
        int temp;
        while (Deck.Count > 0)
        {
            temp = Random.Range(0, Deck.Count);
            Cards.Add(temp);
            Deck.Remove(Deck[temp]);
            print($"deck : {Deck.Count}");
            print($"card : {Cards.Count}");
        }
        for(int i = 0; i < Cards.Count; i++)
        {
            print(Cards[i]);
        }
        
    }
}
