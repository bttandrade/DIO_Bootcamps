const quantidadeGolpes = parseInt(gets());
let minerais = ["Carvao", "Ferro", "Diamante", "Pedra"];
for (let i = 0; i < quantidadeGolpes; i++) {
    let minaIndex = i % minerais.length;
    print(`${i+1}: ${minerais[minaIndex]}`);
}