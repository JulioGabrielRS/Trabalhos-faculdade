const canvas = document.getElementById('gameCanvas');
const ctx = canvas.getContext('2d');
canvas.width = window.innerWidth * 0.8;
canvas.height = 500;

const shipImg = new Image();
shipImg.src = 'imagens/ship.png';

const meteorImg = new Image();
meteorImg.src = 'imagens/meteor.png';

const wordLevels = {
    easy: [
        'dados', 'rede', 'banco', 'software', 'hardware', 'monitor', 'mouse', 'teclado', 
        'internet', 'senha', 'email', 'nuvem', 'senha', 'router', 'cabo', 'usb', 'wifi', 
        'backup', 'digital', 'site', 'texto', 'codigo', 'editor', 'menu'
    ],
    medium: [
        'sistema', 'programacao', 'analise', 'criptografia', 'algoritmo', 'compilador', 
        'desenvolvimento', 'interface', 'arquitetura', 'comando', 'linguagem', 'memoria', 
        'processamento', 'controle', 'navegador', 'servidor', 'rede', 'armazenamento', 
        'seguranca', 'senha', 'protocolo', 'framework', 'aplicacao', 'debug'
    ],
    hard: [
        'telematica', 'infraestrutura', 'visualizacao', 'relacional', 'aplicativo', 
        'virtualizacao', 'inteligencia', 'hipermidia', 'criptografico', 'sincronizacao', 
        'otimizacao', 'transmissao', 'autenticacao', 'microprocessador', 'compilacao', 
        'paralelismo', 'multitarefa', 'biometria', 'confiabilidade', 'criptografar', 
        'escalabilidade', 'implementacao', 'protocolos', 'processamento'
    ]
};


const levelSettings = {
    easy: { initialSpeed: 0.8, speedIncrement: 0.05 },
    medium: { initialSpeed: 1.2, speedIncrement: 0.1 },
    hard: { initialSpeed: 1.5, speedIncrement: 0.15 }
};

let currentLevel = ''; // Nível selecionado pelo jogador
let currentWord = '';
let typedWord = '';
let correctCount = 0;
let words = [];
let meteorSpeed = 0;

let shipX = canvas.width / 2 - 25;
const shipY = canvas.height - 60;

let meteorX = Math.random() * (canvas.width - 50);
let meteorY = 0;
let gameRunning = false;

// Função para configurar o nível do jogo
function setLevel(selectedLevel) {
    currentLevel = selectedLevel;
    meteorSpeed = levelSettings[selectedLevel].initialSpeed;
    words = [...wordLevels[selectedLevel]];
    resetGame();
}

// Função para iniciar o jogo
function startGame(selectedLevel) {
    setLevel(selectedLevel);
    document.getElementById('startScreen').style.display = 'none';
    gameRunning = true;
    gameLoop();
}

// Função para mostrar o alerta de colisão com o nível de dificuldade
function showCollisionAlert() {
    const alertDiv = document.getElementById('collisionAlert');
    const finalScore = document.getElementById('finalScore');
    const finalLevel = document.getElementById('finalLevel');
    finalScore.innerText = correctCount;
    finalLevel.innerText = currentLevel;
    alertDiv.style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
}

// Função para esconder o alerta de colisão
function hideCollisionAlert() {
    document.getElementById('collisionAlert').style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
}

// Função para reiniciar o jogo após uma colisão
function resetGame() {
    typedWord = '';
    currentWord = words[Math.floor(Math.random() * words.length)];
    meteorX = Math.random() * (canvas.width - 50);
    meteorY = 0;
    updateScoreCounter();
    hideCollisionAlert();
    gameRunning = true;
}

// Atualiza o contador de acertos
function updateScoreCounter() {
    document.getElementById('score').innerText = correctCount;
}

// Função para verificar a entrada do usuário
function checkInput(event) {
    if (!gameRunning) return;

    typedWord += event.key;
    document.getElementById('typedWord').innerText = typedWord;

    if (currentWord.startsWith(typedWord)) {
        if (currentWord === typedWord) {
            correctCount++;
            meteorSpeed += levelSettings[currentLevel].speedIncrement;
            resetGame();
        }
    } else if (event.key === 'Backspace') {
        typedWord = typedWord.slice(0, -1);
    } else {
        typedWord = '';
    }
}

// Função para desenhar e atualizar a posição do meteoro
function updateMeteorPosition() {
    const dx = shipX + 25 - (meteorX + 25);
    const dy = shipY - meteorY;
    const distance = Math.sqrt(dx * dx + dy * dy);

    if (distance > 0) {
        const speedFactor = meteorSpeed / distance;
        meteorX += dx * speedFactor;
        meteorY += dy * speedFactor;
    }

    if (meteorY + 50 >= shipY && meteorX + 50 >= shipX && meteorX <= shipX + 50) {
        showCollisionAlert();
        gameRunning = false;
    }
}

// Funções para desenhar elementos do jogo
function drawBackground() {
    ctx.fillStyle = '#000';
    ctx.fillRect(0, 0, canvas.width, canvas.height);
}

function drawWord() {
    const remainingWord = currentWord.substring(typedWord.length);
    ctx.fillStyle = '#ffffff';
    ctx.font = '25px Courier';
    ctx.fillText(remainingWord, meteorX + 10, meteorY + 80);
}

function drawShip() {
    ctx.drawImage(shipImg, shipX, shipY, 50, 50);
}

function drawMeteor() {
    ctx.drawImage(meteorImg, meteorX, meteorY, 50, 50);
}

// Função de loop do jogo
function gameLoop() {
    drawBackground();
    drawShip();
    drawMeteor();
    drawWord();
    updateMeteorPosition();

    if (gameRunning) {
        requestAnimationFrame(gameLoop);
    }
}

// Inicializa o jogo
window.addEventListener('keydown', checkInput);
window.addEventListener('resize', resizeCanvas);
resizeCanvas();

// Função para reiniciar o jogo com a dificuldade escolhida
function restartGame(selectedLevel = currentLevel) {
    setLevel(selectedLevel); // Define o novo nível de dificuldade
    correctCount = 0; // Zera o contador de acertos
    resetGame(); // Reinicia o jogo
    meteorSpeed = levelSettings[selectedLevel].initialSpeed; // Define a velocidade inicial
    hideCollisionAlert(); // Esconde o alerta de colisão
    gameLoop(); // Recomeça o loop do jogo
}

// Modificação na função `showCollisionAlert` para exibir o nível atual
function showCollisionAlert() {
    const alertDiv = document.getElementById('collisionAlert');
    const finalScore = document.getElementById('finalScore');
    finalScore.innerText = correctCount; // Atualiza o contador de acertos
    alertDiv.style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
}
