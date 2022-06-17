using UnityEngine;

public class score : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.z);
    }
}
