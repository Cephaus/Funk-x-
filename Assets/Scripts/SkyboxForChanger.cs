using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SkyboxForChanger : MonoBehaviour
{
    public Material[] skybox;
    public GameObject[] scenes;
    public GameObject[] videos;
    public int sceneNumber;
    public AudioSource music;
   // public GameObject drone;

    float t = 0;
    Color lerper;
    Renderer rend;
    public float duration;
    bool isStarted;
    bool startTheShowPeterYouWillDoRealGood;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneNumber < 0)
            sceneNumber = 0;
        if (sceneNumber > scenes.Length)
            sceneNumber = 0;

        if (t < 1 && startTheShowPeterYouWillDoRealGood)
        {
            t += Time.deltaTime / duration;
        }


        for (int i = 0; i < scenes.Length; i++)
        {

            if (sceneNumber == i)
            {
                scenes[i].SetActive(true);
                RenderSettings.skybox = skybox[i];
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    videos[i].SetActive(true);
                }
            }
            else {
                scenes[i].SetActive(false);

                videos[i].SetActive(false);

                //drone.SetActive(false);
            }


        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sceneNumber += 1;
            DynamicGI.UpdateEnvironment();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sceneNumber -= 1;
            DynamicGI.UpdateEnvironment();
        }
    }
	public void ObjectChangeRight()
	{
		if(sceneNumber != scenes.Length - 1)
		{
			sceneNumber += 1;
			DynamicGI.UpdateEnvironment();
		}
	}
	public void ObjectChangeLeft()
	{
		sceneNumber -= 1;
		DynamicGI.UpdateEnvironment();
	}

}
