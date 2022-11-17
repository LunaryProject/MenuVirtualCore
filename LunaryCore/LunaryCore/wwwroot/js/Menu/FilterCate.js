function FiltroCategorias() {
    var e = document.getElementById("FiltroCategorias");
    var c = e.value;

    var x, i;
    x = document.getElementsByClassName("pratos");
    for (i = 0; i < x.length; i++) {
        removeClass(x[i], "show");
        if (x[i].className.indexOf(c) > -1) addClass(x[i], "show");

    }
    try {
        var titu = document.getElementById("TituloCat");
        titu.remove();
        var Categ = document.createElement('h3'); // is a node
        Categ.setAttribute("class", "Categoria");
        Categ.setAttribute("id", "TituloCat");
        
        Categ.innerHTML = c;
        document.getElementById('Categoria').appendChild(Categ); 
        
    } catch (e) {
        var Categ = document.createElement('h3'); // is a node
        Categ.setAttribute("id", "TituloCat");
        Categ.setAttribute("class", "Categoria");
        Categ.innerHTML = c;
        document.getElementById('Categoria').appendChild(Categ);    
    }
   
   
}

function addClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
        if (arr1.indexOf(arr2[i]) == -1) {
            element.className += " " + arr2[i];
        }
    }
}

function removeClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
        while (arr1.indexOf(arr2[i]) > -1) {
            arr1.splice(arr1.indexOf(arr2[i], 1))
        }
    }
    element.className = arr1.join(" ");
}