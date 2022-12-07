using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FFXTransition : MonoBehaviour
{
    [SerializeField]
    Image background;
    [SerializeField]
    RawImage renderBackground;

    [SerializeField]
    AudioClip glassShatterSFX;
    [SerializeField]
    AudioClip battleTheme;

    [SerializeField]
    GameObject shatterPlane;

    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = glassShatterSFX;
        source.Play();
        StartCoroutine("FadeBackground");
        foreach  (Transform item in shatterPlane.transform)
        {
            Rigidbody itemRB = item.GetComponent<Rigidbody>();
            Vector3 newPos = item.localPosition;
            itemRB.useGravity = false;
            item.localPosition = Vector3.MoveTowards(item.localPosition, new Vector3(newPos.x, newPos.y + 1, newPos.z), 0.5f);

            itemRB.velocity = new Vector3(Random.Range(-5, -15), 0, 0.2f);
            itemRB.angularVelocity = new Vector3(0,0,Random.Range(5,10));
        }
    }

    private void Update()
    {
        if (!source.isPlaying)
        {
            source.clip = battleTheme;
            source.Play();
        }
    }

    IEnumerator FadeBackground()
    {
        Color color = background.color;
        yield return new WaitForSeconds(1f);
        while (color.a > 0)
        {
            color.a -= 0.025f;
            background.color = color;
            renderBackground.color = color;
            yield return new WaitForSeconds(0.025f);
        }
        
    }
}
