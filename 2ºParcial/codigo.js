function validar() {
    usuario = document.getElementById('user').value;
    contraseña = document.getElementById('pass').value;
    const usuRegistrado = "juanperez@gmail.com";
    const contRegistrada = 1787742836863899;
    const min = 8;
    const max = 16;
    var arroba = 0;
    var com;
    if (usuario == usuRegistrado) {
        if (contraseña.length < min) {
            alert("Debe ingresar una contraseña con al menos 8 caracteres");
        } else if (contraseña.length > max) {
            alert("Debe ingresar una contraseña con máximo 16 caracteres");
        } else if (contraseña == contRegistrada) {
            console.log("El usuario fue validado correctamente");
            window.location.href = "swapi.html"
        } else {
            alert("Contraseña invalida");
        }
    }
    else if(contraseña == contRegistrada){
        if (!usuario.includes("@") || !usuario.includes(".com")) {
            alert("El usuario no parece ser un email válido. Verifique @ o .com");
          } else {
            alert("El usuario es incorecto");
          }
    }
    else {
        alert("Usuario y contraseña incorrectas")
    }

}
