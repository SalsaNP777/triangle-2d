using System;

class MainClass {
  public static void Main (string[] args) {
    int n = 5, column;
    column = n * 5;

    Console.WriteLine("\nOutput:");
    for(int i = 1; i <= n; i++) {
      for(int j = i; j <= column; j += n) {
        Console.Write(j + " ");
      }
      Console.WriteLine();
    }
  }
}
