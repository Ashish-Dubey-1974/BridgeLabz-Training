
using System;
using System.Collections.Generic;

class SetProblems
{
    public static void UnionIntersection()
    {
        HashSet<int> a = new HashSet<int>{1,2,3};
        HashSet<int> b = new HashSet<int>{3,4,5};

        HashSet<int> union = new HashSet<int>(a);
        union.UnionWith(b);

        HashSet<int> intersection = new HashSet<int>(a);
        intersection.IntersectWith(b);
    }
}
