function InputImgCreate() {
    const inputFile = document.querySelector("#imagem");
    const pictureImage = document.querySelector(".imagem");
    const pictureImageTxt = "Escolha uma Imagem";
    pictureImage.innerHTML = pictureImageTxt;

    inputFile.addEventListener("change", function (e) {
        const inputTarget = e.target;
        const file = inputTarget.files[0];

        if (file) {
            const reader = new FileReader();

            reader.addEventListener("load", function (e) {
                const readerTarget = e.target;

                const img = document.createElement("img");
                img.src = readerTarget.result;
                img.classList.add("imagem");

                pictureImage.innerHTML = "";
                pictureImage.appendChild(img);
            });

            reader.readAsDataURL(file);
        } else {
            pictureImage.innerHTML = pictureImageTxt;
        }
    }); 
}
function InputImgEdit() {
    const inputFile = document.querySelector("#imagem");

    inputFile.addEventListener("change", function (e) {
       
        

        const inputTarget = e.target;
        const file = inputTarget.files[0];

        if (file) {
            const reader = new FileReader();

            reader.addEventListener("load", function (e) {
                
                try {
                    const imgDb = document.getElementById("imagemEdit")
                    imgDb.remove()
                } catch (e) {

                }
                
                const readerTarget = e.target;

                const img = document.createElement("img");
                img.src = readerTarget.result;
                img.classList.add("imagem");

                pictureImage.innerHTML = "";
                pictureImage.appendChild(img);
            });

            reader.readAsDataURL(file);
        } else {
            pictureImage.innerHTML = pictureImageTxt;
        }
        const pictureImage = document.querySelector(".imagem");
        const pictureImageTxt = "Escolha uma Imagem";
        pictureImage.innerHTML = pictureImageTxt;
    });     
   
}
