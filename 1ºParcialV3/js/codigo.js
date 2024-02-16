function contraerContenedorMenu() {
    var menu = document.getElementById('contenedorMenu')
    menu.classList.toggle('contraido')
}

function removerUsuario() {
    var usuario = document.getElementById('usuario')
    var menu = document.getElementById('menu')
    var administracion = document.getElementById('administracion')

    if (usuario != null && menu != null && administracion != null) {
        var padre = usuario.parentNode
        padre.removeChild(usuario)
        var padremenu = menu.parentNode
        padremenu.removeChild(menu)
        var padreadministracion = administracion.parentNode
        padreadministracion.removeChild(administracion)
    }
    else {
        location.reload()
    }
}

function funcional() {
    contraerContenedorMenu();
    removerUsuario();
}