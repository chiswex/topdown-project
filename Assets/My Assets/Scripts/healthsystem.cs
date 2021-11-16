using UnityEngine;
public class HealthSystem : MonoBehaviour
{
    [SerializeField] GameObject HeartPrefab;
    [SerializeField] GameObject EmptyHeartPrefab;

    public void DrawHearts(int hearts, int maxHearts)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < maxHearts; i++)
        {
            if (i + 1 <= hearts)
            {
                GameObject heart = Instantiate(HeartPrefab, transform.position, Quaternion.identity);
                heart.transform.parent = transform;
            }
            else
            {
                GameObject heart = Instantiate(EmptyHeartPrefab, transform.position, Quaternion.identity);
                heart.transform.parent = transform;
            }
        }
    }
}