function checkReg(){
    let email = $("#email").val();
    let name = $("#name").val();
    let password = $("#password").val();
    // console.log(email, name, password);
    
    let isGood = true;
    //password check
    if(password.length < 5) {
        isGood = false;
        $("#password").removeClass("is-valid");
        $("#password").addClass("is-invalid");
    }else{
        $("#password").removeClass("is-invalid");
        $("#password").addClass("is-valid");
    }
    //email check
    let regexEmail = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if(regexEmail.test(email)){
        $("#email").addClass("is-valid");
        $("#email").removeClass("is-invalid");
    }else{
        isGood = false;
        $("#email").removeClass("is-valid");
        $("#email").addClass("is-invalid");
    }
    //name check
    if(password.length < 5) {
        isGood = false;
        $("#password").removeClass("is-valid");
        $("#password").addClass("is-invalid");
    }else{
        $("#password").removeClass("is-invalid");
        $("#password").addClass("is-valid");
    }
    
}