// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados e a função print para imprimir a saída(output) de dados.
// Abaixo segue um exemplo de código que você pode ou não utilizar

const line = gets().split("")
const a = line[0];
const b = line[1];
const c = line[2];

//TODO: Complete os espaços em branco com uma possível solução para o problema

if (a + b == c || a + c == b || c + b == a || a ==b ||a ==c ||  b == c) {
    print("S\n");
} else {
    print("N\n");
}
