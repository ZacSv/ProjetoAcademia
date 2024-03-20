function abrirFecharElemento(targetId) {
    const elemento = document.getElementById(targetId);
    elemento.style.display = "flex";
}

function fecharModal(targetId) {
    const modal = document.getElementById(targetId);
    modal.style.display = "none";
}

document.addEventListener("click", (event) => {
    const botao = event.target;
    const botaoFechar = event.target;

    if (botaoFechar.classList.contains("icone-fechar")) {
        const targetFechamento = botao.getAttribute("data-target");
        fecharModal(`modal-${targetFechamento}`);
    }
    if (botao.classList.contains("botao-abrir")) {
        const targetId = botao.getAttribute("data-target");
        abrirFecharElemento(`modal-${targetId}`);
    }
});
