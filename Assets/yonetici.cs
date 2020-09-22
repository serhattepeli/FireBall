using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    // Start is called before the firs 1);
    public void YeniOyun(int index)
    {
        SaveLoadManager.yeni = true;
        SceneManager.LoadScene(index);
    }
    public void EskiOyun(int index)
    {
        SaveLoadManager.yeni = false;
        SceneManager.LoadScene(index);
    }
}
