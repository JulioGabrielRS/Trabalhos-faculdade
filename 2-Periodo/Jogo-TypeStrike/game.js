const canvas = document.getElementById('gameCanvas');
const ctx = canvas.getContext('2d');
canvas.width = window.innerWidth * 0.8;
canvas.height = 500;

// Carregar as imagens da nave e do meteoro
const shipImg = new Image();
shipImg.src = 'imagens/ship.png';

const meteorImg = new Image();
meteorImg.src = 'imagens/meteor.png';

// Variáveis para a nave e o meteoro
let words = [
    'dados', 'informacao', 'sistema', 'tecnologia', 'computador',
    'software', 'hardware', 'rede', 'banco', 'programacao',
    'algoritmo', 'interface', 'usuario', 'seguranca', 'analise',
    'armazenamento', 'backup', 'nuvem', 'criptografia', 'sinal',
    'protocolos', 'transmissao', 'processamento', 'arquitetura',
    'dados', 'abertos','artificial', 'bigdata', 'testes',
    'data', 'visualizacao', 'esquema', 'metadados', 'fluxo',
    'relacional', 'dispositivo', 'telematica', 'infraestrutura', 
    'teoria', 'codigo', 'frontend', 'backend', 'desenvolvimento',
    'aplicativo', 'web', 'mobile', 'sistemas'
];

let currentWord = '';
let typedWord = '';
let correctCount = 0; // Contador de acertos

let shipX = canvas.width / 2 - 25; // Posição inicial da nave
const shipY = canvas.height - 60; // Posição da nave na parte inferior

let meteorX = Math.random() * (canvas.width - 50); // Posição inicial aleatória do meteoro no topo
let meteorY = 0; // Começa no topo
let meteorSpeed = 1; // Velocidade inicial do meteoro
let gameRunning = false; // Controle de estado do jogo

// Função para desenhar o fundo
function drawBackground() {
    ctx.fillStyle = '#000';
    ctx.fillRect(0, 0, canvas.width, canvas.height);
}

// Função para desenhar a palavra na posição do meteoro
function drawWord() {
    const remainingWord = currentWord.substring(typedWord.length); // Exibir apenas a parte não digitada
    ctx.fillStyle = '#ffffff';
    ctx.font = '25px Courier';
    ctx.fillText(remainingWord, meteorX + 10, meteorY + 80); // Palavra parcial
}

// Função para desenhar a nave
function drawShip() {
    ctx.drawImage(shipImg, shipX, shipY, 50, 50);
}

// Função para desenhar o meteoro
function drawMeteor() {
    ctx.drawImage(meteorImg, meteorX, meteorY, 50, 50);
}

// Função para mover o meteoro em direção à nave
function updateMeteorPosition() {
    const dx = shipX + 25 - (meteorX + 25); // Diferença entre as posições X da nave e do meteoro
    const dy = shipY - meteorY; // Diferença entre as posições Y
    const distance = Math.sqrt(dx * dx + dy * dy); // Distância entre o meteoro e a nave

    // Calcular a velocidade do meteoro
    if (distance > 0) {
        const speedFactor = meteorSpeed / distance; // Ajustar velocidade proporcional à distância
        meteorX += dx * speedFactor; // Atualizar posição X do meteoro
        meteorY += dy * speedFactor; // Atualizar posição Y do meteoro
    }

    // Checar se o meteoro atinge a nave
    if (meteorY + 50 >= shipY && meteorX + 50 >= shipX && meteorX <= shipX + 50) {
        showCollisionAlert(); // Exibir o alerta na tela
        gameRunning = false; // Parar o jogo
    }
}

// Função para exibir o alerta de colisão e aplicar desfoque ao fundo
function showCollisionAlert() {
    const alertDiv = document.getElementById('collisionAlert');
    const finalScore = document.getElementById('finalScore');
    finalScore.innerText = correctCount; // Atualizar o contador de acertos no alerta
    alertDiv.style.display = 'block'; // Exibir o alerta de colisão
    document.getElementById('overlay').style.display = 'block'; // Exibir o overlay
}

// Função para esconder o alerta de colisão e remover desfoque
function hideCollisionAlert() {
    const alertDiv = document.getElementById('collisionAlert');
    alertDiv.style.display = 'none'; // Esconder o alerta de colisão
    document.getElementById('overlay').style.display = 'none'; // Esconder o overlay
}

// Função para resetar o jogo e gerar novos meteoros
function resetGame() {
    typedWord = '';
    currentWord = words[Math.floor(Math.random() * words.length)];
    meteorX = Math.random() * (canvas.width - 50); // Nova posição do meteoro no topo
    meteorY = 0; // Voltar ao topo
    updateScoreCounter(); // Atualiza o contador de acertos
    gameRunning = true; // Iniciar o jogo
    hideCollisionAlert(); // Esconder o alerta
}

function updateScoreCounter() {
    document.getElementById('score').innerText = correctCount;
}

// Adicionar o evento de clique ao botão
document.getElementById('restartButton').addEventListener('click', function () {
    correctCount = 0; // Reiniciar o contador de acertos
    resetGame(); // Reseta o jogo
    meteorSpeed = 1; // Reiniciar a velocidade do meteoro
    gameLoop(); // Reinicia o loop do jogo
});

// Função para verificar se a palavra digitada está correta
function checkInput(event) {
    if (!gameRunning) return; // Se o jogo não estiver rodando, ignora a entrada

    typedWord += event.key; // Adiciona a letra digitada
    document.getElementById('typedWord').innerText = typedWord;

    if (currentWord.startsWith(typedWord)) {
        if (currentWord === typedWord) {
            correctCount++; // Incrementar o contador de acertos
            meteorSpeed += 0.1; // Aumentar a velocidade do meteoro
            resetGame(); // Reseta quando a palavra for completamente digitada
        }
    } else if (event.key === 'Backspace') {
        typedWord = typedWord.slice(0, -1); // Remove a última letra se Backspace for pressionado
    } else {
        typedWord = ''; // Reseta caso o jogador digite errado
    }
}

// Loop do jogo
function gameLoop() {
    drawBackground();
    drawShip();
    drawMeteor();
    drawWord();
    updateMeteorPosition(); // Atualizar a posição do meteoro

    if (gameRunning) {
        requestAnimationFrame(gameLoop);
    }
}

// Iniciar o jogo
resetGame();

window.addEventListener('keydown', checkInput);
gameLoop();


// Adicionar evento para redimensionar o canvas quando a janela é redimensionada
window.addEventListener('resize', resizeCanvas);

// Chamar a função uma vez para definir o tamanho inicial
resizeCanvas();
