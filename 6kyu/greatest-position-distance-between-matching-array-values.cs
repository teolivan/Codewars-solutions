/* The goal of this Kata is to return the greatest distance of index positions between matching number values in an array or 0 if there are no matching values.

Example: In an array with the values [0, 2, 1, 2, 4, 1] the greatest index distance is between the matching '1' values at index 2 and 5. Executing greatestDistance/greatest_distance/GreatestDistance with this array would return 3. (i.e. 5 - 2)

Here are some extra examples:

[0, 2, 1, 2, 4, 1]            => 3 (1's at indices 2 and 5)
[9, 7, 1, 2, 3, 7, 0, -1, -2] => 4 (7's at indices 1 and 5)
[0, 7, 0, 2, 3, 7, 0, -1, -2] => 6 (0's at indices 0 and 6)
[1, 2, 3, 4]                  => 0 (no repeated elements)
This is based on a Kata I had completed only to realize I has misread the instructions. I enjoyed solving the problem I thought it was asking me to complete so I thought I'd add a new Kata for others to enjoy. There are no tricks in this one, good luck! */

//My solution

using System;
using System.Collections.Generic;

public class GreatestDistance
{
  public static int Exec(List<int> data)
  {
        int maxD = 0;
        for (int i = 0; i < data.Count - 1; i++) {
            for (int j = i + 1; j < data.Count; j++) {
                if (data[i] == data[j]) {
                    int temp = Math.Abs(j - i);
                    maxD = maxD > temp ? maxD : temp;
                } 
            }
        }
        return maxD;
  }
}