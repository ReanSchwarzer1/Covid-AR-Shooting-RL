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
   // private Renderer enemyRenderers;
    //public MeshRenderer[] enemyRen;

    private GameObject[] enemies;
   // health = GameObject.FindGameObjectsWithTag("Health");

    CursorLockMode lockMode;

    void Awake()
    {
        lockMode = CursorLockMode.Locked;
        Cursor.lockState = lockMode;
    }

    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
        healthBar.fillAmount = health/startHealth;
        // enemy = GameObject.FindGameObjectsWithTag("Enemy");

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        /*
        enemyRen = new MeshRenderer[enemies.Length];
        for (int i = 0; i < enemyRen.Length; i++)
        {
            enemyRen[i] = enemies[i].GetComponent<MeshRenderer>();
        }
        */

        //enemyRenderers = new Renderer[enemies.Length];
        //enemyRenderers = enemies.GetComponent<Renderer>();
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
        if (c.tag == "Enemy")
        {
            //GameObject _player = GameObject.Find("Player");
            DamageTime(150);

            if (health <= 0f)
            {
                //Die
                Die();
            }
        }
        if (c.tag == "Health")
        {
            //GameObject _player = GameObject.Find("Player");
            TakeDamage(450);
            //Destroy(health);
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
    public void Disappear()
    {
        //EnableRenderer(enemyRenderers, false);
        Debug.Log("Renderer disabled");
        //enemyRen.enabled = false; 
        //enemyRenderers.enabled = false;
        //GameObject.Find("Enemy").transform.localScale = new Vector3(0, 0, 0);
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
    
    /*void EnableRenderer(Renderer[] rd, bool enable)
    {
        for (int i = 0; i < rd.Length; i++)
        {
            rd[i].isVisible = enable;
            button.Visibility = Visibility.Collapsed;
        }
    }
    */
}
