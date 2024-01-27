import java.io.IOException;
import java.util.Scanner;

public class TaxaImposto {
    public static void main(String[] args) throws IOException {
        
        Scanner leitor = new Scanner(System.in);
        double renda = leitor.nextDouble();
        double imposto=0;
        if (renda<=2000.00){
            System.out.println("Isento");
        }
        if (renda>2000.00&&renda<=3000.00){
            imposto = (renda - 2000.00)*0.08;
            System.out.printf("R$ " + "%.2f", imposto);
        }else if(renda>3000.00){
            imposto = imposto + 80.00;
            if(renda>3000.00&&renda<=4500.00){
                imposto = imposto + (renda - 3000.00)*0.18;
            }else if(renda>4500.00){
                imposto = imposto + 270.00;
            }
            if (renda>4500.00){
                imposto = imposto + (renda - 4500)*0.28;
            }
            System.out.printf("R$ " + "%.2f", imposto);
        }
    }
}