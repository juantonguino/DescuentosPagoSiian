var descuentosArray = getArray("jsonObjct");
var descuentosIndividualArray = getArray("jsonObjctIndividual");
var seleccionConsolidaddo = [];
var seleccionIndividual = [];

$('.select-custom-multiple').select2();
$('.dx-toolbar-after´').addClass("hideElement");

function getArray(id) {
    temp = JSON.parse($("#"+id).val());
    for (i = 0; i < temp.length; i++) {
        temp[i].FechaVencimiento = new Date(temp[i].FechaVencimiento);
    }
    return temp;
}

function getDataGridInstance() {
    return $("#gridContainerConsolidado").dxDataGrid("instance");
}

function getDataDetalleInstance() {
    return $("#gridContainerDestalle").dxDataGrid("instance");
}

function getDataIndividualInstance() {
    return $("#gridContainerIndividual").dxDataGrid("instance");
}

function selection_changed_consolidado(selectedItems) {
    seleccionConsolidaddo = selectedItems.selectedRowsData;
    console.log(seleccionConsolidaddo);
}

function selection_changed_individual(selectedItems) {
    seleccionIndividual = selectedItems.selectedRowsData;
    console.log(seleccionIndividual);
}

function actionBtnConsultarGeneral(e) {
    let vencidosHasta = $('#vencimientosHasta').val();
    vencidosHasta=vencidosHasta.replace(/-/g, '\/');
    let sucursal = $('#sucursal').val();
    let convenio = $('#convenio').val();
    let modulo = $('#modulo').val();
    let formaPago = $('#formaPago').val();
    let filterTable = buildFilter(vencidosHasta, sucursal, convenio, modulo, formaPago);
    //tabla consolidado
    getDataGridInstance().clearFilter();
    getDataGridInstance().filter(filterTable);
    //tabla detalle
    getDataDetalleInstance().clearFilter();
    getDataDetalleInstance().filter(filterTable);
}

function actiondConsultarIndivudual(e) {
    let vencidosHastaI = $('#vencimientosHastaI').val();
    vencidosHastaI = vencidosHastaI.replace(/-/g, '\/');
    let sucursalI = $('#sucursalI').val();
    let convenioI = $('#convenioI').val();
    let identificaionI = $("#identificaionI").val();
    let moduloI = $('#moduloI').val();
    let formaPagoI = $('#formaPagoI').val();
    if (!(vencidosHastaI == "" && sucursalI == null && convenioI=="" && identificaionI==""&& moduloI==""&& formaPagoI == "")) {
        $("#individualDatatable").removeClass("hideElement");
        $('#botonagregarindividual').removeClass("hideElement");
    }
    let filterTableI = buildFilterIndividual(vencidosHastaI, sucursalI, convenioI, moduloI, formaPagoI, identificaionI);
    //tabla consolidado
    //getDataIndividualInstance().clearFilter();
    getDataIndividualInstance().clearFilter();
    getDataIndividualInstance().filter(filterTableI);
}

function preparateArrayFilter(columnName, array) {
    let retorno = [];
    if (array === null) {
        return retorno;
    }

    for (i = 0; i < array.length; i++) {
        arrayValue = [columnName, "contains", array[i]];
        retorno.push(arrayValue);
        if (!(i + 1 === array.length)) {
            retorno.push("or");
        }
    }
    return retorno;
}

function buildFilter(vencidosHasta, sucursal, convenio, modulo, formaPago) {
    let retorno = [
        ["Convenio", "contains", convenio],
        "and",
        ["Modulo", "contains", modulo],
        "and",
        ["FormaPago", "contains", formaPago]
    ];
    arraySucursalFilter = preparateArrayFilter("Sucursal", sucursal);

    if (arraySucursalFilter.length !== 0) {
        retorno.push("and");
        retorno.push(arraySucursalFilter);
    }
    if (vencidosHasta !== "") {
        retorno.push("and");
        retorno.push(["FechaVencimiento", "<=", new Date(vencidosHasta).addHours(24)]);
    }
    return retorno;
}

