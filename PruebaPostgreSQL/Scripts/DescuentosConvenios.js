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
//metodo importante para enviar a controlador los datos capturados
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

function exportWordFile(){
    let preHtml = `
        < html xmlns: o = 'urn:schemas-microsoft-com:office:office' xmlns: w = 'urn:schemas-microsoft-com:office:word' xmlns = 'http://www.w3.org/TR/REC-html40' >
            <head>
                <meta charset='utf-8'>
                <title>Export HTML To Doc</title>
                <style>
                    @page row {
                        size:841.7pt 595.45pt;mso-page-orientation:
                        landscape;margin:1.25in 1.0in 1.25in 1.0in;mso-header-margin:.5in;
                        mso-footer-margin:.5in;mso-paper-source:0;}
                    div.row {page:row;}
                </style>
            </head>
            <body>`;
    let postHtml = `
            </body>
        </html>`;
    let table = `
        <div class="row">
            <h1>Listado de Descuentos</h1>
        </div>
        `;

    var html = preHtml + table+ buildTableReport()+ postHtml;

    var blob = new Blob(['\ufeff', html], {
        type: 'application/msword'
    });
    
    // Specify link url
    var url = 'data:application/vnd.ms-word;charset=utf-8,' + encodeURIComponent(html);
    
    // Specify file name
    filename = 'Descuentos.doc';
    
    // Create download link element
    var downloadLink = document.createElement("a");

    document.body.appendChild(downloadLink);
    
    if(navigator.msSaveOrOpenBlob ){
        navigator.msSaveOrOpenBlob(blob, filename);
    }else{
        // Create a link to the file
        downloadLink.href = url;
        
        // Setting the file name
        downloadLink.download = filename;
        
        //triggering the function
        downloadLink.click();
    }
    
    document.body.removeChild(downloadLink);
}

function buildTableReport() {
    let headerTable = `
    <div class="row">
        <table class="">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Sucursal</th>
                    <th>Convenio</th>
                    <th>Identifnicacion</th>
                    <th>Nombre</th>
                    <th>Modulo</th>
                    <th>Concepto</th>
                    <th>Credito</th>
                    <th>Fecha Vencimiento</th>
                    <th>Cuota</th>
                    <th>ValorDefinitivo</th>
                    <th>Forma de Pago</th>
                </tr>
            </thead>
            <tbody>`;
    let footerTable = `
            </tbody>
        </table>
    </div>`;
    return headerTable + createRow() + footerTable;
}

function createRow() {
    let listRow = ``;
    for (i = 0; i < descuentosArray.length; i++) {
        listRow = listRow + `
        <tr>
            <td>`+ descuentosArray[i].Id + `</td>
            <td>`+ descuentosArray[i].Sucursal + `</td>
            <td>`+ descuentosArray[i].Convenio + `</td>
            <td>`+ descuentosArray[i].Identifnicacion + `</td>
            <td>`+ descuentosArray[i].Nombre + `</td>
            <td>`+ descuentosArray[i].Modulo + `</td>
            <td>`+ descuentosArray[i].Concepto + `</td>
            <td>`+ descuentosArray[i].Credito + `</td>
            <td>`+ descuentosArray[i].FechaVencimiento.toISOString().substring(0, 10) + `</td>
            <td>`+ descuentosArray[i].Cuota + `</td>
            <td>`+ descuentosArray[i].ValorDefinitivo + `</td>
            <td>`+ descuentosArray[i].FormaPago + `</td>
        </tr >`;
    }
    return listRow;
}

