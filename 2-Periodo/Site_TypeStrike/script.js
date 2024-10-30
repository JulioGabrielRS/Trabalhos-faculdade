function toggleMenu() {
  const navMenu = document.getElementById("nav-menu");
  navMenu.classList.toggle("show");
}

function closeMenu() {
  const navMenu = document.getElementById("nav-menu");
  navMenu.classList.remove("show");
}

function scrollToSection(event, sectionId) {
  event.preventDefault(); // Previne o comportamento padrão do link
  const section = document.getElementById(sectionId);
  
  // Ajuste do scroll considerando o cabeçalho fixo
  const headerOffset = document.querySelector('header').offsetHeight;
  const elementPosition = section.getBoundingClientRect().top;
  const offsetPosition = elementPosition + window.scrollY - headerOffset;

  window.scrollTo({
    top: offsetPosition,
    behavior: 'smooth' // Para uma rolagem suave
  });

  closeMenu(); // Fecha o menu após a seleção
}