function buildFilterIndividual(pvencidosHastaI, psucursalI, pconvenioI, pmoduloI, pformaPagoI, pidentificaionI) {
    let retorno = [
        ["Convenio", "contains", pconvenioI],
        "and",
        ["Modulo", "contains", pmoduloI],
        "and",
        ["FormaPago", "contains", pformaPagoI],
        "and",
        ["Identifnicacion", "contains", pidentificaionI]
    ];
    arraySucursalFilter = preparateArrayFilter("Sucursal", psucursalI);

    if (arraySucursalFilter.length !== 0) {
        retorno.push("and");
        retorno.push(arraySucursalFilter);
    }
    if (pvencidosHastaI !== "") {
        retorno.push("and");
        retorno.push(["FechaVencimiento", "<=", new Date(pvencidosHastaI).addHours(24)]);
    }
    return retorno;
}

function limpiarConsultaIndividual(e) {
    $('#vencimientosHastaI').val("");
    $('#sucursalI').val("");
    $('#convenioI').val("");
    $("#identificaionI").val("");
    $('#moduloI').val("");
    $('#formaPagoI').val("");
    $('.select-custom-multiple').val(null).trigger("change");
    $("#individualDatatable").addClass("hideElement");
    $('#botonagregarindividual').addClass("hideElement");
    getDataIndividualInstance().clearFilter();
}

function limpiarConsultaConsolidado(e) {
    $('#vencimientosHasta').val("");
    $('#sucursal').val("");
    $('#convenio').val("");
    $('#modulo').val("");
    $('#formaPago').val("");
    $('.select-custom-multiple').val(null).trigger("change");
    getDataGridInstance().clearFilter();
    getDataDetalleInstance().clearFilter();
}

function elminarRegistroConsolidado(e) {
    for (i = 0; i < seleccionConsolidaddo.length; i++) {        
        index = descuentosArray.indexOf(seleccionConsolidaddo[i]);
        descuentosArray.splice(index, 1);
    }
    getDataGridInstance().refresh();
    getDataDetalleInstance().refresh();
    getDataIndividualInstance().refresh();
}

function guardar(e) {
    limpiarConsultaConsolidado(null);
    getDataGridInstance().saveEditData(); 
    updateArrayConsolidado();
    getDataDetalleInstance().refresh();
    $('#detalleTab').click();
}

function updateArrayConsolidado() {
    for (i = 0; i < descuentosArray.length; i++) {
        tempValue = descuentosArray[i].ValorDistinto;
        tempDefStr = descuentosArray[i].ValorDefinitivo;
        if (tempValue !== "") {
            tempFloatDistinct = parseFloat(tempValue.replace(/,/g, ""));
            temoDef = parseFloat(tempDefStr.replace(/,/g, ""));
            descuentosArray[i].ValorDefinitivo = formatNumbrer(tempFloatDistinct);
        }
    }
}

function adicionar(e) {
    getDataIndividualInstance().saveEditData();
    for (i = 0; i < seleccionIndividual.length; i++) {
        descuentosArray.push(seleccionIndividual[i]);
        index = descuentosIndividualArray.indexOf(seleccionIndividual[i]);
        descuentosIndividualArray.splice(index, 1);
    }
    seleccionIndividual = [];
    getDataIndividualInstance().refresh();
    getDataGridInstance().refresh();
    getDataDetalleInstance().refresh();
    $('#generalTab').click();
}

function validateForm() {
    let retorno = true;
    fecha = $("#fecha").val();
    detalle = $("#detalle").val();
    if (detalle === "") {
        retorno = false;
        DevExpress.ui.notify("El campo detalle no puede ser nulo", "error", 6000);
    }
    if (fecha === "") {
        retorno = false;
        DevExpress.ui.notify("El campo fecha no puede ser nulo", "error", 6000);
    }
    return retorno;
}

function enviarAction(e) {
    if (validateForm()) {
        sendFrom("Create");
    }
}

function formatNumbrer(number) {
    return number.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function sendFrom(route) {
    $("#jsonToSend").val(JSON.stringify(descuentosArray));
    $("#proximoNumeroDisponible").removeAttr("disabled");
    $("#FromData").attr("action", route);
    $("#FromData").submit();
}
