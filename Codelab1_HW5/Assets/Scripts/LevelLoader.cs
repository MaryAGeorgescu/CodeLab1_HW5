using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


//Intent: To create a level loader that will create a custom map to navigate through
//Usage: This requires a bunch of prefabs that will get called at the beginning of the game

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string filePath = Application.dataPath + "/level0.text";
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, "X");
        }

        string inputLines = File.ReadAllLines(filePath);

        for (int y = 0; y < inputLines.Lenght; y++)
        {
            string line = inputLines[y];

            for (int x = 0; x < line.Lenght; x++)
            {
                if (line[x] == 'X')
                {
                    GameObject newWall = Instantiate(Resources.Load<GameObject>("Prefabs/Wall"));
                    newWall.transform.position = new Vector2(x - line.Lenght / 2f, inputLines.Lenght / 2f - y);
                }
                else if (line[x] == 'P')
                {
                    GameObject newWall = Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
                    newWall.transform.position = new Vector2(x - line.Lenght / 2f, inputLines.Lenght / 2f - y);
                }

                GameObject tile;
                switch (line[x])
                {
                         case 'X':
                             tile = Instantiate(Resources.Load<GameObject>("Prefabs/Wall"));
                             break;
                         case 'P':
                             tile = Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
                             break;
                        case 'Q':
                            tile = Instantiate(Resources.Load<GameObject>("Prefabs/Water"));
                            break;
                        case 'W':
                            tile = Instantiate(Resources.Load<GameObject>("Prefabs/Tree"));
                            break;
                }

                if (tile != null)
                {
                    tile.transform.position=new Vector2(x-line.Lenght/2f, inputLines.Lenght/2f-y);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
