using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTiles : MonoBehaviour
{
    public GameObject prefab;

    public TileType north;
    public TileType south;
    public TileType west;
    public TileType east;
}

public enum TileType
{
    Grass,
    BuildingA,
    BuildingB,
    BuildingC,
    Road
}