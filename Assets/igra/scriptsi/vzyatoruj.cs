using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vzyatoruj : MonoBehaviour {
    private GameObject glavger,wepvrukah;
    private BoxCollider2D korobkageroya, korobkaorujiya;
    private SpriteRenderer kartinka;
    public KeyCode boi = KeyCode.E;
    private Vector3 heroposition,weponplace;
    private bool weponpick;
    void Start()
    {
        glavger = GameObject.Find("glavgeroy");
        GetComponent<BoxCollider2D>();
        korobkageroya = glavger.GetComponent<BoxCollider2D>();
        korobkaorujiya = GetComponent<BoxCollider2D>();
        wepvrukah = GameObject.Find("sword");
        weponpick = false;
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 100), "lol");
    }
    // Update is called once per frame
    void Update()
    {
        heroposition = glavger.GetComponent<Transform>().position;
        if (korobkageroya.Distance(korobkaorujiya).isOverlapped && Input.GetKey(boi) && weponpick == false)
        {
            kartinka = wepvrukah.GetComponent<SpriteRenderer>();
           weponpick = true;

            Vector3 lookPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            lookPos = lookPos - transform.position;
            float ugol = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(ugol, Vector3.forward);

            heroposition = new Vector3(heroposition.x + 0.5f, heroposition.y + 0.7f, heroposition.z);
           heroposition= transform.TransformPoint(heroposition);
           
            //transform.position = heroposition;
            wepvrukah.transform.SetParent(glavger.transform, true);

        }
        if (weponpick == true)
        {
          
         
        }
    }
}
