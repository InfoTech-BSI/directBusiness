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
        $('#valorMinimo').html("100 reais");
        $('#valorExibido').html("Busca a partir 100 reais até 2500 reais.");
        $('#valorMaximo').html("5.000 reais");
        $("#valorBusca").attr("step", 100);
        $("#valorBusca").attr("min", 100);
        $("#valorBusca").attr("max", 5000);
        $("#valorBusca").val(2500);
    });
});