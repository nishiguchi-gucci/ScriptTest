using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
        Debug.Log("残りHPは" + this.hp);
    }

    public void Magic(int magic)
    {
        //単独処理
        //if (this.mp > magic)
        //{
            //this.mp -= magic;
            //Debug.Log("魔法攻撃した。残りMPは" + mp);
        //}
        //else
        //{
            //Debug.Log("MPが足りないため魔法が使えない");
        //}

        //連続処理
        for (int i = 0; i < 11; i++)
        {
            if (this.mp > magic)
            {
                this.mp -= magic;
                Debug.Log("魔法攻撃した。残りMPは" + this.mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            } 
        }
    }
}
public class Last : MonoBehaviour
{

    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        lastboss.Magic(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}