$(document).ready(function () {
    $("#errorDiv").css("display", "none");
    $('#input-userName').unbind().keyup(function (e) {
        var EmailTextBox = document.getElementById("input-userName");
        ValidateElementUsingRegex(EmailTextBox,"email");
    });

    //$('#LoginButtonDiv').click(function () {
    //    alert('Site In Progress');
    //});
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
    
    $('#SubmitButtonDiv').unbind().click(function () {
        //validation
        var res = false;        
        $("input").each(function () {            
            if ($(this).attr('style') && $(this).attr('style').indexOf('red') > -1) {
                res = true;
                return;
            }
        });

        if (res) {
            alert(' Some invalid fields');
        }
        else {

        }
    });
    $('#button-text').unbind().click(function () {
        $.ajax({
            type: "POST",
            url: "http://localhost:1461/Services/UserInteraction.svc/GetUserDetails",
            data: JSON.stringify({ emailAddress: "khulbe.nitin@gmail.com"  }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                // Replace the div's content with the page method's return.
                alert("resr");
            }
        });
    });
});