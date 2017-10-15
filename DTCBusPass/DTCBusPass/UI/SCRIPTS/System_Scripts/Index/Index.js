$(document).ready(function () {
    $("#errorDiv").css("display", "none");
    $('#input-userName').unbind().keyup(function (e) {
        var EmailTextBox = document.getElementById("input-userName");
        ValidateElementUsingRegex(EmailTextBox,"email");
    });

    $('#LoginButtonDiv').click(function () {
        alert('Site In Progress');
    });
    $('#SubmitButtonDiv').click(function () {
        alert('Congratulations!! You are registered for a DTC bus pass');
    });
    $('#input-FirstName').unbind().keyup(function (e) {
        var fNameElem = document.getElementById("input-FirstName");
        ValidateElementUsingRegex(fNameElem);
    });
    $('#input-SurName').unbind().keyup(function (e) {
        var SNameElem = document.getElementById("input-SurName");
        ValidateElementUsingRegex(SNameElem);
    });

    ValidateElementUsingRegex = function (elem,type) {
        var elemVal = elem.value;
        var regex = (type == "email") ? /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/ : /^[a-zA-Z ]*$/;        
        if (!regex.test(elemVal)) {
            elem.style.border = "2px solid red";
        }
        else {
            elem.style.border = "none";
        }
    };
    $('#input-UserEmail').unbind().keyup(function (e) {
        var EmailElem = document.getElementById("input-UserEmail");
        ValidateElementUsingRegex(EmailElem,"email");
    });    
});