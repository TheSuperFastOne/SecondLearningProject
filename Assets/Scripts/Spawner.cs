using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Prefab;
    private Vector3 screenPosition;
    private Vector3 worldPosition;
    public void Update()
    {
        screenPosition = Input.mousePosition;
        screenPosition.z = -5;
        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Prefab, new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);
        }


    }

}
