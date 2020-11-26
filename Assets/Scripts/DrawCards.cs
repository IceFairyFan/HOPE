using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;

    public GameObject PlayerArea;
    public GameObject EnemyArea;

    public int i;
    public int j;
    public int x = 0; //Temporary solution for limiting cards. Replace with Global Variable
    public int RandomCardInt;

    List<GameObject> cards = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        i = 0;

        cards.Add(Card1);
        cards.Add(Card2);
        //cards.Add(Card3);
        //cards.Add(Card4);
        //cards.Add(Card5);
        //cards.Add(Card6);
        //cards.Add(Card7);
        //cards.Add(Card8);
        //cards.Add(Card9);
        //cards.Add(Card10);
    }

    public void OnClick()
    {
        if (i < 3)
        {
            j = x + 1;
            for (var i = j; i < 4; i++)
            {
                GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerArea.transform, false);

                x = i;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
