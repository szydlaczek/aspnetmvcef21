// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('body').on('click', '.orders-link', function (evt) {
    var row = $(evt.target).closest('tr');
    var customerId = row.attr('data-customer-id');
    $.ajax({
        url: 'Customers/Orders/' + customerId
    })
        .done(function (response) {            
            $('.modal-body').html(response);
        })
        .fail(function () {            
            $('.modal-body').html("Wystąpił błąd w połączniu :(");
        })
        
});