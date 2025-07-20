using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsRedirectionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Youtube(string url)
    {
        Application.OpenURL(url);
    }
    public void Twitter(string url)
    {
        Application.OpenURL(url);
    }
    public void Instagram(string url)
    {
        Application.OpenURL(url);
    }
}
