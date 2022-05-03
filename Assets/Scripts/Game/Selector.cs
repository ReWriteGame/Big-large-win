using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Selector : MonoBehaviour
{
   [SerializeField]private GameObject []item;
   [SerializeField]private float timeChange ;
  
   public void OpenRandomObject()
   {
      item[Random.Range(0, item.Length)].SetActive(true);
   }
   
   
   public void CloseAllObjects()
   {
      foreach (GameObject var in item)
         var.SetActive(false);
   }

   private void Start()
   {
      StartCoroutine(StartRandomOpenCor());
   }

   private IEnumerator StartRandomOpenCor()
   {
      while (true)
      {
         OpenRandomObject();
         yield return new WaitForSeconds(timeChange);
         CloseAllObjects();
      }
      yield break;
   }
}
