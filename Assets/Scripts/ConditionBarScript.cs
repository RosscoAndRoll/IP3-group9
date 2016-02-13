using UnityEngine;
using System.Collections;

public class ConditionBarScript : MonoBehaviour {

    public double condition;
    public GameObject bar1, bar2, bar3, bar4, bar5, bar6, bar7, bar8;
    public GameObject houseG, houseY, houseR;
    private int houseStatus;

    // Use this for initialization
    void Start () {
        condition = 100;
        houseStatus = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
        condition = condition - 0.1;

        bar1.SetActive(false); bar2.SetActive(false); bar3.SetActive(false); bar4.SetActive(false); bar5.SetActive(false); bar6.SetActive(false); bar7.SetActive(false); bar8.SetActive(false);

        if (condition >= 87.5)
        {
            bar1.SetActive(true);
            houseStatus = 1;
        }
        else if (condition >= 75 && condition < 87.5)
        {
            bar2.SetActive(true);
            houseStatus = 1;
        }
        else if (condition >= 60 && condition < 75)
        {
            bar3.SetActive(true);
            houseStatus = 1;
        }
        else if (condition >= 40 && condition < 60)
        {
            bar4.SetActive(true);
            houseStatus = 2;
        }
        else if (condition >= 27.5 && condition < 40)
        {
            bar5.SetActive(true);
            houseStatus = 2;
        }
        else if (condition >= 10 && condition < 27.5)
        {
            bar6.SetActive(true);
            houseStatus = 3;
        }
        else if (condition < 10 && condition > 2)
        {
            bar7.SetActive(true);
            houseStatus = 3;
        }
        else
        {
            bar8.SetActive(true);
            houseStatus = 3;
        }



        if (houseStatus == 1)
        {
            houseG.SetActive(true);
            houseY.SetActive(false);
            houseR.SetActive(false);
        }
        else if (houseStatus ==2)
        {
            houseG.SetActive(false);
            houseY.SetActive(true);
            houseR.SetActive(false);
        }
        else
        {
            houseG.SetActive(false);
            houseY.SetActive(false);
            houseR.SetActive(true);
        }

    }
}
