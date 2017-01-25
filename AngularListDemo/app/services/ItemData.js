'use strict';

listDemo.factory('itemData', function($http) {
    return {
        getItems: function() {
            return $http.get('/api/items');
        },
        saveItem: function(input) {
            return $http.post('/api/items', JSON.stringify({ "input": input }));
        },
        deleteItem: function(itemId) {
            return $http.delete('/api/items/' + itemId);
        }
    };
});