var BookMeApp = angular.module('BookMeApp', [])

BookMeApp.controller('ClubsController', function ($scope) {
    $scope.message = "Test";
    $scope.clubs = null;

    $scope.init = function (model) {
        $scope.clubs = model.Clubs;
    };

    $scope.linkToManageClub = function (id) {
        window.location.href = "/Admin/Club/" + id;
    };

    $scope.linkToClubSchedule = function (url, id) {
        window.location.href = url + "/" + + id;
    };
});