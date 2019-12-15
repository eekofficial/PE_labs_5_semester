/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;
import java.util.Scanner;

/**
 *
 * @author student
 */
public class JavaApplication1 {
    public static void MatrixInput(int[][] x)
        {
            Scanner in = new Scanner(System.in);
            for (int i = 0; i < x.length; i++)
                for (int j = 0; j < x[i].length; j++)
                {
                    while (true)
                    {
                        try
                        {  	
                            System.out.println("Please, enter element [" + (i + 1) + ", " + (j + 1) + "]: ");        
                            x[i][j] = in.nextInt();
                            break;
                        }
                        catch (Throwable exc) { }
                    }
                }
            System.out.println();

        }
    
    public static void PrintMatrix(int[][] x)
        {
            System.out.println("Current values of matrix:");
            for (int i = 0; i < x.length; i++)
            {
                for (int j = 0; j < x[i].length; j++)
                {
                     System.out.print(x[i][j] + " ");
                }
                System.out.println();
            }
            System.out.println();
        }
    
    public static boolean Symmetric(int[][] x) // returns true if matrix is symmetric
        {
            for (int i = 0; i < x.length - 1; i++)
                for (int j = i + 1; j < x[i].length; j++)
                {
                    if (x[i][j] != x[j][i])
                    {
                        return false;
                    }
                }
            return true;
        }

       public static void AboveDiagToZero(int[][] x) // function which zeroizes every element above the giagonal
        {
            for (int i = 0; i < x.length - 1; i++)
                for (int j = i + 1; j < x[i].length; j++)
                {
                    x[i][j] = 0;
                }
        }

        public static int BelowDiagSum(int[][] x) // function which calculetes sum of elements below the diagonal
        {
            int sumx = 0;
            for (int i = 1; i < x.length; i++)
                for (int j = 0; j < i; j++)
                {
                    sumx += x[i][j];
                }
            return sumx;
        }
    
    public static void main(String[] args) {
            Scanner in = new Scanner(System.in);
            int[][] a; // matrix
            int n; // number of rows and columns in matrix
            while (true)
            {
                try
                {
                    System.out.print("Please, enter the number of rows and columns in matrix: ");
                    n =  in.nextInt();
                    a = new int[n][n];
                    break;
                }
                catch (Throwable exc) { }
            }

            MatrixInput(a);
            PrintMatrix(a);

            if (Symmetric(a))
            {
                AboveDiagToZero(a);
                PrintMatrix(a);
                System.out.print("Sum of elements which lies below diagonal: ");
                
                int sum = BelowDiagSum(a);
                System.out.print(sum);
            }
    }
    
}
