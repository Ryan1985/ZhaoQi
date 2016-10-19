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

}]);

