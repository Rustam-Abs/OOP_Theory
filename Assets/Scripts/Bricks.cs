using UnityEngine.UI;
using UnityEngine;


public class Bricks : MonoBehaviour
{

    
    protected UIHelper uiHelper;
  
    private float _speed = 5;
    public float speed
      
    {
        get { return _speed; }
        set { _speed = value; }
    }

    protected float rotation;
        
    public   Image _image;
 
    public Image _activeIcon;

    
    

    private void Awake()
    {
        _activeIcon.enabled = false;
    }

    private void Update()
    {
       
        Rotate();
    }

    protected void Rotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotation);
        rotation += _speed * Time.deltaTime;
    }

    public virtual void Action()
    {
        _image.color = Random.ColorHSV();

    }
       

}
