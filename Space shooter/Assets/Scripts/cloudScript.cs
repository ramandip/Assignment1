using UnityEngine;
using System.Collections;
using System;

public class cloudScript : MonoBehaviour {
    public float speed = 0.1f;
    public float x, y;
    public float minY=-13f;
    public float maxY = 4f;
    public float minX = -3.0f;
    public float maxX = 2.5f;
    private Transform _transform;
    private Vector3 _currentPosition;
    private Vector3 pos;

    // Use this for initialization
    void Start () {
        _transform = gameObject.GetComponent<Transform>();
       // _checkBounds();
    }
	
	// Update is called once per frame
	void Update () {

        pos = transform.position;
        Vector3 velocity = new Vector3(0, 0.1f, 0);//Hard code speed  value is inserted.
        pos -= velocity;
        this._transform.position = pos;


        if (pos.y <= -5f)
        {
            
            _checkBounds();
          
        }


      
    }

    private void _checkBounds()
    {
       // _verticalSpeed = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        this.x = UnityEngine.Random.Range(minX, maxX);
        this.y = UnityEngine.Random.Range(minY, maxY);
        _currentPosition = new Vector3(x, 20f, 0);
        _transform.position = _currentPosition;

        

    }
}
