// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
src = "https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js";


    $(document).ready(function () {

        $('#button1').click(function () {
            $.ajax({
                type: 'GET',
                url: 'Admin/LoaiPhongs',
                success: function (result) {
                    $('#result1').html(result);
                }
            });
            $.ajax({
                type: 'GET',
                url: 'Admin/Phongs',
                success: function (result) {

                    $('#result3').html(result);
                }
            });
        });
    });

