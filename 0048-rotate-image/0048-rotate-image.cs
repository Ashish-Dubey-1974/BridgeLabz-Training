class Solution {
    public void Rotate(int[][] matrix) {
        transpose(matrix);
        inverse(matrix);
    }
    void transpose(int[][] arr){
        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<arr[i].Length;j++){
                if(i==j)break;
                else{
                    int temp = arr[i][j];
                    arr[i][j] = arr[j][i];
                    arr[j][i] = temp;
                }
            }
        }
    }
    void inverse(int[][] arr){
        for(int i=0;i<arr.Length;i++){
            int a=0;
            int b=arr[a].Length-1;
            while(a<b){
                int temp = arr[i][a];
                arr[i][a] = arr[i][b];
                arr[i][b] = temp;
                a++;
                b--;
            }
        } 
    }   
}