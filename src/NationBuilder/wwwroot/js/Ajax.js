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
    //$('.nation').click(function () {
    //    console.log("click");
        $.ajax({
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            url: '/Game/NationGamestate',
            success: function (result) {
                console.log(result);
                var resultString = '<br>Nation: ' + result.name + '<br>Government type: ' + result.governmentType + '<br>Economy type:' + result.economyType + '<br>Geography:' + result.geography + '<br>Wealth:' + result.wealth + '<br>Population:' + result.population + '<br>Workers:' + result.workers + '<br>Food:' + result.food + '<br>Happiness:' + result.happiness;
                $('#GameNation').html(resultString);
            }
        });
    //});
    //$('.map').click(function () {
    //    console.log("click");
        $.ajax({
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            url: '/Game/MapGamestate',
            success: function (result) {
                console.log(result);
                var resultString = '<br>Map Name: ' + result.name + '<br>Food remaining: ' + result.food + '<br>Resources remaining:' + result.resources;
                $('#GameMap').html(resultString);
            }
        });
    //});

    //Assign workers to Resources
        $('#ButtonPlusWood').click(function () {
            $.ajax({
                type: 'GET',
                dataType: 'json',
                contentType: 'application/json',
                url: '/Game/AssignWorkerResources',
                success: function (result) {
                    var workerAssigned = result;
                    $('#WoodWorkers').html(workerAssigned);
                }
            });
        });
});



