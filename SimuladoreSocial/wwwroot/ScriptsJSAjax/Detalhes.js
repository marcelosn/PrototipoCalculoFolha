//Scripts de ajuste para os efeitos no botão de pesquisa
$(document).ready(function () {
    $(".AbreModal").mouseover(function () {
        $(this).css("cursor", "pointer");
        $(this).toggleClass('zoom');
    });

    $(".campoLeitura").css("cursor", "default");
    $(".campoLeitura").prop('disabled', true);
    $(".AbreModalCondicao").css("cursor", "default");
    

    $("#btnEnvia").click(function (event) {
        event.preventDefault();
        var form = document.getElementById("formEmpresa");
        var data = $(form).serialize();
        $.post(form.action, data, function (response) {
            alert("Conexão feita com sucesso");
            alert(response);         
        });
    });
});



//
function BloqueiaElemento() {
    $(this).prop('disable', true);
}

function LiberaElemento() {
    $(this).prop('disable', false);
}