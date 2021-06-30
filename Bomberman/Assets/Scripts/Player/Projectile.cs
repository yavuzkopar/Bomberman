using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
      private float _countDown = 5f;
     
      private SphereCollider colliderr;
    [SerializeField] ParticleSystem particlSystem;
    private void Start()
    {
        colliderr = GetComponent<SphereCollider>();
        Invoke("CountDown", _countDown);
    }

    void CountDown()
    {
        colliderr.isTrigger = true;
        colliderr.radius *= 10f;
        particlSystem.Play();
        Destroy(this.gameObject, 2f);           
    }

}
