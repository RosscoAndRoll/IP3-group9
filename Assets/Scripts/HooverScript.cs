using UnityEngine;
using System.Collections;

public class HooverScript : MonoBehaviour {

    public float speed = 1.5f;
    public int score;
    public TextMesh score_text;
    public Transform Dirty;

    // Use this for initialization
    void Start()
    {
        for (int z = 0; z < 5; z++)
        {
            for (int x = 0; x < 5; x++)
            {
                Instantiate(Dirty, new Vector3(x, 0, z), Quaternion.identity);


            }
        }
    }

    // Update is called once per frame
    

    void Update()
    {
        score_text.text =("Score" + score);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {

            Destroy(other.gameObject);
            score += 1;
    }
}