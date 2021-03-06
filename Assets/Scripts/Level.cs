using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Level : MonoBehaviour
{
     [SerializeField] float spread = 3.0f;
     [SerializeField] int items = 10;


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
                // Check if this spot is a blackout spot
                if (blackoutPositions.Any(b => b.X == x && b.Z == z)) {
                    continue;
                }

                // Calculate the X position
                float xPosition = 
                    -10 /* Map specific offset */ 
                    + x /* Position of our for loop */
                    * spread /* Used to scale out the pellets */;

                // Modify x position to align better with the corners
                /*float modifyX = x > (items - 1) / 2 ? 0.5f : 0.5f;
                
                // Modify the X position
                if (modifyX > 0) {
                    xPosition += modifyX;
                } else {
                    xPosition -= modifyX;
                }*/
                

                // Calculate the Z position
                float zPosition = -10 + z * spread;

                Instantiate(pellet, new Vector3( xPosition, 0.4f, zPosition), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
