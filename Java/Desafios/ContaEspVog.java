import java.util.Scanner;

public class ContaEspVog{
    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine();
        str = str.toLowerCase();
        String[] strSplit = str.split(" ");
        char[] arrVogais = {'a', 'e', 'i', 'o', 'u'};
        int espacosEmBranco = strSplit.length - 1, quantVogais = 0;
        for (String item : strSplit) {
            for(int i = 0; i<item.length(); i++){
                char c = item.charAt(i);
                for(char vogal : arrVogais){
                    if(vogal == c){
                        quantVogais++;
                    }
                }
            }
        }
        System.out.println("Espacos em branco: " + espacosEmBranco + " Vogais: " + quantVogais);
    }
}
