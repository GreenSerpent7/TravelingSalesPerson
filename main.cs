using System;
using System.Collection.Generic;
using System.Linq;

class TravelingSalesperson
{

  staic void Main ()
  {
     int[,] graph = {
        { 0, 10, 15, 20},
        { 10, 0, 35, 25 },
        { 15, 35, 0, 30 },
        { 20, 25, 30, 0 }
     };

    int n = graph.GetLength(0); 
    List<int> vertices = Enumerable.Range(1, n - 1).ToList(); 
  }
}
