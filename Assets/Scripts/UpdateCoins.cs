using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateCoins : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       text.text = ""+player.GetMoney();
    }
}
