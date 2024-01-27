import java.io.IOException;
import java.util.Scanner;

public class PositivoMedia {
    public static void main(String[] args) throws IOException {

        Scanner leitor = new Scanner(System.in);
        int cont = 0;
        double media = 0;
        double x;
        double y = 0;
        for (int i=0; i<6; i++) {
            x = leitor.nextDouble();
            if(x>0){
                cont++;
                y = y+x;
            }
        }
        media = y/cont;
        System.out.println(cont + " valores positivos");
        System.out.println(String.format("%.1f", media));
    }
}