using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class EnemyPathFinding : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float moveSpeed = 2f;
    Rigidbody2D rb;
    private Vector2 moveDir;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    private void EnemyMove(){
        rb.MovePosition(rb.position + moveDir * (moveSpeed * Time.fixedDeltaTime) );
    }
    public void MoveTo(Vector2 targetPosition){
        moveDir = targetPosition;
    }

}
