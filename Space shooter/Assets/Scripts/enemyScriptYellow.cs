using UnityEngine;
using System.Collections;

public class enemyScriptYellow : MonoBehaviour
{

    public float speed_yellow = 0.12f;
    public float x, y;
    public float minY = -20f;
    public float maxY = 2f;
    public float minX = -2.7f;
    public float maxX = 2.7f;
    private Transform _transform;
    private Vector3 _currentPosition;
    private float _verticalSpeed = 5f;
    private Vector3 pos;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.GetComponent<Transform>();
        // _checkBounds();
    }

    // Update is called once per frame
    void Update()
    {

        pos = transform.position;
        Vector3 velocity = new Vector3(0, speed_yellow, 0);//Hard code speed  value is inserted.
        pos -= velocity;
        this._transform.position = pos;


        if (pos.y <= -20f)
        {

            _checkBounds();

        }



    }

    private void _checkBounds()
    {
        // _verticalSpeed = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        this.x = UnityEngine.Random.Range(minX, maxX);
        this.y = UnityEngine.Random.Range(minY, maxY);
        _currentPosition = new Vector3(x, 2f, 0);
        _transform.position = _currentPosition;



    }
}
