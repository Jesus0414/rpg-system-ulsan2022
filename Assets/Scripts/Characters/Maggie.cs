using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maggie : Hero
{
    protected override void Movement()
    {
        //if(gamemanager.insta.gamemode.GetLeadear.gameObject == gameObject)
        base.Movement();
        anim.SetFloat("Move", Mathf.Abs(Axis.magnitude));
    }
}
