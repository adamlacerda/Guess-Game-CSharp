# Guess Game C#
 Jogo de adivinhação de números em C#
 Programa feito para o Bootcamp Full Stack do Grupo Divina Providência.
 
 O jogo tem três níveis de dificuldade(fácil, médio e difícil), e para cada nível, tem um valor a ser adivinhado em um range e quantidade de vidas diferentes. O número a ser acertado está entre os valores abaixo:
 
Fácil (1-10) Número sorteado entre 1 e 10
Quantidade de vidas: 3

Médio (1-50) Número sorteado entre 1 e 50
Quantidade de vidas: 4

Difícil (1-100) Número sorteado entre 1 e 100
Quantidade de vidas: 5

O usuário pode escolher as opções entre maiúsculas e minúsculas (ToUpper()), e se digitar aluma opção diferente das disponíveis, mostra mensagem de erro, e pede para digitar novamente.

Os valores sorteados são valores aleatórios criados com a variṕavel:

Aleatorio = new Random();
int Sorteado = Aleatorio.Next(1, 10 + 1);

Para ficar atrativo, foram adicionados emojis! 😉

![image](https://user-images.githubusercontent.com/107153882/199973788-38a7fdf8-b198-4742-80ad-2b9cb84b08b3.png)

