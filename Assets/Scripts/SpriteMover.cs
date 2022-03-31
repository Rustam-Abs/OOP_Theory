
using UnityEngine;

public class SpriteMover : Bricks

{
       
    private bool _isMoving = false;
    private float _coundown;
    public Vector3 _position;

   
    public override void Action()
    {
        _isMoving = true;
    }

    private void Start()
    {
        _position = transform.position;
    }

    private void Update()
    {
        Rotate();
        if (_isMoving && _coundown < 1.5f)
        {
            _coundown += Time.deltaTime;
            ShakeIt();
        }
        else
        {   
            _isMoving = false;
            _coundown = 0;
            transform.position = _position;
        }
    }

    private void ShakeIt()
    {
       transform.position = new Vector3(_position.x+Random.Range(-5,5), _position.y + Random.Range(-5, 5),0);


    }

}
