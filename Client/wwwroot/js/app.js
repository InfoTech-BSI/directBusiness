$(document).ready(function(){
    $(document).on('input', '#valorBusca', function() {
        $('#valorExibido').html("Busca a partir 100 reais até " + $(this).val() + " reais.");
    });

    $(document).on('click', '#Comprar', function() {
        $( "#Comprar" ).toggleClass( "active" );
        $( "#Comprar" ).toggleClass( "disabled" );
        $( "#Alugar" ).toggleClass( "active" );
        $( "#Alugar" ).toggleClass( "disabled" );
        $('#valorMinimo').html("5.000 reais");
        $('#valorExibido').html("Busca a partir 5.000 reais até 300000 reais.");
        $('#valorMaximo').html("2.000.000 reais");
        $("#valorBusca").attr("step", 10000);
        $("#valorBusca").attr("min", 5000);
        $("#valorBusca").attr("max", 2000000);
        $("#valorBusca").val(300000);
    });

    $(document).on('click', '#Alugar', function() {
        $( "#Comprar" ).toggleClass( "active" );
        $( "#Comprar" ).toggleClass( "disabled" );
        $( "#Alugar" ).toggleClass( "active" );
        $( "#Alugar" ).toggleClass( "disabled" );
        $('#valorMinimo').html("500 reais");
        $('#valorExibido').html("Busca a partir 500 reais até 2500 reais.");
        $('#valorMaximo').html("15.000 reais");
        $("#valorBusca").attr("step", 200);
        $("#valorBusca").attr("min", 500);
        $("#valorBusca").attr("max", 15000);
        $("#valorBusca").val(2500);
    });

    $(document).on('change', "#valorBusca", function() {
        if( $( "#valorBusca" ).val() == 14900 ){
            $( "#valorBusca" ).val(15000);
            $( "#valorExibido" ).html("Busca a partir 100 reais até " + 15000 + " reais.");
        }
    });

    $(document).on('click', '#CriarConta', function() {
        $("#loginModal").modal('hide');
    });

    $(document).on('click', '.verSenha', function() {
        if( $(".verSenha .senha").first().text() == 'Ver senha' ){
            $(".verSenha .senha").text('Esconder senha');
            $(".senha").attr("type","word");
        }else{
            $(".verSenha .senha").text('Ver senha');
            $(".senha").attr("type","password");
        }
    });

    //Deixado para uso futuro

    // window.addEventListener("load", function(event) {
    //     $( "#stepper" ).on('load', function(){
    //         console.log("Carregou1111111111111");
    //     });
    // });
    // $ (window) .on ('load', function () {
    //     console.log("Carregou1111111111111");
    //     $( ".bs-stepper" ).on ('load', function(){
    //         console.log("Carregou22222222222222");
    //         var stepper = new Stepper(document.querySelector('#stepper'));
    //     });

    //     $(window).on('.bs-stepper', 'ready' ,function() {
    //         console.log("Carregou3333333333");
    //     });
    // });
});

//Funções máscara
//https://nosir.github.io/cleave.js/


// máscara CPF

$(document).on('keypress', ".input-cpf", function() {
    console.log("Ativou máscara CPF");
    const cleave = new Cleave('.input-cpf', {
        delimiters: ['.', '.', '-'],
        blocks: [3, 3, 3, 2],
        numericOnly: true
    });
    $(document).off('keypress', '.input-cpf');
});
$(document).on('focusout', ".input-cpf", function() {
    console.log("Ativou máscara CPF");
    const cleave = new Cleave('.input-cpf', {
        delimiters: ['.', '.', '-'],
        blocks: [3, 3, 3, 2],
        numericOnly: true
    });
    $(document).off('focusout', '.input-cpf');
});

// máscara RG

$(document).on('keypress', ".input-rg", function() {
    console.log("Ativou máscara RG");
    const cleave = new Cleave('.input-rg', {
        delimiters: ['.', '.', '-'],
        blocks: [2, 3, 3, 1],
        uppercase: true
    });
    $(document).off('keypress', '.input-rg');
});
$(document).on('focusout', ".input-rg", function() {
    console.log("Ativou máscara RG");
    const cleave = new Cleave('.input-rg', {
        delimiters: ['.', '.', '-'],
        blocks: [2, 3, 3, 1],
        uppercase: true
    });
    $(document).off('focusout', '.input-rg');
});

// máscara CEP

$(document).on('keypress', ".input-cep", function() {
    console.log("Ativou máscara CEP");
    const cleave = new Cleave('.input-cep', {
        delimiters: ['.', '-'],
        blocks: [2, 3, 2],
        numericOnly: true
    });
    $(document).off('keypress', '.input-cep');
});
$(document).on('focusout', ".input-cep", function() {
    console.log("Ativou máscara CEP");
    const cleave = new Cleave('.input-cep', {
        delimiters: ['.', '-'],
        blocks: [2, 3, 2],
        numericOnly: true
    });
    $(document).off('focusout', '.input-cep');
});

//  máscara Valor

$(document).on('keypress', ".input-valor", function() {
    console.log("Ativou máscara Valor");
    const cleave = new Cleave('.input-valor', {
        numeral: true,
        numeralThousandsGroupStyle : 'thousand',
        numeralDecimalScale : 2,
        numeralPositiveOnly : true,
        numeralDecimalMark: ',',
        delimiter: '.'
    });
    $(document).off('keypress', '.input-valor');
});
$(document).on('focusout', ".input-valor", function() {
    console.log("Ativou máscara Valor");
    const cleave = new Cleave('.input-valor', {
        numeral: true,
        numeralThousandsGroupStyle : 'thousand',
        numeralDecimalScale : 2,
        numeralPositiveOnly : true,
        numeralDecimalMark: ',',
        delimiter: '.'
    });
    $(document).off('focusout', '.input-valor');
});

// máscara Celular

$(document).on('keypress', ".input-celular", function() {
    console.log("Ativou máscara Celular");
    const cleave = new Cleave('.input-celular', {
        numericOnly: true,
        blocks: [0, 3, 5, 4],
        delimiters: ["(", ")", "-"]
    });
    $(document).off('keypress', '.input-celular');
});
$(document).on('focusout', ".input-celular", function() {
    console.log("Ativou máscara Celular");
    const cleave = new Cleave('.input-celular', {
        numericOnly: true,
        blocks: [0, 3, 5, 4],
        delimiters: ["(", ")", "-"]
    });
    $(document).off('focusout', '.input-celular');
});