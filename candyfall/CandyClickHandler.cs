using UnityEngine;

public class CandyClickHandler : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}