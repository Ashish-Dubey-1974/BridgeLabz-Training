using System;
public class Solution {
    public IList<int> SpiralOrder(int[][] m) {
        IList<int> list = new List<int>();
        int row = m.Length;
        int col = m[0].Length;
        int topRow=0,leftCol = 0,bottomRow = row-1,rightCol = col-1;
        int total = 0;
        while(row*col>total){
            for(int i=leftCol;i<=rightCol&&row*col>total;i++){
                list.Add(m[topRow][i]);
                total++;
            }
            topRow++;
            for(int i=topRow;i<=bottomRow&&row*col>total;i++){
                list.Add(m[i][rightCol]);
                total++;
            }
            rightCol--;
            for(int i=rightCol;i>=leftCol&&row*col>total;i--){
                list.Add(m[bottomRow][i]);
                total++;
            }
            bottomRow--;
            for(int i=bottomRow;i>=topRow&&row*col>total;i--){
                list.Add(m[i][leftCol]);
                total++;
            }
            leftCol++;
        }
        return list;
    }
}