using UnityEngine;

public class FirstCollision : MonoBehaviour
{
    public custom custo;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag=="Obstacle") {
            custo.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
