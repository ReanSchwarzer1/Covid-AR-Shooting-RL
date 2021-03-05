using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    Camera fpsCamera;

    public float fireRate = 0.1f;
    float fireTimer;
    public float c=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    InfectAgent infect;
    // Update is called once per frame
    void Update()
    {

        if (fireTimer<fireRate)
        {
            fireTimer += Time.deltaTime;
        }


        if (Input.GetButton("Fire1")&&fireTimer>fireRate)
        {

            //Reset fireTimer
            fireTimer = 0.0f;


            RaycastHit _hit;
            Ray ray = fpsCamera.ViewportPointToRay(new Vector3(0.5f,0.5f));
            

            if (Physics.Raycast(ray,out _hit,100))
            {
             
                Debug.Log(_hit.collider.gameObject.name);
                if(_hit.collider.gameObject.CompareTag("Enemy"))
                {   c+=1;
                    InfectAgent sn = _hit.collider.gameObject.GetComponent<InfectAgent>();
                    sn.Respawnee();
                    if(c==7)
                    {
                        //InfectAgent sn = _hit.collider.gameObject.GetComponent<InfectAgent>();

                        c=0;
                        Debug.Log(c);

                        //sn.Respawnee();
                    }
                    Debug.Log(c);
                  //  Destroy(_hit.collider.gameObject);
                }
                
                

                if (_hit.collider.gameObject.CompareTag("Player") && !_hit.collider.gameObject.GetComponent<PhotonView>().IsMine)
                {
                    _hit.collider.gameObject.GetComponent<PhotonView>().RPC("TakeDamage",RpcTarget.AllBuffered,10f);
                }

            }


        }


    }
}
