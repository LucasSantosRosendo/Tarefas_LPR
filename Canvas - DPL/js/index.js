const canvas = document.getElementById("trailCanvas");
const ctx = canvas.getContext("2d");
const title = document.getElementById("title");
const sound = document.getElementById("sound");
const plusButton = document.getElementById("plusButton");

let particles = [];
let stars = [];
let hue = 180;

// Redimensiona o canvas
function resizeCanvas() {
  canvas.width = window.innerWidth;
  canvas.height = window.innerHeight;
}

resizeCanvas();
window.addEventListener("resize", resizeCanvas);

// Função para criar as partículas
function createParticles(x, y) {
  particles.push({
    x: x,
    y: y,
    size: Math.random() * 10 + 1,
    speedX: (Math.random() - 0.5) * 5,
    speedY: (Math.random() - 0.5) * 5,
    color: `hsl(${hue}, 100%, 50%)`,
    life: 100,
  });
}

// Função para criar estrelas
function createStars() {
  for (let i = 0; i < 100; i++) {
    stars.push({
      x: Math.random() * canvas.width,
      y: Math.random() * canvas.height,
      size: Math.random() * 2 + 1,
      twinkle: Math.random() * 5 + 1,
    });
  }
}

// Função para desenhar estrelas
function drawStars() {
  stars.forEach((star) => {
    ctx.beginPath();
    ctx.arc(star.x, star.y, star.size, 0, Math.PI * 2);
    ctx.fillStyle = "white";
    ctx.fill();
    star.size += Math.sin(star.twinkle) * 0.1; // Faz a estrela "piscar"
  });
}

// Função para desenhar as partículas
function drawParticles() {
  particles.forEach((particle, index) => {
    ctx.beginPath();
    ctx.arc(particle.x, particle.y, particle.size, 0, Math.PI * 2);
    ctx.fillStyle = particle.color;
    ctx.fill();

    // Movimento das partículas
    particle.x += particle.speedX;
    particle.y += particle.speedY;
    particle.size *= 0.95;
    particle.life--;

    // Remove partículas que sumiram
    if (particle.size < 0.5 || particle.life <= 0) {
      particles.splice(index, 1);
    }
  });
}

// Função principal de animação
function animate() {
  ctx.clearRect(0, 0, canvas.width, canvas.height);

  drawStars(); // Desenha estrelas
  drawParticles(); // Desenha partículas

  requestAnimationFrame(animate);
}

// Muda as cores do fundo gradualmente
setInterval(() => {
  document.body.style.backgroundColor =
    document.body.style.backgroundColor === "black" ? "#87CEEB" : "black";
}, 20000); // Muda entre 'dia' e 'noite' a cada 20 segundos

// Evento de mousemove para criar o rastro e tocar o som
document.body.addEventListener("mousemove", (e) => {
  createParticles(e.pageX, e.pageY);

  // Som ao mover o mouse
  if (!sound.paused) {
    sound.currentTime = 0; // Reinicia o som para evitar atraso
  }
  sound.play();
});

// Clique no título para criar estrelas
title.addEventListener("click", () => {
  createStars(); // Adiciona estrelas quando clica no título
});

// Clique no botão "+"
plusButton.addEventListener("click", () => {
  alert("Você encontrou um Easter Egg!");
  window.location.href = "34.html"; // Redireciona para 34.html
});

// Inicia a animação
animate();
