using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootgun : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        if(Time.timeScale == 1)
        {
                Vector3 position1 = shootPoint.position;
                position1.y += 0.1f;
                position1.x -= 0.4f;

                Instantiate(Bullet, shootPoint.position, Quaternion.identity);
                Instantiate(Bullet, position1, Quaternion.Euler(0, 0, 10));     
        }
    }
}
