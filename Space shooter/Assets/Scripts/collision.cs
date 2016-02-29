using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour
{

    // PUBLIC INSTANCE VARIABLES
    public GameController main;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("power"))
        {

            this.main.ScoreValue += 100;
        }
        if (other.gameObject.CompareTag("planet"))
        {

            this.main.LivesValue += 1;
        }
        if (other.gameObject.CompareTag("Cloud"))
        {
            this.main.ScoreValue -= 100;
        }
        if (other.gameObject.CompareTag("enemy"))
        {
            this.main.ScoreValue -= 100;
        }
    }
}
