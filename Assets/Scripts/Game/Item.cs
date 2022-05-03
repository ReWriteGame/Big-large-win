using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public enum TypeItem
{
   item1,
   item2,
   item3,
   item4
}

public class Item : MonoBehaviour
{
   public TypeItem item;
   
   public UnityEvent itemMatchesEvents;
   public UnityEvent itemNotMatchesEvents;




   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.gameObject.GetComponent<Item>().item == item)
      {
         itemMatchesEvents?.Invoke();
      }
      else
      {
         itemNotMatchesEvents?.Invoke();
      }
   }
}
