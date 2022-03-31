using UnityEngine.UI;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    private Color _colour;
    public Color colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    private float _speed = 5;
    public float speed
      
    {
        get { return _speed; }
        set { _speed = value; }
    }

    protected float rotation;


    [SerializeField]
    private Image _image;


    private void Update()
    {
        rotation += speed * Time.deltaTime;
        Action();
    }

    public virtual void Action()
    {
        transform.rotation = Quaternion.Euler(0,0, rotation);

    }

    protected virtual void ChangeColor(Color _color)
    {
        _image.color = _color;
    }

}
