# 🐦 Flappy Bird Clone

> Uma recriação do clássico **Flappy Bird** desenvolvida em **Unity 3D** utilizando **C#**. 🎮
---
## 🎯 Objetivo do Jogo

O objetivo do jogo é simples: controlar o pássaro através de toques ou cliques para fazê-lo voar entre os canos sem colidir. Cada cano passado conta como um ponto, e o desafio é chegar o mais longe possível!

## 🚀 Funcionalidades Principais

- **Controle por toques**: O pássaro reage aos toques na tela, simulando um movimento de "pular".
- **Obstáculos dinâmicos**: Os canos se movem de maneira constante, aparecendo aleatoriamente com variações na altura.
- **Pontuação automática**: A pontuação aumenta a cada obstáculo superado com sucesso.
- **Tela de Game Over**: Ao colidir com um obstáculo, o jogo exibe uma tela de "Game Over" com a pontuação final.
- **Animações e Física**: Simulação física do pássaro com animações suaves para a movimentação.

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia        | Descrição                              |
|-------------------|----------------------------------------|
| **Unity 3D**      | Motor de desenvolvimento de jogos      |
| **C#**            | Linguagem de programação utilizada     |
| **Visual Studio Code** | IDE para desenvolvimento e edição  |

---

## 📸 Imagens do Projeto

### Gameplay
![Vídeo de Gameplay]("C:\Users\Kauan\Videos\vidiao].mp4") <!-- Substitua pela URL de um GIF ou vídeo do gameplay -->

---

## 🔧 Estrutura do Projeto

### `PlayerController.cs`
Esta classe é responsável por gerenciar o comportamento do personagem principal, o pássaro. Ela detecta os inputs do jogador (toques ou cliques) e aplica a força necessária para simular o salto. Além disso, cuida das colisões com os obstáculos e do sistema de **Game Over**.

### `MoveObjects.cs`
Essa classe lida com a criação e movimentação dos obstáculos (os famosos canos). Os canos são gerados de maneira automática e periódica em posições aleatórias na tela, simulando a variação de dificuldade que o jogador precisa enfrentar.

### `Score.cs`
Responsável por gerenciar a pontuação do jogador. Cada vez que o pássaro ultrapassa um par de canos, a pontuação aumenta. Também cuida de exibir a pontuação na tela durante o jogo e ao final, na tela de **Game Over**.

### `GameManager.cs`
Gerencia o fluxo geral do jogo, como o início, a pausa e o fim. Também é responsável por controlar a troca de cenas, como a transição entre o menu inicial e a gameplay, além de resetar o jogo após o **Game Over**.

### `CameraMove.cs`
A classe CameraMove é responsável por controlar o movimento da câmera, garantindo que ela siga o pássaro durante o jogo. Isso é essencial para manter o jogador sempre visível na tela enquanto o cenário e os obstáculos se movem.

---

