using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Level : MonoBehaviour
{

    internal struct BlackoutPosition {
        public BlackoutPosition(int x, int z) {
            X = x;
            Z = z;
        }

        public int X {get;set;}
        public int Z {get;set;}
    }
    
    // Start is called before the first frame update
    void Start()
    {
         GameObject pellet = (GameObject) Resources.Load("Pellet");

         int multi = 3;
         int items = 10;
         List<BlackoutPosition> blackoutPositions = new List<BlackoutPosition>{
             new BlackoutPosition(0, 3),
             new BlackoutPosition(1, 3),
             new BlackoutPosition(0, 5),
             new BlackoutPosition(1, 5),
             new BlackoutPosition(4, 4),
             new BlackoutPosition(5, 4),
            new BlackoutPosition(items - 1, 3),
             new BlackoutPosition(items - 2, 3),
             new BlackoutPosition(items - 1, 5),
             new BlackoutPosition(items - 2, 5),
         };


        for (int x = 0; x < items; x++) {
            for (int z = 0; z < items; z++) {
                if (blackoutPositions.Any(b => b.X == x && b.Z == z)) continue;
                Instantiate(pellet, new Vector3( -10 + x * multi, 0.4f, -10 + z * multi), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
