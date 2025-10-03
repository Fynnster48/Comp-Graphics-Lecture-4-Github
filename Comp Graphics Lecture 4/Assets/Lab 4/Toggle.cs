using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject lambert;
    public GameObject ambient;
    public GameObject specular;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            lambert.SetActive(true);
            ambient.SetActive(false);
            specular.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            lambert.SetActive(false);
            ambient.SetActive(true);
            specular.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            lambert.SetActive(false);
            ambient.SetActive(false);
            specular.SetActive(true);
        }
    }
}