import java.io.IOException;
import java.util.Scanner;
import java.util.Objects;

public class Animal {
	public static void main(String[] args)  throws IOException {

		Scanner sc = new Scanner(System.in);
		String AN1,AN2,AN3;
		String animal = "animal";
		AN1 = sc.nextLine();
		AN2 = sc.nextLine();
		AN3 = sc.nextLine();
		if(Objects.equals(AN1, "vertebrado")){
            if(Objects.equals(AN2, "ave")){
                if(Objects.equals(AN3, "carnivoro"))
                animal = "aguia";
                else if(Objects.equals(AN3, "onivoro"))
                animal = "pomba"; 
            }else if(Objects.equals(AN2, "mamifero")){
                if(Objects.equals(AN3, "onivoro"))
                animal = "homem"; 
                else if(Objects.equals(AN3, "herbivoro"))
                animal = "vaca";
            }
		}else if(Objects.equals(AN1, "invertebrado")){
            if(Objects.equals(AN2, "inseto")){
                if(Objects.equals(AN3, "hematofago"))
                animal = "pulga";
                else if(Objects.equals(AN3, "herbivoro"))
                animal = "lagarta"; 
            }else if(Objects.equals(AN2, "anelideo")){
                if(Objects.equals(AN3, "hematofago"))
                animal = "sanguessuga"; 
                else if(Objects.equals(AN3, "onivoro"))
                animal = "minhoca";
		    }
		}
		System.out.println(animal);
	}
}