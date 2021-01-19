/// <reference path="jquery-1.9.1.intellisense.js" />
$(document).ready(function () {
    alert('sd');
    debugger;
    loadListBox();
});

function loadListBox() {
    var URL = 'JvAjax/Contre';
    debugger;
    $.ajax({
        type: "GET",
        url: "URL",
        contentType: "application/json; chareset=utf-8",
        dataType: "json",
        success: function (data) {
            alert('test');
            if (data.total_records > 0) {
                var obj = data.data;
                if (obj == "") {
                    alert('No Country List to load');
                    return;
                }
                var ddlCon = $("[id*=lbCountry]");
                ddlCon.empty();

                $.each(obj, function (i, item) {
                    var OptionValue = item.CONCODE;
                    var OptionText = item.DESCRIPTION;
                    ddlCon.append($("<option></option>").val(OptionValue).html(OptionText));
                });

            }
            else {
                alert('No Country List to Load !');
            }
        },
        error: function (response) {
            alert(response.error);
        }
    })
}