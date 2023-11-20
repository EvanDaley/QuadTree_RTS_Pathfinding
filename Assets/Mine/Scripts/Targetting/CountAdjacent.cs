using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quadtree.Items;
using Quadtree;
using UnityEditor;
using System.Linq;

public class CountAdjuacent : MonoBehaviour
{
    private GameObjectQuadtreeRoot root;
    public Bounds bounds; // Made public to be visible in inspector
    private List<GameObjectItem> items;
    public float CellRange = 10f;

    void Start()
    {
      root = GameObject.FindObjectOfType<GameObjectQuadtreeRoot>();
      if (root == null)
      {
          Debug.LogError("No GameObject with GameObjectQuadtreeRoot script found");
      }
      else
      {
          bounds = new Bounds(transform.position, new Vector3(CellRange, 0f, CellRange));
      }
    }

    void Update()
    {
        items = root.Find(bounds);
        Debug.Log(items);
    }

    void OnDrawGizmos()
    {
        if (items != null && items.Count > 0)
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 250;
            style.fontStyle = FontStyle.Bold;
            style.normal.textColor = Color.green;

            Handles.Label(bounds.center, items.Count.ToString(), style);
        }

        Gizmos.color = Color.red; // Set color of gizmo
        Gizmos.DrawWireCube(bounds.center, bounds.size); // Draw a cube gizmo for bounds
    }
}