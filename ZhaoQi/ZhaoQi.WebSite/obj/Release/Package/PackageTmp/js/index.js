"use strict";
var pageViewApp = angular.module('pageView', ['ngRoute', 'ngAnimate']);

pageViewApp.config(function($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '/RealTime/RealTime.html',
            controller: 'realTimeController'
        })
        .when('/RealTime', {
            templateUrl: '/RealTime/RealTime.html',
            controller: 'realTimeController'
        })
        .when('/HistoryData', {
            templateUrl: '/HistoryData/HistoryData.html',
            controller: 'historyDataController'
        });


});


pageViewApp.controller('realTimeController', ['$scope', function($scope) {
    
}]);


pageViewApp.controller('historyDataController', ['$scope', function ($scope) {
    $scope.QueryModel = {
        'UpdateTime@ge': '',
        'UpdateTime@le': '',
    };

    $scope.Inital = function () {
        jQuery.extend(jQuery.fn.bootstrapTable.defaults, jQuery.fn.bootstrapTable.locales['zh-CN']);
        var now = new Date();
        var year = now.getFullYear();
        var month = (now.getMonth() + 101).toString().substr(1, 2);
        var day = (now.getDate() + 100).toString().substr(1, 2);
        jQuery('#datetimepickerStart').datetimepicker({
            format:"yyyy-mm-dd hh:ii:ss",
            language:"zh-CN",
            autoclose:true,
            todaybtn: true,
            fontAwesome: true
        });
        jQuery('#datetimepickerEnd').datetimepicker({
            format: "yyyy-mm-dd hh:ii:ss",
            language: "zh-CN",
            autoclose: true,
            todaybtn: true,
            fontAwesome:true
        });
        jQuery('#datetimepickerStart>input').val(year + '-' + month + '-' + day + ' 00:00:00');
        jQuery('#datetimepickerEnd>input').val(year + '-' + month + '-' + day + ' 23:59:59');
    };

    $scope.Query = function () {
        var startTime = jQuery('#datetimepickerStart>input').val();
        var endTime = jQuery('#datetimepickerEnd>input').val();
        if (startTime) {
            $scope.QueryModel['UpdateTime@ge'] = startTime;
        }

        if (endTime) {
            $scope.QueryModel['UpdateTime@le'] = endTime;
        }

        jQuery.get('../api/HistoryData?filterString=' + JSON.stringify($scope.QueryModel), function (data) {
            //var dataModel = JSON.parse(data);
            jQuery('#ListTable').bootstrapTable('load', data);


            var xAxies = [];
            var serialAxies = [];
            var serialCan_Temp1_1 = [];
            var serialCan_Temp1_2 = [];
            var serialCan_Temp2_1 = [];
            var serialCan_Temp2_2 = [];
            var serialCan_Temp3_1 = [];
            var serialCan_Temp3_2 = [];
            var serialCan_Temp4_1 = [];
            var serialCan_Temp4_2 = [];
            var serialCan_Flow_Dry1 = [];
            var serialCan_Flow_Wet1 = [];
            var serialCan_Produce1 = [];
            var serialCan_Flow_Dry2 = [];
            var serialCan_Flow_Wet2 = [];
            var serialCan_Produce2 = [];
            var serialCan_Flow_Dry3 = [];
            var serialCan_Flow_Wet3 = [];
            var serialCan_Produce3 = [];
            var serialCan_Flow_Dry4 = [];
            var serialCan_Flow_Wet4 = [];
            var serialCan_Produce4 = [];
            var serialCan_Pressure = [];
            var serialStore_Pressure = [];
            var serialSupply_Flow = [];
            var serialSupply_Pressure = [];

            for (var i = 0; i < data.length; i++) {
                xAxies.push(data[i].UpdateTime);
                serialCan_Temp1_1.push(parseFloat(data[i].Can_Temp1_1));
                serialCan_Temp1_2.push(parseFloat(data[i].Can_Temp1_2));
                serialCan_Temp2_1.push(parseFloat(data[i].Can_Temp2_1));
                serialCan_Temp2_2.push(parseFloat(data[i].Can_Temp2_2));
                serialCan_Temp3_1.push(parseFloat(data[i].Can_Temp3_1));
                serialCan_Temp3_2.push(parseFloat(data[i].Can_Temp3_2));
                serialCan_Temp4_1.push(parseFloat(data[i].Can_Temp4_1));
                serialCan_Temp4_2.push(parseFloat(data[i].Can_Temp4_2));
                serialCan_Flow_Dry1.push(parseFloat(data[i].Can_Flow_Dry1));
                serialCan_Flow_Wet1.push(parseFloat(data[i].Can_Flow_Wet1));
                serialCan_Produce1.push(parseFloat(data[i].Can_Produce1));
                serialCan_Flow_Dry2.push(parseFloat(data[i].Can_Flow_Dry2));
                serialCan_Flow_Wet2.push(parseFloat(data[i].Can_Flow_Wet2));
                serialCan_Produce2.push(parseFloat(data[i].Can_Produce2));
                serialCan_Flow_Dry3.push(parseFloat(data[i].Can_Flow_Dry3));
                serialCan_Flow_Wet3.push(parseFloat(data[i].Can_Flow_Wet3));
                serialCan_Produce3.push(parseFloat(data[i].Can_Produce3));
                serialCan_Flow_Dry4.push(parseFloat(data[i].Can_Flow_Dry4));
                serialCan_Flow_Wet4.push(parseFloat(data[i].Can_Flow_Wet4));
                serialCan_Produce4.push(parseFloat(data[i].Can_Produce4));
                serialCan_Pressure.push(parseFloat(data[i].Can_Pressure));
                serialStore_Pressure.push(parseFloat(data[i].Store_Pressure));
                serialSupply_Flow.push(parseFloat(data[i].Supply_Flow));
                serialSupply_Pressure.push(parseFloat(data[i].Supply_Pressure));
            }
            serialAxies.push({ 'name': '1#罐体温度1', 'data': serialCan_Temp1_1 });
            serialAxies.push({ 'name': '1#罐体温度2', 'data': serialCan_Temp1_2 });
            serialAxies.push({ 'name': '2#罐体温度1', 'data': serialCan_Temp2_1 });
            serialAxies.push({ 'name': '2#罐体温度2', 'data': serialCan_Temp2_2 });
            serialAxies.push({ 'name': '3#罐体温度1', 'data': serialCan_Temp3_1 });
            serialAxies.push({ 'name': '3#罐体温度2', 'data': serialCan_Temp3_2 });
            serialAxies.push({ 'name': '4#罐体温度1', 'data': serialCan_Temp4_1 });
            serialAxies.push({ 'name': '4#罐体温度2', 'data': serialCan_Temp4_2 });
            serialAxies.push({ 'name': '1#罐体进干', 'data': serialCan_Flow_Dry1 });
            serialAxies.push({ 'name': '1#罐体进湿', 'data': serialCan_Flow_Wet1 });
            serialAxies.push({ 'name': '1#罐体产气', 'data': serialCan_Produce1 });
            serialAxies.push({ 'name': '2#罐体进干', 'data': serialCan_Flow_Dry2 });
            serialAxies.push({ 'name': '2#罐体进湿', 'data': serialCan_Flow_Wet2 });
            serialAxies.push({ 'name': '2#罐体产气', 'data': serialCan_Produce2 });
            serialAxies.push({ 'name': '3#罐体进干', 'data': serialCan_Flow_Dry3 });
            serialAxies.push({ 'name': '3#罐体进湿', 'data': serialCan_Flow_Wet3 });
            serialAxies.push({ 'name': '3#罐体产气', 'data': serialCan_Produce3 });
            serialAxies.push({ 'name': '4#罐体进干', 'data': serialCan_Flow_Dry4 });
            serialAxies.push({ 'name': '4#罐体进湿', 'data': serialCan_Flow_Wet4 });
            serialAxies.push({ 'name': '4#罐体产气', 'data': serialCan_Produce4 });
            serialAxies.push({ 'name': '罐体压力', 'data': serialCan_Pressure });
            serialAxies.push({ 'name': '储气压力', 'data': serialStore_Pressure });
            serialAxies.push({ 'name': '供气流量', 'data': serialSupply_Flow });
            serialAxies.push({ 'name': '供气压力', 'data': serialSupply_Pressure });

            jQuery('#linechart').highcharts({
                chart: {
                    type: 'line'
                },
                title: {
                    text: '曲线分析'
                },
                subtitle: {
                    text: null//'Source: WorldClimate.com'
                },
                xAxis: {
                    categories: xAxies
                },
                yAxis: {
                    title: {
                        text: null//'Temperature (°C)'
                    }
                },
           //     colors: ['#ff3333', '#33ff66', '#8bbc21', '#910000', '#1aadce',
           //'#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a'],
                credits: {
                    enabled: false
                },
                plotOptions: {
                    line: {
                        dataLabels: {
                            enabled: false
                        },
                        enableMouseTracking: true
                    }
                },
                series: serialAxies
            });
        });
    };
}]);

