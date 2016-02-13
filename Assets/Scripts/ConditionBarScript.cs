using UnityEngine;
using System.Collections;

public class ConditionBarScript : MonoBehaviour {

    public double condition;
    public GameObject bar1, bar2, bar3, bar4, bar5, bar6, bar7, bar8;

    // Use this for initialization
    void Start () {
        condition = 100;
	
	}
	
	// Update is called once per frame
	void Update () {
        condition = condition - 0.1;


        if (condition >= 87.5)
        {
            bar1.SetActive(true);
        }
        else if (condition >= 75 && condition < 87.5)
        {
            bar2.SetActive(true);
        }
        else if (condition >= 60 && condition < 75)
        {
            bar3.SetActive(true);
        }
        else if (condition >= 40 && condition < 60)
        {
            bar4.SetActive(true);
        }
        else if (condition >= 27.5 && condition < 40)
        {
            bar5.SetActive(true);
        }
        else if (condition >= 10 && condition < 27.5)
        {
            bar6.SetActive(true);
        }
        else if (condition < 10 && condition > 2)
        {
            bar7.SetActive(true);
        }
        else bar8.SetActive(true);


    }
}
