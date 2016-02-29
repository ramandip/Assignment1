using UnityEngine;
using System.Collections;

public class movingBackground : MonoBehaviour
{
    public float speed = 5f;
    private Transform _transform;



    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, speed * Time.deltaTime, 0);
        pos -= transform.rotation * velocity;
        transform.position = pos;



        if (pos.y <= -15.3f)
        {
            this.Reset();
        }
    


}
void Start () {
            // Make a reference with the Transform Component

            this._transform = gameObject.GetComponent<Transform>();

            // Reset the Ocean Sprite to the Top

            this.Reset();
        }

        // Update is called once per frame

        

public void Reset()
    {
        this._transform.position = new Vector3(0, -1.0f, 0);
    }
}
