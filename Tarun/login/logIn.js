
function authenticate() {
    var uname = document.getElementById('uname').value;
    var pass = document.getElementById('pass').value;

    if(uname === 'Tarun' && pass=== '123') alert('log in successfully')
    else alert('unrecognised user name and password')

    console.log(uname);
    console.log(pass);
}

function password_show_hide() {
    var x = document.getElementById("pass");
    var show_eye = document.getElementById("show_eye");
    var hide_eye = document.getElementById("hide_eye");
    hide_eye.classList.remove("d-none");
    if (x.type === "password") {
      x.type = "text";
      show_eye.style.display = "none";
      hide_eye.style.display = "block";
    } else {
      x.type = "password";
      show_eye.style.display = "block";
      hide_eye.style.display = "none";
    }
  }