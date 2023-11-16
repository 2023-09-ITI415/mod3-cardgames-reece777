using UnityEngine;

public class GridInstantiation : MonoBehaviour
{
    public GameObject myPrefab; 

    void Start()
    {
        Instantiate(myPrefab, new Vector3(0, -7, 0), Quaternion.identity);
    }
}
