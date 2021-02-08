using System;
class MainClass {  
  static int[] arr = new int[] {20,49,5,1,66,29,55,7};
  public static void Main (string[] args) {
    Console.WriteLine("Array Before Sorting:");
    foreach(var item in arr){
      Console.Write(item+" , ");      
    }
    SelectionSort();
    Console.WriteLine("\nArray After Sorting:");
    foreach(var item in arr){
      Console.Write(item+" , ");      
    }
  }
  public static void SelectionSort(){
    int min;    
    for(int i=0;i<arr.Length;i++){
      min=i;
      for(int j=i+1;j<arr.Length;j++){
          if (arr[j] < arr[min]){
            min = j;
          }
        }
      if(!(min == i)){
        Swap(min,i);
      }
    }
  }
  public static void Swap (int i, int j){
    int temp;
    temp=arr[i];
    arr[i]=arr[j];
    arr[j]=temp;
  }
}