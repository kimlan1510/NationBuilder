$(document).ready(function () {
    $('.Register').submit(function (event) {
        console.log("button");
        event.preventDefault();
        $.ajax({
            url: '/Account/Register',
            type: 'POST',
            dataType: 'json',
            data: $(this).serialize(),
            success: function (result) {
                var resultMessage = 'You have added a new user to the database!';
                $('#RegisterMessage').html(resultMessage);
            }
        });
    });
    //Show log in form
    $('.ClickLogIn').click(function () {
        console.log("Login form");
        $.ajax({
            type: 'GET',
            url: '/Account/Login',
            success: function (result) {
                var div = $(result).find('.FormLogIn').html();
                $('#LogInForm').html(div);
            }
        });
    });
    //Show Create Nation Form
    $('.ShowNation').click(function () {
        console.log("Nation form");
        $.ajax({
            type: 'GET',
            url: '/Nation/Create',
            success: function (result) {
                $('#ShowNationForm').html(result);
            }
        });
    });
    //Create Nation
    $('.CreateNation').submit(function (event) {
        console.log("test");
        event.preventDefault();
        $.ajax({
            url: '/Nation/CreateNation',
            type: 'POST',
            dataType: 'json',
            data: $(this).serialize(),
            success: function () {
                var resultMessage = 'Your have created a new nation.';
                $('#CreateNationMessage').html(resultMessage);
            }
        });
    });

    $('.ListNations').click(function () {
        $.ajax({
            type: 'GET',
            url: '/Nation/ListNations',
            success: function (result) {
                $('#ShowAllNations').html(result);
            }
        });
    });


});

