function preloaderTime(){
    console.log("Passou");
    $('#preloader').show();
    $('#Conteudo').hide();
    setTimeout(function () {
        $('#preloader').hide();
        $('#Conteudo').show();
            
    }, 2000);
}