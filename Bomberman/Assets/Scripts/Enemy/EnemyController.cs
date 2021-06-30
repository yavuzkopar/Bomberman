using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    public Transform playerTr;

    public int score = 5;
    [SerializeField] float lineOfSight;
    [SerializeField] float attackDistace;
    [SerializeField] float rotateSpeed;
    [SerializeField] float speed;

    private void Update()
    {
        TrackPlayer();
    }
    void TrackPlayer()
    {
        float distance = Vector3.Distance(transform.position, playerTr.position);
        Vector3 lookPlayer = new Vector3(playerTr.position.x,0,playerTr.position.z) - new Vector3(transform.position.x,0,transform.position.z);
        Quaternion _quaternion = Quaternion.LookRotation(lookPlayer);
        if (distance <= lineOfSight && playerTr != null)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, _quaternion, Time.deltaTime * rotateSpeed);
            if (distance >= attackDistace)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
           
            
        }

    }
    #region Interaction
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            DestroyEnemy(score);
        }
        if (other.gameObject.CompareTag("FreezeB"))
        {
            Freeze();
        }
    }

    private void DestroyEnemy( int scoreAdd)
    {
        Destroy(this.gameObject);

        GameManager.Instance.score += scoreAdd;

    }
    void Freeze()
    {
        speed = 0f;
        rotateSpeed = 0;
    }
    #endregion
}
