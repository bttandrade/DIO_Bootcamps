public class Main {
    public static void main(String[] args) {
        
        Pilha minhPilha = new Pilha();

        minhPilha.push(new No(1));
        minhPilha.push(new No(2));
        minhPilha.push(new No(3));
        minhPilha.push(new No(4));
        minhPilha.push(new No(5));
        minhPilha.push(new No(6));

        System.out.println(minhPilha);
        
        System.out.println(minhPilha.pop());
        System.out.println(minhPilha);
        
        minhPilha.push(new No(9));
        System.out.println(minhPilha);

    }
}
