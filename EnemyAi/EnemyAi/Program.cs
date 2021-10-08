using System;

namespace EnemyAi
{
    class Program
    {
        
        //ik ben helaas niet ver gekomen. Ik zal in m'n vrije tijd de theorie meer doornemen.

        static void Main(string[] args)
        {

        }
    }

    class Room
    {
        int[][] Tile = new int[2][];

        public void Doit()
        {
            for (int y = 0; y < Tile.Length; y++)
            {
                Tile[y] = new int[5];
            }
        }
    } 


}
