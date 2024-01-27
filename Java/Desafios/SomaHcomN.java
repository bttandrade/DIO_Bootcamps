import java.util.Scanner;

public class SomaHcomN {
    public static void main(String[] Args) {
        
        double h = 0;
        Scanner sc = new Scanner(System.in);
        double n = sc.nextDouble();
        double p = n;
        for (int i = 1; i <= n; i++) {
            h = h + 1/p;
            p--;
        }
        System.out.println(Math.round(h));
    }
}