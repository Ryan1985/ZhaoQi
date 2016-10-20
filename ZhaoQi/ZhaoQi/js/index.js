"use strict";
var pageViewApp = angular.module('pageView', ['ngRoute', 'ngAnimate']);

pageViewApp.config(function($routeProvider) {
    $routeProvider
        .when('/', {
            //templateUrl: 'RealTime.html',
            controller: 'realTimeController'
        })
        .when('/Home/RealTime', {
            //templateUrl: 'RealTime.html',
            controller: 'realTimeController'
        })
        .when('/Home/HistoryData', {
            //templateUrl: 'HistoryData.html',
            controller: 'historyDataController'
        });


});


pageViewApp.controller('realTimeController', ['$scope', function($scope) {
    
}]);


pageViewApp.controller('historyDataController', ['$scope', function ($scope) {

}]);

