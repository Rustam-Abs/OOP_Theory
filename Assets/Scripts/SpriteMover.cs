using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : Bricks

{


    private void Update()
    {
        rotation +=speed * Time.deltaTime;
        Action();
    }

    public override void Action()
    {
        base.Action(); 
    }


}
