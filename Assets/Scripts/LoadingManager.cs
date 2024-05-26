using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}
