using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gants : MonoBehaviour
{
  [SerializeField] private GameObject _Bag;
  [SerializeField] private GameObject _FlècheDroite;
  [SerializeField] private GameObject _FlècheGauche;
  [SerializeField] private GameObject _FlècheDown;
  [SerializeField] private GameObject _FlècheFront;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision collision)
    {
      Destroy(_Bag);
      Debug.Log(gameObject.name + " a touché le " + collision.gameObject.name);

      if(collision.gameObject.name == "RightSide" && _FlècheDroite)
      {
        Debug.Log("Multiplicateur Augmente");
      }
    }
}
