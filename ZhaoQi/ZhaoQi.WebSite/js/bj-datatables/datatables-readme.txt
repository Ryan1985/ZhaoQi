//datatables�������õ��ļ�
  <script type="text/javascript" src="~/js/bj-table-datatables/js/jquery.dataTables.js"></script>
    //<script type="text/javascript" src="~/js/Report/Report.js"></script>

    <script type="text/javascript" src="~/js/bj-table-datatables/js/dataTables.buttons.js"></script>
    <script type="text/javascript" src="~/js/bj-table-datatables/js/jszip.min.js"></script>
    <script type="text/javascript" src="~/js/bj-table-datatables/js/buttons.html5.js"></script>
    <script type="text/javascript" src="~/js/bj-table-datatables/js/buttons.print.js"></script>
  <script type="text/javascript" src="~/js/bj-table-datatables/js/buttons.flash.js"></script>


buttons: [{
						extend: 'excelHtml5',
						text: '<span class="glyphicon glyphicon-export" style="color:#3AF"></span>&nbsp;<span style="color:blue;">Excel</span>',
						customize: function(xlsx) {
							var sheet = xlsx.xl.worksheets['sheet1.xml'];
						}
					}, {
						extend: 'csv',
						text: '<span class="glyphicon glyphicon-export" style="color:#3AF"></span>&nbsp;<span style="color:blue;">CSV</span>',
						exportOptions: {
						    modifier: {
						        search: 'none'
						    }
						}
					}]


//
 buttons: [{
            extend: 'excelHtml5',
            text: '���� Excel',
            customize: function (xlsx) {
                var sheet = xlsx.xl.worksheets['sheet1.xml'];

                $('row c[r^="C"]', sheet).attr('s', '2');
            }
        },
         {
             extend: 'csv',
             text: '���� CSV',
             exportOptions: {
                 modifier: {
                     search: 'none'
                 }
             }
         },
         {
             extend: 'pdf',
             text: '���� pdf'
         },
         {
             extend: 'print',
             text:'��ӡ'
         }
        ]