jQuery("#sortrows").jqGrid({
    url: 'server.php?q=2',
    datatype: "json",
    colNames: ['Inv No', 'Date', 'Client', 'Amount', 'Tax', 'Total', 'Notes'],
    colModel: [
   		{ name: 'id', index: 'id', width: 55 },
   		{ name: 'invdate', index: 'invdate', width: 90 },
   		{ name: 'name', index: 'name asc, invdate', width: 100 },
   		{ name: 'amount', index: 'amount', width: 80, align: "right" },
   		{ name: 'tax', index: 'tax', width: 80, align: "right" },
   		{ name: 'total', index: 'total', width: 80, align: "right" },
   		{ name: 'note', index: 'note', width: 150, sortable: false }
    ],
    rowNum: 10,
    width: 700,
    rowList: [10, 20, 30],
    pager: '#psortrows',
    sortname: 'invdate',
    viewrecords: true,
    sortorder: "desc",
    caption: "Sortable Rows Example"
});
jQuery("#sortrows").jqGrid('navGrid', '#psortrows', { edit: false, add: false, del: false }).jqGrid('sortableRows');
