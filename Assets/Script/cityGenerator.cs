using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cityGenerator : MonoBehaviour
{
    public int cityHeight = 10;
    public int cityWidth = 10;
    
    public List<CityTiles> tiles;
    public List<CityTiles> activeTiles;
}