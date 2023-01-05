function handleClick(e)
{
    e.preventDefault();
    console.log(e);
    // const email = document.forms['login']['email'].value;
    const email = document.forms.login.email;
    const passWord = document.forms['login']['password'];
    console.log(email, passWord);
    const emailValue = email.value;
    const passWordValue = passWord.value;

    const passworderrordisplay = passWord.nextElementSibling;

    if(passWordValue.length < 6){
        passWord.style.border = '1px solid red';
        passworderrordisplay.classList.remove('d-none');
        passworderrordisplay.innerHtml += `<li>
        password contain spaces 
        </li>` ;
    }

    if(emailValue.length < 6){
        email.style.border = '1px solid red';
        email.nextElementSibling.classList.remove('d-none');
    }

    if(passWordValue.includes(' ')){
        passWord.style.border = '1px solid red';
        passworderrordisplay.classList.remove('d-none');
        passworderrordisplay.innerHtml += `<li>
        password contain spaces 
        </li>` ;
    }
}