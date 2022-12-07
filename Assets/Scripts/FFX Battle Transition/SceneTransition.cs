using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public Image backgroundImage;
    public GameObject shatterPrefab;
    public Canvas canvas;
    public int shatterSceneIndex;

    Camera cam;
    Color imageColor = Color.black;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartBattle();
        }
    }

    void StartBattle()
    {
        /*GameObject shatterObject = Instantiate(shatterPrefab, cam.transform);
        shatterObject.transform.localPosition = new Vector3(0, 0, 2.5f);
        shatterObject.transform.localScale = new Vector3(0.34f, 2, 0.34f);
        shatterObject.transform.SetParent( gameObject.transform, true);
        foreach  (Rigidbody shard in shatterObject.transform.GetComponentsInChildren<Rigidbody>())
        {
            shard.useGravity = false;
            shard.velocity = new Vector3(Random.Range(3f, 4f), 0, Random.Range(-0.25f, -0.5f));
        }*/
       
       // backgroundImage.color = imageColor;
        SceneManager.LoadScene(sceneToLoad);
       // SceneManager.LoadSceneAsync(shatterSceneIndex, LoadSceneMode.Additive);

        



    }
}
