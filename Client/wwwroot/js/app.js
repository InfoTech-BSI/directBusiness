$(document).ready(function () {
    $(document).on('input', '#valorBusca', function () {
        if ($("#Comprar").hasClass("active")) {
            $('#valorExibido').html("Busca a partir 5000 reais até " + $(this).val() + " reais.");
        }
        if ($("#Alugar").hasClass("active")) {
            $('#valorExibido').html("Busca a partir 100 reais até " + $(this).val() + " reais.");
        }
    });

    $(document).on('click', '#Comprar', function () {
        if (!$("#Comprar").hasClass("active")) {
            $("#Comprar").addClass("active");
            $("#Comprar").removeClass("disabled");
        }
        if ($("#Alugar").hasClass("active")) {
            $("#Alugar").removeClass("active");
            $("#Alugar").addClass("disabled");
        }
        $('#valorMinimo').html("5.000 reais");
        $('#valorExibido').html("Busca a partir 5000 reais até 2000000 reais.");
        $('#valorMaximo').html("2.000.000 reais");
        $("#valorBusca").attr("step", 10000);
        $("#valorBusca").attr("min", 5000);
        $("#valorBusca").attr("max", 2000000);
        $("#valorBusca").val(300000);
    });

    $(document).on('click', '#Alugar', function () {
        if (!$("#Alugar").hasClass("active")) {
            $("#Alugar").addClass("active");
            $("#Alugar").removeClass("disabled");
        }
        if ($("#Comprar").hasClass("active")) {
            $("#Comprar").removeClass("active");
            $("#Comprar").addClass("disabled");
        }
        $('#valorMinimo').html("500 reais");
        $('#valorExibido').html("Busca a partir 500 reais até 2500 reais.");
        $('#valorMaximo').html("15.000 reais");
        $("#valorBusca").attr("step", 200);
        $("#valorBusca").attr("min", 500);
        $("#valorBusca").attr("max", 15000);
        $("#valorBusca").val(2500);
    });

    $(document).on('change', "#valorBusca", function () {
        if ($("#valorBusca").val() == 14900) {
            $("#valorBusca").val(15000);
            $("#valorExibido").html("Busca a partir 100 reais até 15000 reais.");
        }
        if ($("#valorBusca").val() == 1995000) {
            $("#valorBusca").val(2000000);
            $("#valorExibido").html("Busca a partir 5000 reais até 2000000 reais.");
        }
    });

    $(document).on('click', '#CriarConta', function () {
        $("#loginModal").modal('hide');
    });

    $(document).on('click', '.verSenha', function () {
        if ($(".verSenha .senha").first().text() == 'Ver senha') {
            $(".verSenha .senha").text('Esconder senha');
            $(".senha").attr("type", "word");
        } else {
            $(".verSenha .senha").text('Ver senha');
            $(".senha").attr("type", "password");
        }
    });
});

//Funções máscara
//https://nosir.github.io/cleave.js/


// máscara CPF

$(document).on('keyup', ".input-cpf", function () {
    console.log("Ativou máscara CPF");
    const cleave = new Cleave('.input-cpf', {
        delimiters: ['.', '.', '-'],
        blocks: [3, 3, 3, 2],
        numericOnly: true
    });
    $(document).off('keyup', '.input-cpf');
});
$(document).on('focusout', ".input-cpf", function () {
    console.log("Ativou máscara CPF");
    const cleave = new Cleave('.input-cpf', {
        delimiters: ['.', '.', '-'],
        blocks: [3, 3, 3, 2],
        numericOnly: true
    });
    $(document).off('focusout', '.input-cpf');
});

// máscara RG

$(document).on('keyup', ".input-rg", function () {
    console.log("Ativou máscara RG");
    const cleave = new Cleave('.input-rg', {
        delimiters: ['.', '.', '-'],
        blocks: [2, 3, 3, 1],
        uppercase: true
    });
    $(document).off('keyup', '.input-rg');
});
$(document).on('focusout', ".input-rg", function () {
    console.log("Ativou máscara RG");
    const cleave = new Cleave('.input-rg', {
        delimiters: ['.', '.', '-'],
        blocks: [2, 3, 3, 1],
        uppercase: true
    });
    $(document).off('focusout', '.input-rg');
});

// máscara e busca CEP 

function buscaCEP() {

    const cep = $('.input-cep').val();

    $('.icone-cep').html(`
    <span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>
    <span class="sr-only">Carreando...</span>
    `);
    
    $(".icone-cep").addClass("disabled");

    $.get("https://viacep.com.br/ws/" + cep + "/json/", function (data) {
        console.log(data);
        $('#endereco').val(data.logradouro);
        $('#bairro').val(data.bairro);
        $('#cidade').val(data.localidade);
        $('#complemento').val(data.complemento);
        $('#UF').val(data.uf);
    })
        .fail(function () {
            alert("Erro ao procurar cep");
        }).always(function () {
            $('.icone-cep').html(`Buscar CEP <i class="fas fa-search"></i>`);
            $(".icone-cep").removeClass("disabled");
        });
};
$(document).on('keyup', ".input-cep", function () {
    console.log("Ativou máscara CEP");
    const cleave = new Cleave('.input-cep', {
        delimiters: ['-'],
        blocks: [5, 3],
        numericOnly: true
    });
    if ($(this).val().length == 9) buscaCEP();
});
$(document).on('focusout', ".input-cep", function () {
    console.log("Ativou máscara CEP");
    const cleave = new Cleave('.input-cep', {
        delimiters: ['-'],
        blocks: [5, 3],
        numericOnly: true
    });
    $(document).off('focusout', '.input-cep');
});

//  máscara Valor

$(document).on('keyup', ".input-valor", function () {
    console.log("Ativou máscara Valor");
    const cleave = new Cleave('.input-valor', {
        numeral: true,
        numeralDecimalMark: ',',
        delimiter: '.',
        numeralPositveOnly: true
    });
    $(document).off('keyup', '.input-valor');
});
$(document).on('focusout', ".input-valor", function () {
    console.log("Ativou máscara Valor");
    const cleave = new Cleave('.input-valor', {
        numeral: true,
        numeralDecimalMark: ',',
        delimiter: '.',
        numeralPositveOnly: true
    });
    $(document).off('focusout', '.input-valor');
});

// máscara Celular

$(document).on('keyup', ".input-celular", function () {
    console.log("Ativou máscara Celular");
    const cleave = new Cleave('.input-celular', {
        numericOnly: true,
        blocks: [0, 3, 5, 4],
        delimiters: ["(", ")", "-"]
    });
    $(document).off('keyup', '.input-celular');
});
$(document).on('focusout', ".input-celular", function () {
    console.log("Ativou máscara Celular");
    const cleave = new Cleave('.input-celular', {
        numericOnly: true,
        blocks: [0, 3, 5, 4],
        delimiters: ["(", ")", "-"]
    });
    $(document).off('focusout', '.input-celular');
});