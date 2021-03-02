using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Photon.Pun;
using UnityEngine.UI;

public class TakingDamage : MonoBehaviourPunCallbacks
{
    [SerializeField]
    Image healthBar;

    private float health;
    public float startHealth = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
        healthBar.fillAmount = health/startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine("DmgXSecond");
        //health -= coef * Time.deltaTime;
    }

    [PunRPC]
    void OnTriggerEnter(Collider c)
    {

        if (c.tag == "Player")
        {
            //GameObject _player = GameObject.Find("Player");
            DamageTime(300);

            if (health <= 0f)
            {
                //Die
                Die();
            }
        }
    }
    [PunRPC]
    public void DamageTime(float _damage)
    {
        health -= _damage;
        Debug.Log(health);

        healthBar.fillAmount = health / startHealth;

        if (health <= 0f)
        {
            //Die
            Die();
        }
    }

    [PunRPC]
    public void TakeDamage(float _damage)
    {
        health += 2*_damage;
        Debug.Log(health);

        healthBar.fillAmount = health / startHealth;

        if (health<=0f)
        {
            //Die
            Die();
        }
    }

    void Die()
    {
        if (photonView.IsMine)
        {
            PixelGunGameManager.instance.LeaveRoom();
        }
    }
}
