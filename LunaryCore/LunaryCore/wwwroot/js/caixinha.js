function funcao1() {
    alert("Tamanho máximo de solicitação excedido.!");
}
$("#campo").click(function () {
    if (condicoes) {
        $.get('/controller/Create/' + parametros);
    }
});
