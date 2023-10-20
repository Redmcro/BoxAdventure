using UnityEngine;

public class player_collosion : MonoBehaviour
{
    public playerMovement movement;
    public GameManage GameManage;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManage>().EndGame();
        }

    }
    

}
