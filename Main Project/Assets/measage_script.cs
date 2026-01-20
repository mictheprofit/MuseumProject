using UnityEngine;

public class measage_script : MonoBehaviour
{
    public GameObject maenie;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!maenie.activeSelf)
            {
                maenie.SetActive(true);
            }
            else
            {
                maenie.SetActive(false);
            }
        }
    }

}
