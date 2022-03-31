using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScaler : Bricks
{

 
    public override void Action()
    {
        base.Action();
        Scale();
    }

    protected void Scale()
    {
        _image.transform.localScale = new Vector3(Random.value, Random.value, 0);
    }
}
