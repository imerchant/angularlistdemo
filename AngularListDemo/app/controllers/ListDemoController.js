'use strict';

listDemo.controller('ListDemoController', function($scope, $log, itemData) {
    $scope.hello = 'hello world';

    $scope.save = function(input) {
        itemData.saveItem(input)
            .success(function(response) {
                $scope.items.push(response);
            });
    };

    $scope.deleteItem = function(itemId) {
        itemData.deleteItem(itemId)
            .success(function(response) {
                $scope.refreshItems();
            });
    };

    $scope.refreshItems = function() {
        itemData.getItems()
            .success(function(response) {
                $log.warn(response);
                $scope.items = response;
            });
    };

    $scope.refreshItems();
});