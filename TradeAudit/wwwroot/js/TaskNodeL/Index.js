$(document).ready(function ($) {
    var baseTable = $('#baseTable').DataTable({
        searching: false,
        ordering: true,
        paging: true,
        autoWidth: true,
        serverSide: true,
        processing: false,
        order: [[0, 'asc']],
        ajax: {
            url: "/Report/GetCurrentInventorys",
            type: "post",
            data: function (data) {
                delete data.search;

                var $form = $("#BaseFormId");
                var formData = CommonHelper.serializeFormToObject($form);
                jQuery.extend(data, formData);
            }
        },
        columns: [
            {
                "targets": 0,
                "data": "fStockName"
            },
            {
                "targets": 1,
                "data": "materialNumber",
                "orderable": false
            },
            {
                "targets": 2,
                "data": "materialName"

            },
            {
                "targets": 3,
                "data": "fProduceDate"

            },
            {
                "targets": 4,
                "data": "fkfPeriod",
                "orderable": false
            },
            {
                "targets": 5,
                "data": "remainingMonths",
                "orderable": false
            },
            {
                "targets": 4,
                "data": "ffBaseQty",
                "orderable": false
            },
            {
                "targets": 5,
                "data": "fName",
                "orderable": false
            },
            {
                "targets": 6,
                "data": "fModel",
                "orderable": false
            }
        ]
    });

    $("#SumitBtnId").click(function (event) {
        event.preventDefault();
        ReloadTable();
    });

    function ReloadTable() {
        baseTable.ajax.reload();
    }
    layui.use('form');

    $.post("/Report/GetTotalBaseQty", getFormData(), function (data) {
        if (data.code == "-1") {
            console.log(data)
        }
        else {
            var _$stock = $("#StockQuantitySpanId");
            _$stock.empty();
            _$stock.text(data.totalQuantity);
        }
    });

    function getFormData() {
        var $form = $("#BaseFormId");
        var formData = CommonHelper.serializeFormToObject($form);
        return formData;
    }
});

