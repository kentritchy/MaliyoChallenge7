using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamepiece : MonoBehaviour
{

    private int x;
    private int y;

    public int X
    {
        get { return x; }
        set
        {
            if (isMovable())
            {
                x = value;
            }
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            if (isMovable())
            {
                y = value;
            }
        }
    }

    private Grid.PieceType type;
    public Grid.PieceType Type
    {
        get { return type; }
    }


    private Grid grid;
    public Grid GridRef
    {
        get { return grid; }
    }

    private MobilityPiece movableComponent;
    public MobilityPiece MovableComponent
    {
      get {return movableComponent;}
    }

    private ColorPiece colorComponent;
    public ColorPiece ColorComponent
    {
        get { return colorComponent; }
    }




    void Awake()
    {
        movableComponent = GetComponent<MobilityPiece>();
        colorComponent = GetComponent<ColorPiece>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init (int _x, int _y, Grid _grid, Grid.PieceType _type)
    {
        x = _x;
        y = _y;
        grid = _grid;
        type = _type;
    }

    public bool isMovable()
    {
        return movableComponent != null;
    }


    public bool isColored()
    {
        return colorComponent != null;
    }
}
