//Inicializamos libreria aos
AOS.init();
/*por medio de js seleccionamos nuestros elementos para traer el menu devuelta.*/

let menu = document.getElementById('menu');
let menu_bar = document.getElementById('menu-bar');
menu_bar.addEventListener('click', function(){/*Escuchador de los eventos. Cuando escuche el 
                                                evento click va a ejecutar la función().*/
    menu.classList.toggle('menu-toggle')
});

/* Toggle between showing and hiding the navigation menu links when the user clicks on the hamburger menu / bar icon */
function myFunction() {
    var x = document.getElementById("menu");
    var y = document.getElementById('menu-bar');
    if (x.style.display === "block") {
      x.style.display = "none";
    } else {
      x.style.display = "block"};

      if (y.style.display === "none") {
        y.style.display = "block";
      } else {
        y.style.display = "none";

    }
  }
