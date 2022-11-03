function Like(id) {
    var id = id;
    var url = "/Restaurante/ContagemLikes";
    var status;
    let el = document.getElementById(id);
    //Botão curtido
    if (el.classList.contains('heart-active')) {
        var qtdLikesBefore = document.getElementById(id + "-Curtida")
        var qtdCurtidas = qtdLikesBefore.innerText;
        el.classList.remove('heart-active');
        status = false;
        if (parseInt(qtdCurtidas) > 0) {
            $.post(url, { id: id, status: status }, function (data) {

            });
        }
        console.log(qtdCurtidas)
        qtdLikesBefore.remove()
        var Curti = document.createElement('span');
        Curti.setAttribute("class", "number");
        Curti.setAttribute("id", id + "-Curtida");
        Curti.innerHTML = parseInt(qtdCurtidas) - 1;
        document.getElementById(id + "-Curtidadiv").appendChild(Curti);
    }
    //Botão sem curtir
    else {
        el.classList.add('heart-active');
        status = true;
        $.post(url, { id: id, status: status }, function (data) {

        });
        var qtdLikesBefore = document.getElementById(id + "-Curtida")
        var qtdCurtidas = qtdLikesBefore.innerText;
        console.log(qtdCurtidas)
        qtdLikesBefore.remove()
        var Curti = document.createElement('span');
        Curti.setAttribute("class", "number");
        Curti.setAttribute("id", id + "-Curtida");
        Curti.innerHTML = parseInt(qtdCurtidas) + 1;
        document.getElementById(id + "-Curtidadiv").appendChild(Curti);
    }


};