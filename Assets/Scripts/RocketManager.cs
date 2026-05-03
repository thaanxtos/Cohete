using UnityEngine;

public class RocketManager : MonoBehaviour
{
    public GameObject[] cohetes;
    public int currentRocket = 0;
    private int nrRockets;

    void Start()
    {
        nrRockets = cohetes.Length;
        OnChange(currentRocket);
        foreach (GameObject cohete in cohetes)
        {
            cohete.SetActive(true);
        }
    }

   
    void Update()
    {
        for (int i = 1; i <= nrRockets; i++)
        {
            if (Input.GetKeyDown("" + i))
            {
                currentRocket = i - 1;
                OnChange(currentRocket);

            }
        }
    }

    void OnChange(int index)
    {
        for (int i = 0; i < nrRockets; i++)
        {
            cohetes[i].SetActive(i == index);
        }
    }
}
