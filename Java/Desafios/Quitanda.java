import java.util.*;

public class Quitanda {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int morangos = input.nextInt();
        int macas = input.nextInt();
        double totalmo=0, totalma=0, total;
        if (morangos<=5){
            totalmo = morangos * 2.50;
        }else if(morangos>5){
            totalmo = morangos * 2.20;
        }
        if (macas<=5){
            totalma = macas * 1.80;
        }else if(macas>5){
            totalma = macas * 1.50;
        }
        total = totalma + totalmo;
        if (total>25 || morangos+macas>8){
            total = total*0.9;
        }
        System.out.println(total);
    }
}