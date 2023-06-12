using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int ownedMoney = 0;
    public int playedNarrative = 0;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public int GetMoney()
    {
        return ownedMoney;
    }

    public void SetMoney(int x)
    {
        ownedMoney = x;
    }
}
