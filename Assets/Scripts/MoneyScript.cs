using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour {

    public int money;
    public Text output;

	// Use this for initialization
	void Start () {
        output = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        output.text = ("£" + money.ToString());
        money++;
	}

    void IncreaseMoney(int Amount, bool Increase)
    {
        if (Increase == true)
        {
            money = money + Amount;
        }
        else
        {
            money = money - Amount;
        }
    }
}