function exportCVSFile() {
    let arrayContent = [["Listado Descuentos"],["Id;Sucursal;Convenio;Identifnicacion;Nombre;Modulo;Concepto;Credito;FechaVencimiento;Cuota;ValorDefinitivo;FormaPago"]];
    for (i = 0; i < descuentosArray.length; i++) {
        let temmpArray=[descuentosArray[i].Id + ";" +
            descuentosArray[i].Sucursal + ";" +
            descuentosArray[i].Convenio + ";" +
            descuentosArray[i].Identifnicacion + ";" +
            descuentosArray[i].Nombre + ";" +
            descuentosArray[i].Modulo + ";" +
            descuentosArray[i].Concepto + ";" +
            descuentosArray[i].Credito + ";" +
            descuentosArray[i].FechaVencimiento.toISOString().substring(0, 10) + ";" +
            descuentosArray[i].Cuota + ";" +
            descuentosArray[i].ValorDefinitivo + ";" +
            descuentosArray[i].FormaPago];
        arrayContent.push(temmpArray);
    }
    let csvContent = arrayContent.join("\n");
    let link = window.document.createElement("a");
    link.setAttribute("href", "data:text/csv;charset=utf-8,%EF%BB%BF" + encodeURI(csvContent));
    link.setAttribute("download", "Descuentos.csv");
    link.click(); 
}

function exportPlainFile() {
    let arrayContent = [["Listado Descuentos"], ["Id;Sucursal;Convenio;Identifnicacion;Nombre;Modulo;Concepto;Credito;FechaVencimiento;Cuota;ValorDefinitivo;FormaPago"]];
    for (i = 0; i < descuentosArray.length; i++) {
        let temmpArray = [descuentosArray[i].Id + ";" +
            descuentosArray[i].Sucursal + ";" +
            descuentosArray[i].Convenio + ";" +
            descuentosArray[i].Identifnicacion + ";" +
            descuentosArray[i].Nombre + ";" +
            descuentosArray[i].Modulo + ";" +
            descuentosArray[i].Concepto + ";" +
            descuentosArray[i].Credito + ";" +
            descuentosArray[i].FechaVencimiento.toISOString().substring(0, 10) + ";" +
            descuentosArray[i].Cuota + ";" +
            descuentosArray[i].ValorDefinitivo + ";" +
            descuentosArray[i].FormaPago];
        arrayContent.push(temmpArray);
    }
    let csvContent = arrayContent.join("\n\r");
    let link = window.document.createElement("a");
    link.setAttribute("href", "data:text/plain;charset=utf-8,%EF%BB%BF" + encodeURI(csvContent));
    link.setAttribute("download", "Descuentos.txt");
    link.click();
}

function exportPDFFile() {
    //var head = [["ID", "Country", "Rank", "Capital"]];
    let head=[["Id","Sucursal","Convenio","Identifnicacion","Nombre","Modulo","Concepto","Credito","FechaVencimiento","Cuota","ValorDefinitivo","FormaPago"]];
    var body = [];
    for (i = 0; i < descuentosArray.length; i++) {
        let temmpArray = [descuentosArray[i].Id,
            descuentosArray[i].Sucursal,
            descuentosArray[i].Convenio,
            descuentosArray[i].Identifnicacion,
            descuentosArray[i].Nombre,
            descuentosArray[i].Modulo,
            descuentosArray[i].Concepto,
            descuentosArray[i].Credito,
            descuentosArray[i].FechaVencimiento.toISOString().substring(0, 10),
            descuentosArray[i].Cuota,
            descuentosArray[i].ValorDefinitivo,
            descuentosArray[i].FormaPago];
        body.push(temmpArray);
    }
    var doc = new jsPDF('l', 'mm', 'a4');
    doc.text(15, 15, "Listado de Descuentos");
    //doc.autoTable({ head: head, body: body });
    doc.autoTable({ head: head, body: body, startY: 20, showHead: 'firstPage'});
    doc.output("dataurlnewwindow");
}

function buttonGroup_ItemClick(e) {
    let event = e.itemData.hint;
    if (event === "pdf") { exportPDFFile(); }
    if (event === "excel") { exportCVSFile(); }
    if (event === "plain") { exportPlainFile(); }
    if (event === "word") { exportWordFile(); }
}