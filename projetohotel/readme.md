

Aqui está uma explicação detalhada de cada parte do seu programa.

---

### O Que o Programa Faz

Programa simula um sistema de reservas de hotel simples. Ele é capaz de:

1.  **Criar hóspedes** (`Pessoa`).
2.  **Criar suítes** de diferentes tipos e capacidades (`Suite`).
3.  **Realizar uma reserva**, que conecta hóspedes e suítes por um certo período (`Reserva`).
4.  **Validar regras de negócio**, como a capacidade da suíte.
5.  **Calcular o valor total da reserva**, aplicando um desconto se a estadia for longa.

---

### Como Cada Classe Funciona

#### 1. `Pessoa.cs`
Esta é a classe mais simples. Ela serve como um **molde** para criar objetos que representam uma pessoa.

-   **Propriedades**: `Nome` e `Sobrenome`. Elas armazenam as informações básicas de um hóspede.
-   **Construtor**: A linha `public Pessoa(string nome, string sobrenome)` é o construtor. Ele garante que, para criar um novo objeto `Pessoa`, você deve fornecer um nome e um sobrenome.

#### 2. `Suite.cs`
Esta classe representa a suíte do hotel, com suas características.

-   **Propriedades**: `TipoSuite`, `Capacidade` e `ValorDiaria`. Elas descrevem o tipo de quarto, quantas pessoas ele comporta e o valor por dia.
-   **Construtor**: Similar à classe `Pessoa`, o construtor exige que você forneça todos esses dados ao criar uma nova suíte, garantindo que ela seja inicializada corretamente.

#### 3. `Reserva.cs`
Esta é a classe central do seu projeto, onde a lógica de negócios acontece.

-   **Propriedades**:
    -   `Hospedes`: Uma lista (`List<Pessoa>`) que armazena todos os hóspedes da reserva.
    -   `Suite`: A suíte que foi reservada. O modificador **`required`** é a parte mais importante aqui. Ele força a inicialização da suíte quando a reserva é criada, evitando que ela seja `null` e prevenindo erros.
    -   `DiasReservados`: A duração da estadia.
-   **Métodos (Ações)**:
    -   `CadastrarHospedes()`: Recebe uma lista de hóspedes. Ele contém a **validação da capacidade** — se o número de hóspedes for maior que a capacidade da suíte, ele lança uma exceção, impedindo a reserva.
    -   `ObterQuantidadeHospedes()`: Retorna o número de pessoas na lista `Hospedes`.
    -   `CalcularValorDiaria()`: Faz o cálculo principal. Ele multiplica a diária da suíte pelo número de dias e, em seguida, verifica se a estadia é de 10 dias ou mais para aplicar o **desconto de 10%**.

#### 4. `Program.cs`
Este é o coração do programa, onde tudo é montado e testado. Ele demonstra como usar as outras classes.

-   O código cria objetos (`Suite`, `Pessoa`, `Reserva`).
-   Ele conecta a suíte e os hóspedes à reserva.
-   Cada `Console.WriteLine` mostra o resultado de uma operação, como a quantidade de hóspedes ou o valor total.
-   Os blocos `try...catch` são usados para tratar erros, como a exceção lançada quando a capacidade da suíte é excedida. Isso mostra como seu programa lida de forma segura com situações inesperadas.

Em resumo, o projeto de hotel é um exemplo prático de como a **POO** facilita a organização e o gerenciamento de um sistema complexo. Você dividiu o problema em partes menores e interligadas (as classes), tornando o código mais fácil de entender, manter e testar.